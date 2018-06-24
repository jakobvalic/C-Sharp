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
            this.gumbOdstrani = new System.Windows.Forms.Button();
            this.časovnikCelaRešitev = new System.Windows.Forms.Timer(this.components);
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxUstavitev = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxRaziščiRešitev = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.časovnikKorakiRešitve = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(1206, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gumbOdstrani
            // 
            this.gumbOdstrani.Location = new System.Drawing.Point(1195, 236);
            this.gumbOdstrani.Name = "gumbOdstrani";
            this.gumbOdstrani.Size = new System.Drawing.Size(139, 41);
            this.gumbOdstrani.TabIndex = 2;
            this.gumbOdstrani.Text = "Odmakni kraljice";
            this.gumbOdstrani.UseVisualStyleBackColor = true;
            this.gumbOdstrani.Click += new System.EventHandler(this.gumbOdstrani_Click);
            // 
            // časovnikCelaRešitev
            // 
            this.časovnikCelaRešitev.Enabled = true;
            this.časovnikCelaRešitev.Interval = 2000;
            this.časovnikCelaRešitev.Tick += new System.EventHandler(this.časovnik_Tick);
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
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1129, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(906, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hitrost predvajanja (v desetinkah sekunde):";
            // 
            // checkBoxUstavitev
            // 
            this.checkBoxUstavitev.AutoSize = true;
            this.checkBoxUstavitev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxUstavitev.Location = new System.Drawing.Point(1195, 193);
            this.checkBoxUstavitev.Name = "checkBoxUstavitev";
            this.checkBoxUstavitev.Size = new System.Drawing.Size(88, 29);
            this.checkBoxUstavitev.TabIndex = 8;
            this.checkBoxUstavitev.Text = "Ustavi";
            this.checkBoxUstavitev.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1195, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Razišči rešitev";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBoxRaziščiRešitev
            // 
            this.checkBoxRaziščiRešitev.AutoSize = true;
            this.checkBoxRaziščiRešitev.Checked = true;
            this.checkBoxRaziščiRešitev.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRaziščiRešitev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxRaziščiRešitev.Location = new System.Drawing.Point(1195, 472);
            this.checkBoxRaziščiRešitev.Name = "checkBoxRaziščiRešitev";
            this.checkBoxRaziščiRešitev.Size = new System.Drawing.Size(158, 29);
            this.checkBoxRaziščiRešitev.TabIndex = 11;
            this.checkBoxRaziščiRešitev.Text = "Razišči rešitev";
            this.checkBoxRaziščiRešitev.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(909, 535);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Izpis posamezne rešitve";
            // 
            // časovnikKorakiRešitve
            // 
            this.časovnikKorakiRešitve.Interval = 1000;
            this.časovnikKorakiRešitve.Tick += new System.EventHandler(this.časovnikKorakiRešitve_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 635);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxRaziščiRešitev);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxUstavitev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.gumbOdstrani);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Problem 8-ih kraljic";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gumbOdstrani;
        private System.Windows.Forms.Timer časovnikCelaRešitev;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxUstavitev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxRaziščiRešitev;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer časovnikKorakiRešitve;
    }
}

