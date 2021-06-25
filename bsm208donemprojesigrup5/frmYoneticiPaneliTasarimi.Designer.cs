
namespace bsm208donemprojesigrup5
{
    partial class frmYoneticiPaneli
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
            this.gbKullaniciRezervasyonlari = new System.Windows.Forms.GroupBox();
            this.dgvYoneticiRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.gbBildirimEkle = new System.Windows.Forms.GroupBox();
            this.tbSecilenUcusID = new System.Windows.Forms.TextBox();
            this.btnBildirimiGonder = new System.Windows.Forms.Button();
            this.tbBildirimİcerigi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvYoneticiUcuslar = new System.Windows.Forms.DataGridView();
            this.gbKullaniciRezervasyonlari.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYoneticiRezervasyonlar)).BeginInit();
            this.gbBildirimEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYoneticiUcuslar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKullaniciRezervasyonlari
            // 
            this.gbKullaniciRezervasyonlari.Controls.Add(this.dgvYoneticiRezervasyonlar);
            this.gbKullaniciRezervasyonlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbKullaniciRezervasyonlari.Location = new System.Drawing.Point(37, 274);
            this.gbKullaniciRezervasyonlari.Name = "gbKullaniciRezervasyonlari";
            this.gbKullaniciRezervasyonlari.Size = new System.Drawing.Size(721, 155);
            this.gbKullaniciRezervasyonlari.TabIndex = 0;
            this.gbKullaniciRezervasyonlari.TabStop = false;
            this.gbKullaniciRezervasyonlari.Text = "Kullanıcı Rezarvasyonları";
            // 
            // dgvYoneticiRezervasyonlar
            // 
            this.dgvYoneticiRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYoneticiRezervasyonlar.Location = new System.Drawing.Point(6, 19);
            this.dgvYoneticiRezervasyonlar.Name = "dgvYoneticiRezervasyonlar";
            this.dgvYoneticiRezervasyonlar.Size = new System.Drawing.Size(709, 120);
            this.dgvYoneticiRezervasyonlar.TabIndex = 3;
            // 
            // gbBildirimEkle
            // 
            this.gbBildirimEkle.Controls.Add(this.tbSecilenUcusID);
            this.gbBildirimEkle.Controls.Add(this.btnBildirimiGonder);
            this.gbBildirimEkle.Controls.Add(this.tbBildirimİcerigi);
            this.gbBildirimEkle.Controls.Add(this.label2);
            this.gbBildirimEkle.Controls.Add(this.label1);
            this.gbBildirimEkle.Controls.Add(this.dgvYoneticiUcuslar);
            this.gbBildirimEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbBildirimEkle.Location = new System.Drawing.Point(43, 25);
            this.gbBildirimEkle.Name = "gbBildirimEkle";
            this.gbBildirimEkle.Size = new System.Drawing.Size(709, 243);
            this.gbBildirimEkle.TabIndex = 1;
            this.gbBildirimEkle.TabStop = false;
            this.gbBildirimEkle.Text = "Bildirim Ekle";
            // 
            // tbSecilenUcusID
            // 
            this.tbSecilenUcusID.Enabled = false;
            this.tbSecilenUcusID.Location = new System.Drawing.Point(584, 25);
            this.tbSecilenUcusID.Name = "tbSecilenUcusID";
            this.tbSecilenUcusID.Size = new System.Drawing.Size(119, 26);
            this.tbSecilenUcusID.TabIndex = 5;
            // 
            // btnBildirimiGonder
            // 
            this.btnBildirimiGonder.Location = new System.Drawing.Point(462, 143);
            this.btnBildirimiGonder.Name = "btnBildirimiGonder";
            this.btnBildirimiGonder.Size = new System.Drawing.Size(241, 66);
            this.btnBildirimiGonder.TabIndex = 2;
            this.btnBildirimiGonder.Text = "Bildirimi Gönder";
            this.btnBildirimiGonder.UseVisualStyleBackColor = true;
            // 
            // tbBildirimİcerigi
            // 
            this.tbBildirimİcerigi.Location = new System.Drawing.Point(462, 81);
            this.tbBildirimİcerigi.Multiline = true;
            this.tbBildirimİcerigi.Name = "tbBildirimİcerigi";
            this.tbBildirimİcerigi.Size = new System.Drawing.Size(241, 56);
            this.tbBildirimİcerigi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bildirim İçeriği";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(458, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seçilen Uçuş ID";
            // 
            // dgvYoneticiUcuslar
            // 
            this.dgvYoneticiUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYoneticiUcuslar.Location = new System.Drawing.Point(6, 29);
            this.dgvYoneticiUcuslar.Name = "dgvYoneticiUcuslar";
            this.dgvYoneticiUcuslar.Size = new System.Drawing.Size(423, 195);
            this.dgvYoneticiUcuslar.TabIndex = 0;
            // 
            // frmYoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbBildirimEkle);
            this.Controls.Add(this.gbKullaniciRezervasyonlari);
            this.Name = "frmYoneticiPaneli";
            this.Text = "Yönetici Paneli ";
            this.gbKullaniciRezervasyonlari.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYoneticiRezervasyonlar)).EndInit();
            this.gbBildirimEkle.ResumeLayout(false);
            this.gbBildirimEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYoneticiUcuslar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKullaniciRezervasyonlari;
        private System.Windows.Forms.DataGridView dgvYoneticiRezervasyonlar;
        private System.Windows.Forms.GroupBox gbBildirimEkle;
        private System.Windows.Forms.Button btnBildirimiGonder;
        private System.Windows.Forms.TextBox tbBildirimİcerigi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvYoneticiUcuslar;
        private System.Windows.Forms.TextBox tbSecilenUcusID;
    }
}