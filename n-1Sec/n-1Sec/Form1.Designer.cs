namespace n_1Sec
{
    partial class frmHexToBase64
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.tbBase64 = new System.Windows.Forms.TextBox();
            this.btnHexToBase64 = new System.Windows.Forms.Button();
            this.btnBase64ToHex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HEX:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Base 64:";
            // 
            // tbHex
            // 
            this.tbHex.Location = new System.Drawing.Point(15, 70);
            this.tbHex.Multiline = true;
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(550, 186);
            this.tbHex.TabIndex = 2;
            // 
            // tbBase64
            // 
            this.tbBase64.Location = new System.Drawing.Point(15, 275);
            this.tbBase64.Multiline = true;
            this.tbBase64.Name = "tbBase64";
            this.tbBase64.Size = new System.Drawing.Size(550, 186);
            this.tbBase64.TabIndex = 3;
            // 
            // btnHexToBase64
            // 
            this.btnHexToBase64.Location = new System.Drawing.Point(15, 12);
            this.btnHexToBase64.Name = "btnHexToBase64";
            this.btnHexToBase64.Size = new System.Drawing.Size(92, 23);
            this.btnHexToBase64.TabIndex = 4;
            this.btnHexToBase64.Text = "HEX -> Base64";
            this.btnHexToBase64.UseVisualStyleBackColor = true;
            this.btnHexToBase64.Click += new System.EventHandler(this.btnHexToBase64_Click);
            // 
            // btnBase64ToHex
            // 
            this.btnBase64ToHex.Location = new System.Drawing.Point(113, 12);
            this.btnBase64ToHex.Name = "btnBase64ToHex";
            this.btnBase64ToHex.Size = new System.Drawing.Size(92, 23);
            this.btnBase64ToHex.TabIndex = 5;
            this.btnBase64ToHex.Text = "Base64 -> HEX";
            this.btnBase64ToHex.UseVisualStyleBackColor = true;
            this.btnBase64ToHex.Click += new System.EventHandler(this.btnBase64ToHex_Click);
            // 
            // frmHexToBase64
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 473);
            this.Controls.Add(this.btnBase64ToHex);
            this.Controls.Add(this.btnHexToBase64);
            this.Controls.Add(this.tbBase64);
            this.Controls.Add(this.tbHex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHexToBase64";
            this.Text = "Hex To Base 64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.TextBox tbBase64;
        private System.Windows.Forms.Button btnHexToBase64;
        private System.Windows.Forms.Button btnBase64ToHex;
    }
}

