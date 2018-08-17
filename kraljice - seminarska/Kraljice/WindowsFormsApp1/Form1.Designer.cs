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
            this.časovnikVseRešitve = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelŠtevecRešitev = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gumbNaslednjaRešitevPoKorakih = new System.Windows.Forms.Button();
            this.labelŠteviloKorakov = new System.Windows.Forms.Label();
            this.časovnikKorakiRešitve = new System.Windows.Forms.Timer(this.components);
            this.gumbUstaviZacni = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelŠtevecKorakov = new System.Windows.Forms.Label();
            this.gumbSkočiNaRešitev = new System.Windows.Forms.Button();
            this.numericUpDownSkočiNaRešitev = new System.Windows.Forms.NumericUpDown();
            this.labelOpisKoraka = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkočiNaRešitev)).BeginInit();
            this.SuspendLayout();
            // 
            // časovnikVseRešitve
            // 
            this.časovnikVseRešitve.Interval = 2000;
            this.časovnikVseRešitve.Tick += new System.EventHandler(this.časovnikVseRešitve_Tick);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1437, 134);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // labelŠtevecRešitev
            // 
            this.labelŠtevecRešitev.AutoSize = true;
            this.labelŠtevecRešitev.Location = new System.Drawing.Point(1301, 508);
            this.labelŠtevecRešitev.Name = "labelŠtevecRešitev";
            this.labelŠtevecRešitev.Size = new System.Drawing.Size(12, 17);
            this.labelŠtevecRešitev.TabIndex = 5;
            this.labelŠtevecRešitev.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1301, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hitrost (desetinke): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(451, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(267, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "PROBLEM OSMIH KRALJIC";
            // 
            // gumbNaslednjaRešitevPoKorakih
            // 
            this.gumbNaslednjaRešitevPoKorakih.Location = new System.Drawing.Point(1305, 618);
            this.gumbNaslednjaRešitevPoKorakih.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gumbNaslednjaRešitevPoKorakih.Name = "gumbNaslednjaRešitevPoKorakih";
            this.gumbNaslednjaRešitevPoKorakih.Size = new System.Drawing.Size(243, 44);
            this.gumbNaslednjaRešitevPoKorakih.TabIndex = 10;
            this.gumbNaslednjaRešitevPoKorakih.Text = "Rešitev po korakih";
            this.gumbNaslednjaRešitevPoKorakih.UseVisualStyleBackColor = true;
            this.gumbNaslednjaRešitevPoKorakih.Click += new System.EventHandler(this.gumbNaslednjaRešitevPoKorakih_Click);
            // 
            // labelŠteviloKorakov
            // 
            this.labelŠteviloKorakov.AutoSize = true;
            this.labelŠteviloKorakov.Location = new System.Drawing.Point(1301, 708);
            this.labelŠteviloKorakov.Name = "labelŠteviloKorakov";
            this.labelŠteviloKorakov.Size = new System.Drawing.Size(12, 17);
            this.labelŠteviloKorakov.TabIndex = 12;
            this.labelŠteviloKorakov.Text = "/";
            // 
            // časovnikKorakiRešitve
            // 
            this.časovnikKorakiRešitve.Interval = 1000;
            this.časovnikKorakiRešitve.Tick += new System.EventHandler(this.časovnikKorakiRešitve_Tick);
            // 
            // gumbUstaviZacni
            // 
            this.gumbUstaviZacni.Location = new System.Drawing.Point(1303, 399);
            this.gumbUstaviZacni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gumbUstaviZacni.Name = "gumbUstaviZacni";
            this.gumbUstaviZacni.Size = new System.Drawing.Size(139, 41);
            this.gumbUstaviZacni.TabIndex = 13;
            this.gumbUstaviZacni.Text = "Ustavi";
            this.gumbUstaviZacni.UseVisualStyleBackColor = true;
            this.gumbUstaviZacni.Click += new System.EventHandler(this.gumbUstavi_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // labelŠtevecKorakov
            // 
            this.labelŠtevecKorakov.AutoSize = true;
            this.labelŠtevecKorakov.Location = new System.Drawing.Point(1301, 754);
            this.labelŠtevecKorakov.Name = "labelŠtevecKorakov";
            this.labelŠtevecKorakov.Size = new System.Drawing.Size(12, 17);
            this.labelŠtevecKorakov.TabIndex = 16;
            this.labelŠtevecKorakov.Text = "/";
            // 
            // gumbSkočiNaRešitev
            // 
            this.gumbSkočiNaRešitev.Location = new System.Drawing.Point(1303, 321);
            this.gumbSkočiNaRešitev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gumbSkočiNaRešitev.Name = "gumbSkočiNaRešitev";
            this.gumbSkočiNaRešitev.Size = new System.Drawing.Size(139, 41);
            this.gumbSkočiNaRešitev.TabIndex = 17;
            this.gumbSkočiNaRešitev.Text = "Skoči na rešitev";
            this.gumbSkočiNaRešitev.UseVisualStyleBackColor = true;
            this.gumbSkočiNaRešitev.Click += new System.EventHandler(this.gumbSkočiNaRešitev_Click);
            // 
            // numericUpDownSkočiNaRešitev
            // 
            this.numericUpDownSkočiNaRešitev.Location = new System.Drawing.Point(1467, 331);
            this.numericUpDownSkočiNaRešitev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            // labelOpisKoraka
            // 
            this.labelOpisKoraka.AutoSize = true;
            this.labelOpisKoraka.Location = new System.Drawing.Point(1301, 800);
            this.labelOpisKoraka.Name = "labelOpisKoraka";
            this.labelOpisKoraka.Size = new System.Drawing.Size(12, 17);
            this.labelOpisKoraka.TabIndex = 19;
            this.labelOpisKoraka.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1811, 1047);
            this.Controls.Add(this.labelOpisKoraka);
            this.Controls.Add(this.numericUpDownSkočiNaRešitev);
            this.Controls.Add(this.gumbSkočiNaRešitev);
            this.Controls.Add(this.labelŠtevecKorakov);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gumbUstaviZacni);
            this.Controls.Add(this.labelŠteviloKorakov);
            this.Controls.Add(this.gumbNaslednjaRešitevPoKorakih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelŠtevecRešitev);
            this.Controls.Add(this.numericUpDown1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Problem 8-ih kraljic";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSkočiNaRešitev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer časovnikVseRešitve;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelŠtevecRešitev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button gumbNaslednjaRešitevPoKorakih;
        private System.Windows.Forms.Label labelŠteviloKorakov;
        private System.Windows.Forms.Timer časovnikKorakiRešitve;
        private System.Windows.Forms.Button gumbUstaviZacni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelŠtevecKorakov;
        private System.Windows.Forms.Button gumbSkočiNaRešitev;
        private System.Windows.Forms.NumericUpDown numericUpDownSkočiNaRešitev;
        private System.Windows.Forms.Label labelOpisKoraka;
    }
}

