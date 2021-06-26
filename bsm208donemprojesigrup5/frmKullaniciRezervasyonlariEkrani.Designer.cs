
namespace bsm208donemprojesigrup5
{
    partial class frmKullaniciRezervasyonlariEkrani
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
            this.gbRezervasyonlar = new System.Windows.Forms.GroupBox();
            this.dgvKullaniciRezervasyonlar = new System.Windows.Forms.DataGridView();
            this.gbRezervasyonlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciRezervasyonlar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbRezervasyonlar
            // 
            this.gbRezervasyonlar.Controls.Add(this.dgvKullaniciRezervasyonlar);
            this.gbRezervasyonlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbRezervasyonlar.Location = new System.Drawing.Point(37, 15);
            this.gbRezervasyonlar.Margin = new System.Windows.Forms.Padding(4);
            this.gbRezervasyonlar.Name = "gbRezervasyonlar";
            this.gbRezervasyonlar.Padding = new System.Windows.Forms.Padding(4);
            this.gbRezervasyonlar.Size = new System.Drawing.Size(1043, 366);
            this.gbRezervasyonlar.TabIndex = 0;
            this.gbRezervasyonlar.TabStop = false;
            this.gbRezervasyonlar.Text = "Rezervasyonlarım";
            // 
            // dgvKullaniciRezervasyonlar
            // 
            this.dgvKullaniciRezervasyonlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKullaniciRezervasyonlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullaniciRezervasyonlar.Location = new System.Drawing.Point(8, 28);
            this.dgvKullaniciRezervasyonlar.Margin = new System.Windows.Forms.Padding(4);
            this.dgvKullaniciRezervasyonlar.Name = "dgvKullaniciRezervasyonlar";
            this.dgvKullaniciRezervasyonlar.RowHeadersWidth = 51;
            this.dgvKullaniciRezervasyonlar.Size = new System.Drawing.Size(1027, 330);
            this.dgvKullaniciRezervasyonlar.TabIndex = 0;
            // 
            // frmKullaniciRezervasyonlariEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 394);
            this.Controls.Add(this.gbRezervasyonlar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKullaniciRezervasyonlariEkrani";
            this.Text = "Kullanıcı Rezervasyonları Ekranı";
            this.Load += new System.EventHandler(this.frmKullaniciRezervasyonlariEkrani_Load);
            this.gbRezervasyonlar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullaniciRezervasyonlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRezervasyonlar;
        private System.Windows.Forms.DataGridView dgvKullaniciRezervasyonlar;
    }
}