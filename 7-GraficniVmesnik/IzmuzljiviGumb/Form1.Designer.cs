namespace IzmuzljiviGumb
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
            this.Gumb1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Gumb1
            // 
            this.Gumb1.Location = new System.Drawing.Point(81, 67);
            this.Gumb1.Name = "Gumb1";
            this.Gumb1.Size = new System.Drawing.Size(113, 26);
            this.Gumb1.TabIndex = 0;
            this.Gumb1.Text = "Izmuzljivi gumb";
            this.Gumb1.UseVisualStyleBackColor = true;
            this.Gumb1.Click += new System.EventHandler(this.Gumb1_Click);
            this.Gumb1.MouseEnter += new System.EventHandler(this.Gumb1_Click); // Tu registriramo dogodke na funkcije
            this.Gumb1.MouseHover += new System.EventHandler(this.Gumb1_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Gumb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Gumb1;
    }
}

