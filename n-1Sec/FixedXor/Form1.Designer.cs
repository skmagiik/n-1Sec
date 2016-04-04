namespace FixedXor
{
    partial class Form1
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
            this.lblBuffer1 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnXORDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXORDetection = new System.Windows.Forms.Button();
            this.btnCheckTxt = new System.Windows.Forms.Button();
            this.btnRepeatByteXOREncrypt = new System.Windows.Forms.Button();
            this.tbInput = new System.Windows.Forms.RichTextBox();
            this.tbXOR = new System.Windows.Forms.RichTextBox();
            this.tbOutput = new System.Windows.Forms.RichTextBox();
            this.btnRepeatXORDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBuffer1
            // 
            this.lblBuffer1.AutoSize = true;
            this.lblBuffer1.Location = new System.Drawing.Point(9, 118);
            this.lblBuffer1.Name = "lblBuffer1";
            this.lblBuffer1.Size = new System.Drawing.Size(65, 13);
            this.lblBuffer1.TabIndex = 0;
            this.lblBuffer1.Text = "Input Buffer:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(12, 12);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(83, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "XOR Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnXORDecrypt
            // 
            this.btnXORDecrypt.Location = new System.Drawing.Point(101, 12);
            this.btnXORDecrypt.Name = "btnXORDecrypt";
            this.btnXORDecrypt.Size = new System.Drawing.Size(83, 23);
            this.btnXORDecrypt.TabIndex = 2;
            this.btnXORDecrypt.Text = "XOR Decrypt";
            this.btnXORDecrypt.UseVisualStyleBackColor = true;
            this.btnXORDecrypt.Click += new System.EventHandler(this.btnXORDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "XOR Buffer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encrypted:";
            // 
            // btnXORDetection
            // 
            this.btnXORDetection.Location = new System.Drawing.Point(190, 12);
            this.btnXORDetection.Name = "btnXORDetection";
            this.btnXORDetection.Size = new System.Drawing.Size(94, 23);
            this.btnXORDetection.TabIndex = 8;
            this.btnXORDetection.Text = "Single Byte XOR";
            this.btnXORDetection.UseVisualStyleBackColor = true;
            this.btnXORDetection.Click += new System.EventHandler(this.btnXORDetection_Click);
            // 
            // btnCheckTxt
            // 
            this.btnCheckTxt.Location = new System.Drawing.Point(287, 12);
            this.btnCheckTxt.Name = "btnCheckTxt";
            this.btnCheckTxt.Size = new System.Drawing.Size(75, 23);
            this.btnCheckTxt.TabIndex = 9;
            this.btnCheckTxt.Text = "Check TXT";
            this.btnCheckTxt.UseVisualStyleBackColor = true;
            this.btnCheckTxt.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRepeatByteXOREncrypt
            // 
            this.btnRepeatByteXOREncrypt.Location = new System.Drawing.Point(12, 41);
            this.btnRepeatByteXOREncrypt.Name = "btnRepeatByteXOREncrypt";
            this.btnRepeatByteXOREncrypt.Size = new System.Drawing.Size(172, 23);
            this.btnRepeatByteXOREncrypt.TabIndex = 10;
            this.btnRepeatByteXOREncrypt.Text = "Repeating-key XOR Encrypt";
            this.btnRepeatByteXOREncrypt.UseVisualStyleBackColor = true;
            this.btnRepeatByteXOREncrypt.Click += new System.EventHandler(this.btnRepeatByteXOREncrypt_Click_1);
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(79, 118);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(509, 55);
            this.tbInput.TabIndex = 11;
            this.tbInput.Text = "";
            // 
            // tbXOR
            // 
            this.tbXOR.Location = new System.Drawing.Point(79, 179);
            this.tbXOR.Name = "tbXOR";
            this.tbXOR.Size = new System.Drawing.Size(509, 55);
            this.tbXOR.TabIndex = 12;
            this.tbXOR.Text = "";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(79, 240);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(509, 55);
            this.tbOutput.TabIndex = 13;
            this.tbOutput.Text = "";
            // 
            // btnRepeatXORDecrypt
            // 
            this.btnRepeatXORDecrypt.Location = new System.Drawing.Point(190, 41);
            this.btnRepeatXORDecrypt.Name = "btnRepeatXORDecrypt";
            this.btnRepeatXORDecrypt.Size = new System.Drawing.Size(172, 23);
            this.btnRepeatXORDecrypt.TabIndex = 14;
            this.btnRepeatXORDecrypt.Text = "Repeating-key XOR Decrypt";
            this.btnRepeatXORDecrypt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 303);
            this.Controls.Add(this.btnRepeatXORDecrypt);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbXOR);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.btnRepeatByteXOREncrypt);
            this.Controls.Add(this.btnCheckTxt);
            this.Controls.Add(this.btnXORDetection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnXORDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.lblBuffer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuffer1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnXORDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXORDetection;
        private System.Windows.Forms.Button btnCheckTxt;
        private System.Windows.Forms.Button btnRepeatByteXOREncrypt;
        private System.Windows.Forms.RichTextBox tbInput;
        private System.Windows.Forms.Button btnRepeatXORDecrypt;
        private System.Windows.Forms.RichTextBox tbOutput;
        private System.Windows.Forms.RichTextBox tbXOR;
    }
}

