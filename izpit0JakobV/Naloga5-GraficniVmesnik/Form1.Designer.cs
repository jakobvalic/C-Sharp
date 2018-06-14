namespace Naloga5_GraficniVmesnik
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
            this.components = new System.ComponentModel.Container();
            this.uraBarvaj = new System.Windows.Forms.Timer(this.components);
            this.barvnoPodrocje = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.izpisStevilaZelenih = new System.Windows.Forms.Label();
            this.izpisStevilaVijolicnih = new System.Windows.Forms.Label();
            this.izpisStevilaRdecih = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barvnoPodrocje)).BeginInit();
            this.SuspendLayout();
            // 
            // uraBarvaj
            // 
            this.uraBarvaj.Enabled = true;
            this.uraBarvaj.Interval = 500;
            this.uraBarvaj.Tick += new System.EventHandler(this.uraBarvaj_Tick);
            // 
            // barvnoPodrocje
            // 
            this.barvnoPodrocje.BackColor = System.Drawing.Color.Green;
            this.barvnoPodrocje.Location = new System.Drawing.Point(101, 86);
            this.barvnoPodrocje.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barvnoPodrocje.Name = "barvnoPodrocje";
            this.barvnoPodrocje.Size = new System.Drawing.Size(83, 76);
            this.barvnoPodrocje.TabIndex = 0;
            this.barvnoPodrocje.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zelenih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vijoličnih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rdečih:";
            // 
            // izpisStevilaZelenih
            // 
            this.izpisStevilaZelenih.AutoSize = true;
            this.izpisStevilaZelenih.Location = new System.Drawing.Point(231, 197);
            this.izpisStevilaZelenih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.izpisStevilaZelenih.Name = "izpisStevilaZelenih";
            this.izpisStevilaZelenih.Size = new System.Drawing.Size(0, 17);
            this.izpisStevilaZelenih.TabIndex = 6;
            // 
            // izpisStevilaVijolicnih
            // 
            this.izpisStevilaVijolicnih.AutoSize = true;
            this.izpisStevilaVijolicnih.Location = new System.Drawing.Point(231, 228);
            this.izpisStevilaVijolicnih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.izpisStevilaVijolicnih.Name = "izpisStevilaVijolicnih";
            this.izpisStevilaVijolicnih.Size = new System.Drawing.Size(16, 17);
            this.izpisStevilaVijolicnih.TabIndex = 7;
            this.izpisStevilaVijolicnih.Text = "0";
            // 
            // izpisStevilaRdecih
            // 
            this.izpisStevilaRdecih.AutoSize = true;
            this.izpisStevilaRdecih.Location = new System.Drawing.Point(231, 261);
            this.izpisStevilaRdecih.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.izpisStevilaRdecih.Name = "izpisStevilaRdecih";
            this.izpisStevilaRdecih.Size = new System.Drawing.Size(16, 17);
            this.izpisStevilaRdecih.TabIndex = 8;
            this.izpisStevilaRdecih.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 459);
            this.Controls.Add(this.izpisStevilaRdecih);
            this.Controls.Add(this.izpisStevilaVijolicnih);
            this.Controls.Add(this.izpisStevilaZelenih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barvnoPodrocje);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barvnoPodrocje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer uraBarvaj;
        private System.Windows.Forms.PictureBox barvnoPodrocje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label izpisStevilaZelenih;
        private System.Windows.Forms.Label izpisStevilaVijolicnih;
        private System.Windows.Forms.Label izpisStevilaRdecih;
        private System.Windows.Forms.Timer timer1;
    }
}

