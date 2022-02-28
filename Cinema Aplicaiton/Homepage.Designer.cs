
namespace Cinema_Aplicaiton
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.KullanıcıAdı = new System.Windows.Forms.Label();
            this.KullanıcıSifre = new System.Windows.Forms.TextBox();
            this.KullanıcıGiris = new System.Windows.Forms.TextBox();
            this.GirisYap = new System.Windows.Forms.Button();
            this.Sifre = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // KullanıcıAdı
            // 
            this.KullanıcıAdı.AutoSize = true;
            this.KullanıcıAdı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.KullanıcıAdı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KullanıcıAdı.Location = new System.Drawing.Point(765, 547);
            this.KullanıcıAdı.Name = "KullanıcıAdı";
            this.KullanıcıAdı.Size = new System.Drawing.Size(95, 22);
            this.KullanıcıAdı.TabIndex = 0;
            this.KullanıcıAdı.Text = "Kullanıcı Adı";
            this.KullanıcıAdı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KullanıcıSifre
            // 
            this.KullanıcıSifre.Location = new System.Drawing.Point(887, 601);
            this.KullanıcıSifre.Name = "KullanıcıSifre";
            this.KullanıcıSifre.PasswordChar = '*';
            this.KullanıcıSifre.Size = new System.Drawing.Size(223, 26);
            this.KullanıcıSifre.TabIndex = 2;
            this.KullanıcıSifre.Text = "******";
            this.KullanıcıSifre.ReadOnlyChanged += new System.EventHandler(this.KullanıcıSifre_TextChanged);
            this.KullanıcıSifre.TextChanged += new System.EventHandler(this.KullanıcıSifre_TextChanged);
            // 
            // KullanıcıGiris
            // 
            this.KullanıcıGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KullanıcıGiris.Location = new System.Drawing.Point(887, 543);
            this.KullanıcıGiris.Multiline = true;
            this.KullanıcıGiris.Name = "KullanıcıGiris";
            this.KullanıcıGiris.Size = new System.Drawing.Size(223, 26);
            this.KullanıcıGiris.TabIndex = 3;
            this.KullanıcıGiris.Text = "Kullanıcı Adı Giriniz.";
            this.KullanıcıGiris.ReadOnlyChanged += new System.EventHandler(this.KullanıcıGiris_TextChanged);
            this.KullanıcıGiris.TextChanged += new System.EventHandler(this.KullanıcıGiris_TextChanged);
            // 
            // GirisYap
            // 
            this.GirisYap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.GirisYap.Location = new System.Drawing.Point(887, 669);
            this.GirisYap.Name = "GirisYap";
            this.GirisYap.Size = new System.Drawing.Size(136, 31);
            this.GirisYap.TabIndex = 4;
            this.GirisYap.Text = "Giriş Yap";
            this.GirisYap.UseVisualStyleBackColor = true;
            this.GirisYap.Click += new System.EventHandler(this.GirisYap_Click);
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Sifre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sifre.Location = new System.Drawing.Point(816, 605);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(44, 22);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Şifre";
            this.Sifre.Click += new System.EventHandler(this.label2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ımageList2
            // 
            this.ımageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cinema_Aplicaiton.Properties.Resources.f4bed2d5_c9f5_4327_a64e_24030061cbbc;
            this.pictureBox1.Location = new System.Drawing.Point(765, 224);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1000);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(378, 267);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AcceptButton = this.GirisYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(100, 100);
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1524, 1050);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GirisYap);
            this.Controls.Add(this.KullanıcıGiris);
            this.Controls.Add(this.KullanıcıSifre);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.KullanıcıAdı);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Homepage";
            this.Text = "ASKOSOKELLA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.PaddingChanged += new System.EventHandler(this.Homepage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label KullanıcıAdı;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox KullanıcıSifre;
        private System.Windows.Forms.Button GirisYap;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox KullanıcıGiris;
    }
}