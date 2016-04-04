using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace n_1Sec
{
    public partial class frmHexToBase64 : Form
    {
        public frmHexToBase64()
        {
            InitializeComponent();
        }
        private void btnHexToBase64_Click(object sender, EventArgs e)
        {
            
            try
            {
                // Convert the input text (HEX) to array of bytes
                byte[] buffer = new byte[tbHex.Text.Length / 2];
                for (int i = 0; i < tbHex.Text.Length; i++)
                {
                    buffer[i / 2] = Convert.ToByte(Convert.ToInt32(tbHex.Text.Substring(i, 2), 16));
                    i += 1;
                }
                // Encode the byte array using Base64 encoding
                String base64 = Convert.ToBase64String(buffer);
                tbBase64.Text = base64;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnBase64ToHex_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = Convert.FromBase64String(tbBase64.Text);
                string value = ASCIIEncoding.ASCII.GetString(bytes);
                tbHex.Text = value;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
