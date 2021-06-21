
namespace bsm208donemprojesigrup5
{
    partial class frmRezervasyonEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRezervasyonEkrani));
            this.btnUcakBiletiAra = new System.Windows.Forms.Button();
            this.cbHavaYollari = new System.Windows.Forms.ComboBox();
            this.cbNereye = new System.Windows.Forms.ComboBox();
            this.cbNereden = new System.Windows.Forms.ComboBox();
            this.dgvUcusListe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtpGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcusListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUcakBiletiAra
            // 
            this.btnUcakBiletiAra.Location = new System.Drawing.Point(609, 144);
            this.btnUcakBiletiAra.Name = "btnUcakBiletiAra";
            this.btnUcakBiletiAra.Size = new System.Drawing.Size(155, 94);
            this.btnUcakBiletiAra.TabIndex = 5;
            this.btnUcakBiletiAra.Text = "Uçak Bileti Ara";
            this.btnUcakBiletiAra.UseVisualStyleBackColor = true;
            // 
            // cbHavaYollari
            // 
            this.cbHavaYollari.FormattingEnabled = true;
            this.cbHavaYollari.Location = new System.Drawing.Point(46, 29);
            this.cbHavaYollari.Name = "cbHavaYollari";
            this.cbHavaYollari.Size = new System.Drawing.Size(200, 21);
            this.cbHavaYollari.TabIndex = 0;
            // 
            // cbNereye
            // 
            this.cbNereye.FormattingEnabled = true;
            this.cbNereye.Location = new System.Drawing.Point(268, 120);
            this.cbNereye.Name = "cbNereye";
            this.cbNereye.Size = new System.Drawing.Size(200, 21);
            this.cbNereye.TabIndex = 2;
            // 
            // cbNereden
            // 
            this.cbNereden.FormattingEnabled = true;
            this.cbNereden.Location = new System.Drawing.Point(46, 120);
            this.cbNereden.Name = "cbNereden";
            this.cbNereden.Size = new System.Drawing.Size(200, 21);
            this.cbNereden.TabIndex = 1;
            // 
            // dgvUcusListe
            // 
            this.dgvUcusListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcusListe.Location = new System.Drawing.Point(46, 288);
            this.dgvUcusListe.Name = "dgvUcusListe";
            this.dgvUcusListe.Size = new System.Drawing.Size(718, 150);
            this.dgvUcusListe.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hava Yolları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(264, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nereden";
            // 
            // dtpDonusTarihi
            // 
            this.dtpDonusTarihi.Location = new System.Drawing.Point(268, 218);
            this.dtpDonusTarihi.Name = "dtpDonusTarihi";
            this.dtpDonusTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpDonusTarihi.TabIndex = 4;
            // 
            // dtpGidisTarihi
            // 
            this.dtpGidisTarihi.Location = new System.Drawing.Point(46, 218);
            this.dtpGidisTarihi.Name = "dtpGidisTarihi";
            this.dtpGidisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpGidisTarihi.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(264, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dönüş Tarihi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(42, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 24);
            this.label6.TabIndex = 17;
            this.label6.Text = "Gidiş Tarihi";
            // 
            // frmRezervasyonEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpGidisTarihi);
            this.Controls.Add(this.dtpDonusTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUcusListe);
            this.Controls.Add(this.cbNereden);
            this.Controls.Add(this.cbNereye);
            this.Controls.Add(this.cbHavaYollari);
            this.Controls.Add(this.btnUcakBiletiAra);
            this.Name = "frmRezervasyonEkrani";
            this.Text = "Rezarvasyon Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcusListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUcakBiletiAra;
        private System.Windows.Forms.ComboBox cbHavaYollari;
        private System.Windows.Forms.ComboBox cbNereye;
        private System.Windows.Forms.ComboBox cbNereden;
        private System.Windows.Forms.DataGridView dgvUcusListe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDonusTarihi;
        private System.Windows.Forms.DateTimePicker dtpGidisTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}