using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Steganography
{
    public static class AudioSteganography
    {
        
        public static byte[] EncryptTextLinear(byte[] wav, string text)
        {
            WavAudio audio = new WavAudio(wav);
            uint value = 0;
            string pass = string.Format(audio.bitsPerSample.ToString());
            AESEncrypt encrypt = new AESEncrypt();
            string encrypted = encrypt.EncryptString(text, pass);
            OutputConsole.Write(string.Format("Text encrypted \n{0}", encrypted));
            if (encrypted.Length <= Math.Floor((double)(audio.totalSamples / 8)))
            {
                uint n = 0;
                OutputConsole.Write("Seed generated");
                OutputConsole.Write("Processing wav file...");
                for (int i = 0; i < encrypted.Length; i++)
                {
                    value = encrypted[i];
                    for (int x = 0; x < 8; x++)
                    {
                        uint sample = n;
                        uint sampleValue = audio.samples[sample];
                        sampleValue = (sampleValue & 0xFFFFFFFE) | ((value >> x) & 1);
                        audio.samples[sample] = sampleValue;
                        n++;
                    }

                }
                value = 0;
                for (int x = 0; x < 8; x++)
                {
                    uint sample = n;
                    uint sampleValue = audio.samples[sample];
                    sampleValue = (sampleValue & 0xFFFFFFFE) | ((value >> x) & 1);
                    audio.samples[sample] = sampleValue;
                    n++;
                }
                audio.Save();
                OutputConsole.Write(string.Format("Text encrypted... used {0} samples", encrypted.Length * 8));
                OutputConsole.Write("Saving wav file");
                return audio.data;
            }
            else
            {
                return null;
            }

        }

        public static string DecryptTextLinear(byte[] wav)
        {
            WavAudio audio = new WavAudio(wav);
            string text = string.Empty;
            uint n = 0;
            uint value = 0;
            string pass = string.Format(audio.bitsPerSample.ToString());
            AESEncrypt encrypt = new AESEncrypt();
            OutputConsole2.Write("Processing wav file...");
            do
            {
                value = 0;
                for (int x = 0; x < 8; x++)
                {
                    uint sample = n;
                    uint sampleValue = audio.samples[sample];
                    value = value | ((sampleValue & 1) << x);
                    n++;
                }
                if (value != 0)
                    text += Convert.ToChar(value);
            } while (value != 0);
            OutputConsole2.Write("Decrypting text...");
            try
            {
                return encrypt.DecryptString(text, pass);
            }
            catch (Exception e)
            {
                OutputConsole2.Write("Error: Text not found");
                Console.WriteLine(e.Message);
                return null;
            }
        }
       
    }
}