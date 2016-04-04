using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FixedXor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string ToHexString(string str)
        {
            string o = "";
            char[] values = str.ToCharArray();
            foreach (char letter in values)
            {
                int value = Convert.ToInt32(letter);
                o += String.Format("{0:x2}", value);
            }
            return o;
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if(tbInput.Text.Length == tbXOR.Text.Length)
            {
                // Convert input buffer to byte array
                byte[] inputbuffer = new byte[tbInput.Text.Length / 2];
                for (int i = 0; i < tbInput.Text.Length - 1; i++)
                {
                    inputbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbInput.Text.Substring(i, 2), 16));
                    i += 1;
                }

                // Convert XOR buffer to byte array
                byte[] xorbuffer = new byte[tbXOR.Text.Length / 2];
                for (int i = 0; i < tbXOR.Text.Length - 1; i++)
                {
                    xorbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbXOR.Text.Substring(i, 2), 16));
                    i += 1;
                }
                string o = "";

                byte[] outBuffer = new byte[tbInput.Text.Length / 2];
                for (int i=0; i < inputbuffer.Length; i++)
                {
                    outBuffer[i] = (byte)(inputbuffer[i] ^ xorbuffer[i]);
                    o += (char)(inputbuffer[i] ^ xorbuffer[i]);
                }
                tbOutput.Text = ToHexString(Encoding.Default.GetString(outBuffer)) + Environment.NewLine + Encoding.Default.GetString(outBuffer);
                
            }
            else
            {
                MessageBox.Show("Buffer lengths must match!");
            }
        }

        private void btnXORDecrypt_Click(object sender, EventArgs e)
        {
            if (tbOutput.Text.Length == tbXOR.Text.Length)
            {
                // Convert input buffer to byte array
                byte[] inputbuffer = new byte[tbOutput.Text.Length / 2];
                for (int i = 0; i < tbOutput.Text.Length - 1; i++)
                {
                    inputbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbOutput.Text.Substring(i, 2), 16));
                    i += 1;
                }

                // Convert XOR buffer to byte array
                byte[] xorbuffer = new byte[tbXOR.Text.Length / 2];
                for (int i = 0; i < tbXOR.Text.Length - 1; i++)
                {
                    xorbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbXOR.Text.Substring(i, 2), 16));
                    i += 1;
                }
                string o = "";

                byte[] outBuffer = new byte[tbOutput.Text.Length / 2];
                for (int i = 0; i < inputbuffer.Length; i++)
                {
                    outBuffer[i] = (byte)(inputbuffer[i] ^ xorbuffer[i]);
                    o += (char)(inputbuffer[i] ^ xorbuffer[i]);
                }
                tbInput.Text = ToHexString(Encoding.Default.GetString(outBuffer));
            }
            else if(tbXOR.Text.Length == 2)
            {
                // Convert input buffer to byte array
                byte[] inputbuffer = new byte[tbOutput.Text.Length / 2];
                for (int i = 0; i < tbOutput.Text.Length - 1; i++)
                {
                    inputbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbOutput.Text.Substring(i, 2), 16));
                    i += 1;
                }

                // Convert XOR buffer to byte array
                byte[] xorbuffer = new byte[tbXOR.Text.Length / 2];
                for (int i = 0; i < tbXOR.Text.Length - 1; i++)
                {
                    xorbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbXOR.Text.Substring(i, 2), 16));
                    i += 1;
                }
                string o = "";

                byte[] outBuffer = new byte[tbOutput.Text.Length / 2];
                for (int i = 0; i < inputbuffer.Length; i++)
                {
                    outBuffer[i] = (byte)(inputbuffer[i] ^ xorbuffer[0]);
                    o += (char)(inputbuffer[i] ^ xorbuffer[0]);
                }
                tbInput.Text = ToHexString(Encoding.Default.GetString(outBuffer)) + Environment.NewLine + Encoding.Default.GetString(outBuffer);
            }
            else
            {
                MessageBox.Show("Buffer lenghts must match!");
            }
        }

        private void btnXORDetection_Click(object sender, EventArgs e)
        {
            List<Char> printableChars = new List<char>();
            for (int i = char.MinValue; i <= 255; i++)
            {
                char c = Convert.ToChar(i);
                if (!char.IsControl(c))
                {
                    printableChars.Add(c);
                }
            }
            foreach(char c in printableChars)
            {
                // Convert input buffer to byte array
                byte[] inputbuffer = new byte[tbOutput.Text.Length / 2];
                for (int i = 0; i < tbOutput.Text.Length - 1; i++)
                {
                    inputbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbOutput.Text.Substring(i, 2), 16));
                    i += 1;
                }

                // Convert XOR buffer to byte array

                byte xorbuffer = Convert.ToByte(c);
                string o = "";

                byte[] outBuffer = new byte[tbOutput.Text.Length / 2];
                for (int i = 0; i < inputbuffer.Length; i++)
                {
                    outBuffer[i] = (byte)(inputbuffer[i] ^ xorbuffer);
                    o += (char)(inputbuffer[i] ^ xorbuffer);
                }
                tbInput.Text += c.ToString() + ":" + ToHexString(Encoding.Default.GetString(outBuffer)) + Environment.NewLine + Encoding.Default.GetString(outBuffer) + Environment.NewLine + "------------" + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbInput.Text = null;
            tbOutput.Text = null;
            tbXOR.Text = null;
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string line;
                            StreamReader file = new StreamReader(myStream);
                            while ((line = file.ReadLine()) != null)
                            {
                                List<Char> printableChars = new List<char>();
                                for (int i = char.MinValue; i <= 255; i++)
                                {
                                    char c = Convert.ToChar(i);
                                    if (!char.IsControl(c))
                                    {
                                        printableChars.Add(c);
                                    }
                                }
                                foreach (char c in printableChars)
                                {
                                    // Convert input buffer to byte array
                                    byte[] inputbuffer = new byte[line.Length / 2];
                                    for (int i = 0; i < line.Length - 1; i++)
                                    {
                                        inputbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(line.Substring(i, 2), 16));
                                        i += 1;
                                    }

                                    // Convert XOR buffer to byte array

                                    byte xorbuffer = Convert.ToByte(c);
                                    string o = "";

                                    byte[] outBuffer = new byte[inputbuffer.Length];
                                    for (int i = 0; i < inputbuffer.Length; i++)
                                    {
                                        outBuffer[i] = (byte)(inputbuffer[i] ^ xorbuffer);
                                        o += (char)(inputbuffer[i] ^ xorbuffer);
                                    }
                                    var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

                                    if (regexItem.IsMatch(Encoding.Default.GetString(outBuffer)))
                                    {
                                        tbInput.Text += c.ToString() + ":" + ToHexString(Encoding.Default.GetString(outBuffer)) + Environment.NewLine + Encoding.Default.GetString(outBuffer) + Environment.NewLine + "------------" + Environment.NewLine;
                                    }
                                }
                            }

                            file.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.ToString());
                }
            }
        }

        private void btnRepeatByteXOREncrypt_Click_1(object sender, EventArgs e)
        {
            string hex = ToHexString(tbInput.Text);
            // Convert input buffer to byte array
            byte[] inputbuffer = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length - 1; i++)
            {
                inputbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(hex.Substring(i, 2), 16));
                i += 1;
            }

            // Convert XOR buffer to byte array
            string xorHex = ToHexString(tbXOR.Text);
            byte[] xorbuffer = new byte[xorHex.Length / 2];
            for (int i = 0; i < xorHex.Length - 1; i++)
            {
                xorbuffer[i / 2] = Convert.ToByte(Convert.ToInt32(xorHex.Substring(i, 2), 16));
                i += 1;
            }
            string o = "";

            byte[] outBuffer = new byte[hex.Length / 2];
            int xorBufferCount = 0;
            for (int i = 0; i < inputbuffer.Length; i++)
            {
                outBuffer[i] = (byte)(inputbuffer[i] ^ xorbuffer[xorBufferCount]);
                o += (char)(inputbuffer[i] ^ xorbuffer[xorBufferCount]);
                if(xorBufferCount < xorbuffer.Length - 1)
                {
                    xorBufferCount += 1;
                }
                else
                {
                    xorBufferCount = 0;
                }
            }
            tbOutput.Text = ToHexString(Encoding.Default.GetString(outBuffer)) + Environment.NewLine + Encoding.Default.GetString(outBuffer);


        }
    }
}
