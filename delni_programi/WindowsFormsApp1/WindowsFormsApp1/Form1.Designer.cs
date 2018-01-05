namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.mojGumb = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.drugiGumb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // mojGumb
            // 
            this.mojGumb.Location = new System.Drawing.Point(495, 187);
            this.mojGumb.Name = "mojGumb";
            this.mojGumb.Size = new System.Drawing.Size(274, 69);
            this.mojGumb.TabIndex = 1;
            this.mojGumb.Text = "ZAPRI";
            this.mojGumb.UseVisualStyleBackColor = true;
            this.mojGumb.Click += new System.EventHandler(this.mojGumb_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // drugiGumb
            // 
            this.drugiGumb.Location = new System.Drawing.Point(539, 339);
            this.drugiGumb.Name = "drugiGumb";
            this.drugiGumb.Size = new System.Drawing.Size(153, 23);
            this.drugiGumb.TabIndex = 3;
            this.drugiGumb.Text = "Jaz sem drugi gumb";
            this.drugiGumb.UseVisualStyleBackColor = true;
            this.drugiGumb.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1149, 668);
            this.Controls.Add(this.drugiGumb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mojGumb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Waknce";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mojGumb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button drugiGumb;
    }
}

