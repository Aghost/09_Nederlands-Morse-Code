namespace _09_Morse_Code
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
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Btn_ToMorse = new System.Windows.Forms.Button();
            this.Btn_FromMorse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 12);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(595, 266);
            this.TextBox.TabIndex = 1;
            // 
            // Btn_ToMorse
            // 
            this.Btn_ToMorse.Location = new System.Drawing.Point(12, 284);
            this.Btn_ToMorse.Name = "Btn_ToMorse";
            this.Btn_ToMorse.Size = new System.Drawing.Size(122, 40);
            this.Btn_ToMorse.TabIndex = 2;
            this.Btn_ToMorse.Text = "To MorseCode";
            this.Btn_ToMorse.UseVisualStyleBackColor = true;
            this.Btn_ToMorse.Click += new System.EventHandler(this.Btn_ToMorse_Click);
            // 
            // Btn_FromMorse
            // 
            this.Btn_FromMorse.Location = new System.Drawing.Point(485, 284);
            this.Btn_FromMorse.Name = "Btn_FromMorse";
            this.Btn_FromMorse.Size = new System.Drawing.Size(122, 40);
            this.Btn_FromMorse.TabIndex = 3;
            this.Btn_FromMorse.Text = "From MorseCode";
            this.Btn_FromMorse.UseVisualStyleBackColor = true;
            this.Btn_FromMorse.Click += new System.EventHandler(this.Btn_FromMorse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 334);
            this.Controls.Add(this.Btn_FromMorse);
            this.Controls.Add(this.Btn_ToMorse);
            this.Controls.Add(this.TextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button Btn_ToMorse;
        private System.Windows.Forms.Button Btn_FromMorse;
    }
}

