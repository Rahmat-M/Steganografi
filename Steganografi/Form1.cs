using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Steganography
{
    public partial class Form1 : Form
    {
        //field
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public enum Mode
        {
            Image,
            Audio
        }

        Image image;
        byte[] audio;
        byte[] file;
        string filename;
        Mode currentMode;
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            OutputConsole.Bind(console);
            OutputConsole2.Bind(console2);

            currentMode = Mode.Image;
            stopwatch = new Stopwatch();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 80);
            panelMenu.Controls.Add(leftBorderBtn);
            //menghilangkan control box form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private struct RGBcolors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextAboveImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                //left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(123, 33, 253);
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageAboveText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
           
        }
        //drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lparam);
        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
           
        }




        private void console_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = console.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(console.Items[index].ToString());
            }
        }


        private void console_KeyDown(object sender, KeyEventArgs e)
        {
            if (console.SelectedIndex >= 0 && e.KeyCode == Keys.Delete)
            {
                console.Items.RemoveAt(console.SelectedIndex);
            }
        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            panelHome.BringToFront();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            panelAbout.BringToFront();
            
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
            imageBox.Visible = true;
            audioLabel.Visible = true;
            loadWavFile.Visible = true;
            textBox.Visible = true;
            console.Visible = true;
            encryptButton.Visible = true;
            lblEncode.Visible = true;

            imageBox2.Visible = false;
            audioLabel2.Visible = false;
            loadWavFile2.Visible = false;
            textBox2.Visible = false;
            console2.Visible = false;
            decryptButton.Visible = false;
            lblDecode.Visible = false;
            mainPanel.BringToFront();
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBcolors.color6);
           
            imageBox.Visible = false;
            audioLabel.Visible = false;
            loadWavFile.Visible = false;
            textBox.Visible = false;
            console.Visible = false;
            encryptButton.Visible = false;
            lblEncode.Visible = false;

            imageBox2.Visible = true;
            audioLabel2.Visible = true;
            loadWavFile2.Visible = true;
            textBox2.Visible = true;
            console2.Visible = true;
            lblDecode.Visible = true;
            decryptButton.Visible = true;
            mainPanel.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //panelHome.BringToFront();
            panelHome.BringToFront();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Audio && audio != null)
            {
                byte[] file;

                file = AudioSteganography.EncryptTextLinear(audio, textBox.Text);

                if (file != null)
                {
                    DialogResult res = saveWav.ShowDialog();
                    if (res == System.Windows.Forms.DialogResult.OK)
                    {
                        File.WriteAllBytes(saveWav.FileName, file);
                        OutputConsole.Write("Wav file saved");
                    }
                }
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (currentMode == Mode.Audio && audio != null)
            {
                string text;

                text = AudioSteganography.DecryptTextLinear(audio);

                if (text != null)
                {
                    textBox2.Text = text;
                    OutputConsole2.Write("Text decrypted");
                }
            }
        }

        private void loadWavFile2_Click(object sender, EventArgs e)
        {
            DialogResult res = loadWav.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                audio = File.ReadAllBytes(loadWav.FileName);
                WavAudio wav = new WavAudio(audio);
                if (wav.data != null)
                {
                    OutputConsole2.Write(string.Format("Audio loaded \nSamples found: {0}", wav.totalSamples));
                    OutputConsole2.Write(string.Format("Maximum file size for this file = {0} - (file size digits + file name character count) bytes", FileSizeFormatProvider.GetFileSize(wav.bytesAvailable)));
                    currentMode = Mode.Audio;
                    if (image != null)
                    {
                        image.Dispose();
                    }
                    image = null;
                    imageBox.Image = null;
                    audioLabel.Text = string.Format("Using Wav File: {0}", loadWav.SafeFileName);
                    audioLabel2.Text = string.Format("Using Wav File: {0}", loadWav.SafeFileName);
                    audioLabel2.Visible = true;
                }
                else
                {
                    audio = null;
                }
            }
        }

        private void loadWavFile_Click(object sender, EventArgs e)
        {
            DialogResult res = loadWav.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                audio = File.ReadAllBytes(loadWav.FileName);
                WavAudio wav = new WavAudio(audio);
                if (wav.data != null)
                {
                    OutputConsole.Write(string.Format("Audio loaded \nSamples found: {0}", wav.totalSamples));
                    OutputConsole.Write(string.Format("Maximum file size for this file = {0} - (file size digits + file name character count) bytes", FileSizeFormatProvider.GetFileSize(wav.bytesAvailable)));
                    currentMode = Mode.Audio;
                    if (image != null)
                    {
                        image.Dispose();
                    }
                    image = null;
                    imageBox.Image = null;
                    audioLabel.Text = string.Format("Using Wav File: {0}", loadWav.SafeFileName);
                    audioLabel2.Text = string.Format("Using Wav File: {0}", loadWav.SafeFileName);
                    audioLabel.Visible = true;
                }
                else
                {
                    audio = null;
                }
            }
        }
    }
}
