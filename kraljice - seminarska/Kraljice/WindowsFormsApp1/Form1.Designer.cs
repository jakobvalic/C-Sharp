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
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gumbPrikažiVseRešitve = new System.Windows.Forms.Button();
            this.časovnikVseRešitve = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelŠtevecRešitev = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gumbNaslednjaRešitevPoKorakih = new System.Windows.Forms.Button();
            this.labelŠteviloKorakov = new System.Windows.Forms.Label();
            this.časovnikKorakiRešitve = new System.Windows.Forms.Timer(this.components);
            this.gumbUstavi = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelStevecKorakov = new System.Windows.Forms.Label();
            this.gumbSkočiNaRešitev = new System.Windows.Forms.Button();
            this.numericUpDownSkočiNaRešitev = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkočiNaRešitev)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.kraljica_bela;
            this.pictureBox1.Location = new System.Drawing.Point(1206, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gumbPrikažiVseRešitve
            // 
            this.gumbPrikažiVseRešitve.Location = new System.Drawing.Point(1195, 348);
            this.gumbPrikažiVseRešitve.Name = "gumbPrikažiVseRešitve";
            this.gumbPrikažiVseRešitve.Size = new System.Drawing.Size(139, 41);
            this.gumbPrikažiVseRešitve.TabIndex = 2;
            this.gumbPrikažiVseRešitve.Text = "Prikaži vse rešitve";
            this.gumbPrikažiVseRešitve.UseVisualStyleBackColor = true;
            this.gumbPrikažiVseRešitve.Click += new System.EventHandler(this.gumbPrikažiVseRešitve_Click);
            // 
            // časovnikVseRešitve
            // 
            this.časovnikVseRešitve.Interval = 2000;
            this.časovnikVseRešitve.Tick += new System.EventHandler(this.časovnikVseRešitve_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1195, 301);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.hitrostPredvajanja);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(980, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "REŠITEV ŠTEVILKA: ";
            // 
            // labelŠtevecRešitev
            // 
            this.labelŠtevecRešitev.AutoSize = true;
            this.labelŠtevecRešitev.Location = new System.Drawing.Point(1036, 402);
            this.labelŠtevecRešitev.Name = "labelŠtevecRešitev";
            this.labelŠtevecRešitev.Size = new System.Drawing.Size(12, 17);
            this.labelŠtevecRešitev.TabIndex = 5;
            this.labelŠtevecRešitev.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1057, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hitrost (desetinke): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(366, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "PROBLEM OSMIH KRALJIC";
            // 
            // gumbNaslednjaRešitevPoKorakih
            // 
            this.gumbNaslednjaRešitevPoKorakih.Location = new System.Drawing.Point(1195, 412);
            this.gumbNaslednjaRešitevPoKorakih.Name = "gumbNaslednjaRešitevPoKorakih";
            this.gumbNaslednjaRešitevPoKorakih.Size = new System.Drawing.Size(242, 44);
            this.gumbNaslednjaRešitevPoKorakih.TabIndex = 10;
            this.gumbNaslednjaRešitevPoKorakih.Text = "Poišči naslednjo rešitev po korakih";
            this.gumbNaslednjaRešitevPoKorakih.UseVisualStyleBackColor = true;
            this.gumbNaslednjaRešitevPoKorakih.Click += new System.EventHandler(this.gumbNaslednjaRešitevPoKorakih_Click);
            // 
            // labelŠteviloKorakov
            // 
            this.labelŠteviloKorakov.AutoSize = true;
            this.labelŠteviloKorakov.Location = new System.Drawing.Point(1192, 482);
            this.labelŠteviloKorakov.Name = "labelŠteviloKorakov";
            this.labelŠteviloKorakov.Size = new System.Drawing.Size(215, 17);
            this.labelŠteviloKorakov.TabIndex = 12;
            this.labelŠteviloKorakov.Text = "Število korakov naslednje rešitve";
            // 
            // časovnikKorakiRešitve
            // 
            this.časovnikKorakiRešitve.Interval = 1000;
            this.časovnikKorakiRešitve.Tick += new System.EventHandler(this.časovnikKorakiRešitve_Tick);
            // 
            // gumbUstavi
            // 
            this.gumbUstavi.Location = new System.Drawing.Point(1360, 348);
            this.gumbUstavi.Name = "gumbUstavi";
            this.gumbUstavi.Size = new System.Drawing.Size(139, 41);
            this.gumbUstavi.TabIndex = 13;
            this.gumbUstavi.Text = "Ustavi";
            this.gumbUstavi.UseVisualStyleBackColor = true;
            this.gumbUstavi.Click += new System.EventHandler(this.gumbUstavi_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.kraljica_rdeca;
            this.pictureBox2.Location = new System.Drawing.Point(1062, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 94);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1168, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "-->>";
            // 
            // labelStevecKorakov
            // 
            this.labelStevecKorakov.AutoSize = true;
            this.labelStevecKorakov.Location = new System.Drawing.Point(1192, 513);
            this.labelStevecKorakov.Name = "labelStevecKorakov";
            this.labelStevecKorakov.Size = new System.Drawing.Size(105, 17);
            this.labelStevecKorakov.TabIndex = 16;
            this.labelStevecKorakov.Text = "Števec korakov";
            // 
            // gumbSkočiNaRešitev
            // 
            this.gumbSkočiNaRešitev.Location = new System.Drawing.Point(1195, 558);
            this.gumbSkočiNaRešitev.Name = "gumbSkočiNaRešitev";
            this.gumbSkočiNaRešitev.Size = new System.Drawing.Size(139, 41);
            this.gumbSkočiNaRešitev.TabIndex = 17;
            this.gumbSkočiNaRešitev.Text = "Skoči na rešitev";
            this.gumbSkočiNaRešitev.UseVisualStyleBackColor = true;
            this.gumbSkočiNaRešitev.Click += new System.EventHandler(this.gumbSkočiNaRešitev_Click);
            // 
            // numericUpDownSkočiNaRešitev
            // 
            this.numericUpDownSkočiNaRešitev.Location = new System.Drawing.Point(1355, 568);
            this.numericUpDownSkočiNaRešitev.Maximum = new decimal(new int[] {
            92,
            0,
            0,
            0});
            this.numericUpDownSkočiNaRešitev.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSkočiNaRešitev.Name = "numericUpDownSkočiNaRešitev";
            this.numericUpDownSkočiNaRešitev.Size = new System.Drawing.Size(52, 22);
            this.numericUpDownSkočiNaRešitev.TabIndex = 18;
            this.numericUpDownSkočiNaRešitev.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1542, 635);
            this.Controls.Add(this.numericUpDownSkočiNaRešitev);
            this.Controls.Add(this.gumbSkočiNaRešitev);
            this.Controls.Add(this.labelStevecKorakov);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gumbUstavi);
            this.Controls.Add(this.labelŠteviloKorakov);
            this.Controls.Add(this.gumbNaslednjaRešitevPoKorakih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelŠtevecRešitev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gumbPrikažiVseRešitve);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Problem 8-ih kraljic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkočiNaRešitev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gumbPrikažiVseRešitve;
        private System.Windows.Forms.Timer časovnikVseRešitve;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelŠtevecRešitev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gumbNaslednjaRešitevPoKorakih;
        private System.Windows.Forms.Label labelŠteviloKorakov;
        private System.Windows.Forms.Timer časovnikKorakiRešitve;
        private System.Windows.Forms.Button gumbUstavi;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelStevecKorakov;
        private System.Windows.Forms.Button gumbSkočiNaRešitev;
        private System.Windows.Forms.NumericUpDown numericUpDownSkočiNaRešitev;
    }
}

