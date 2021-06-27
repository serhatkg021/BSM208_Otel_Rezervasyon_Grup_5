
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
            this.dtpSeferTarihi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKullaniciRezervasyonlar = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcusListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUcakBiletiAra
            // 
            this.btnUcakBiletiAra.Location = new System.Drawing.Point(692, 177);
            this.btnUcakBiletiAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnUcakBiletiAra.Name = "btnUcakBiletiAra";
            this.btnUcakBiletiAra.Size = new System.Drawing.Size(359, 116);
            this.btnUcakBiletiAra.TabIndex = 4;
            this.btnUcakBiletiAra.Text = "Uçak Bileti Ara";
            this.btnUcakBiletiAra.UseVisualStyleBackColor = true;
            this.btnUcakBiletiAra.Click += new System.EventHandler(this.btnUcakBiletiAra_Click);
            // 
            // cbHavaYollari
            // 
            this.cbHavaYollari.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHavaYollari.FormattingEnabled = true;
            this.cbHavaYollari.Items.AddRange(new object[] {
            "THY",
            "PEGASUS",
            "ONUR AİR"});
            this.cbHavaYollari.Location = new System.Drawing.Point(61, 267);
            this.cbHavaYollari.Margin = new System.Windows.Forms.Padding(4);
            this.cbHavaYollari.Name = "cbHavaYollari";
            this.cbHavaYollari.Size = new System.Drawing.Size(265, 24);
            this.cbHavaYollari.TabIndex = 2;
            // 
            // cbNereye
            // 
            this.cbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNereye.FormattingEnabled = true;
            this.cbNereye.Items.AddRange(new object[] {
            "Ankara Esenboğa Havalimanı",
            "İstanbul Havalimanı"});
            this.cbNereye.Location = new System.Drawing.Point(357, 112);
            this.cbNereye.Margin = new System.Windows.Forms.Padding(4);
            this.cbNereye.Name = "cbNereye";
            this.cbNereye.Size = new System.Drawing.Size(265, 24);
            this.cbNereye.TabIndex = 1;
            // 
            // cbNereden
            // 
            this.cbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNereden.FormattingEnabled = true;
            this.cbNereden.Items.AddRange(new object[] {
            "İstanbul Havalimanı",
            "Ankara Esenboğa Havalimanı"});
            this.cbNereden.Location = new System.Drawing.Point(61, 112);
            this.cbNereden.Margin = new System.Windows.Forms.Padding(4);
            this.cbNereden.Name = "cbNereden";
            this.cbNereden.Size = new System.Drawing.Size(265, 24);
            this.cbNereden.TabIndex = 0;
            // 
            // dgvUcusListe
            // 
            this.dgvUcusListe.AllowUserToAddRows = false;
            this.dgvUcusListe.AllowUserToDeleteRows = false;
            this.dgvUcusListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcusListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcusListe.Location = new System.Drawing.Point(61, 354);
            this.dgvUcusListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUcusListe.Name = "dgvUcusListe";
            this.dgvUcusListe.ReadOnly = true;
            this.dgvUcusListe.RowHeadersWidth = 51;
            this.dgvUcusListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUcusListe.Size = new System.Drawing.Size(957, 185);
            this.dgvUcusListe.TabIndex = 5;
            this.dgvUcusListe.DoubleClick += new System.EventHandler(this.dgvUcusListe_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 218);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hava Yolları";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(352, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nereye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(56, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nereden";
            // 
            // dtpSeferTarihi
            // 
            this.dtpSeferTarihi.CustomFormat = "dd/MM/yyyy HH:mm ";
            this.dtpSeferTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSeferTarihi.Location = new System.Drawing.Point(357, 268);
            this.dtpSeferTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSeferTarihi.Name = "dtpSeferTarihi";
            this.dtpSeferTarihi.ShowUpDown = true;
            this.dtpSeferTarihi.Size = new System.Drawing.Size(265, 22);
            this.dtpSeferTarihi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(352, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 29);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sefer Tarihi";
            // 
            // btnKullaniciRezervasyonlar
            // 
            this.btnKullaniciRezervasyonlar.Location = new System.Drawing.Point(899, 43);
            this.btnKullaniciRezervasyonlar.Margin = new System.Windows.Forms.Padding(4);
            this.btnKullaniciRezervasyonlar.Name = "btnKullaniciRezervasyonlar";
            this.btnKullaniciRezervasyonlar.Size = new System.Drawing.Size(152, 95);
            this.btnKullaniciRezervasyonlar.TabIndex = 7;
            this.btnKullaniciRezervasyonlar.Text = "Rezervasyonlarım";
            this.btnKullaniciRezervasyonlar.UseVisualStyleBackColor = true;
            this.btnKullaniciRezervasyonlar.Click += new System.EventHandler(this.btnKullaniciRezervasyonlar_Click);
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(692, 43);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(199, 95);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // frmRezervasyonEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.btnKullaniciRezervasyonlar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpSeferTarihi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUcusListe);
            this.Controls.Add(this.cbNereden);
            this.Controls.Add(this.cbNereye);
            this.Controls.Add(this.cbHavaYollari);
            this.Controls.Add(this.btnUcakBiletiAra);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRezervasyonEkrani";
            this.Text = "Rezarvasyon Ekranı";
            this.Load += new System.EventHandler(this.frmRezervasyonEkrani_Load);
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
        private System.Windows.Forms.DateTimePicker dtpSeferTarihi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKullaniciRezervasyonlar;
        private System.Windows.Forms.Button btnGirisYap;
    }
}