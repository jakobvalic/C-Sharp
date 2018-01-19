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
            this.barvnoPodrocje.Location = new System.Drawing.Point(76, 70);
            this.barvnoPodrocje.Name = "barvnoPodrocje";
            this.barvnoPodrocje.Size = new System.Drawing.Size(62, 62);
            this.barvnoPodrocje.TabIndex = 0;
            this.barvnoPodrocje.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Zelenih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vijoličnih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rdečih:";
            // 
            // izpisStevilaZelenih
            // 
            this.izpisStevilaZelenih.AutoSize = true;
            this.izpisStevilaZelenih.Location = new System.Drawing.Point(173, 160);
            this.izpisStevilaZelenih.Name = "izpisStevilaZelenih";
            this.izpisStevilaZelenih.Size = new System.Drawing.Size(0, 13);
            this.izpisStevilaZelenih.TabIndex = 6;
            // 
            // izpisStevilaVijolicnih
            // 
            this.izpisStevilaVijolicnih.AutoSize = true;
            this.izpisStevilaVijolicnih.Location = new System.Drawing.Point(173, 185);
            this.izpisStevilaVijolicnih.Name = "izpisStevilaVijolicnih";
            this.izpisStevilaVijolicnih.Size = new System.Drawing.Size(13, 13);
            this.izpisStevilaVijolicnih.TabIndex = 7;
            this.izpisStevilaVijolicnih.Text = "0";
            // 
            // izpisStevilaRdecih
            // 
            this.izpisStevilaRdecih.AutoSize = true;
            this.izpisStevilaRdecih.Location = new System.Drawing.Point(173, 212);
            this.izpisStevilaRdecih.Name = "izpisStevilaRdecih";
            this.izpisStevilaRdecih.Size = new System.Drawing.Size(13, 13);
            this.izpisStevilaRdecih.TabIndex = 8;
            this.izpisStevilaRdecih.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 373);
            this.Controls.Add(this.izpisStevilaRdecih);
            this.Controls.Add(this.izpisStevilaVijolicnih);
            this.Controls.Add(this.izpisStevilaZelenih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barvnoPodrocje);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
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
    }
}

