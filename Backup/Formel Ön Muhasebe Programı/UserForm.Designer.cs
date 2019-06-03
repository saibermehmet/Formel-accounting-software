namespace Formel_Ön_Muhasebe_Programı
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.StilYonetici = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lbl_Sifre = new DevComponents.DotNetBar.LabelX();
            this.lbl_KulAdi = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txt_KulAdi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Sifre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SifreT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Restart = new DevComponents.DotNetBar.ButtonX();
            this.btn_SifreDegistir = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // StilYonetici
            // 
            this.StilYonetici.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // lbl_Sifre
            // 
            // 
            // 
            // 
            this.lbl_Sifre.BackgroundStyle.Class = "";
            this.lbl_Sifre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Sifre.Location = new System.Drawing.Point(45, 53);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(75, 23);
            this.lbl_Sifre.TabIndex = 6;
            this.lbl_Sifre.Text = "Şifre   * : ";
            // 
            // lbl_KulAdi
            // 
            // 
            // 
            // 
            this.lbl_KulAdi.BackgroundStyle.Class = "";
            this.lbl_KulAdi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_KulAdi.Location = new System.Drawing.Point(12, 12);
            this.lbl_KulAdi.Name = "lbl_KulAdi";
            this.lbl_KulAdi.Size = new System.Drawing.Size(86, 23);
            this.lbl_KulAdi.TabIndex = 5;
            this.lbl_KulAdi.Text = "Kullanıcı Adı  * : ";
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 95);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(80, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Şifre Tekrar   * : ";
            // 
            // txt_KulAdi
            // 
            // 
            // 
            // 
            this.txt_KulAdi.Border.Class = "TextBoxBorder";
            this.txt_KulAdi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_KulAdi.Location = new System.Drawing.Point(104, 15);
            this.txt_KulAdi.Name = "txt_KulAdi";
            this.txt_KulAdi.Size = new System.Drawing.Size(192, 20);
            this.txt_KulAdi.TabIndex = 0;
            this.txt_KulAdi.TextChanged += new System.EventHandler(this.txt_KulAdi_TextChanged);
            // 
            // txt_Sifre
            // 
            // 
            // 
            // 
            this.txt_Sifre.Border.Class = "TextBoxBorder";
            this.txt_Sifre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Sifre.Location = new System.Drawing.Point(104, 56);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(192, 20);
            this.txt_Sifre.TabIndex = 0;
            this.txt_Sifre.UseSystemPasswordChar = true;
            this.txt_Sifre.TextChanged += new System.EventHandler(this.txt_Sifre_TextChanged);
            // 
            // txt_SifreT
            // 
            // 
            // 
            // 
            this.txt_SifreT.Border.Class = "TextBoxBorder";
            this.txt_SifreT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SifreT.Location = new System.Drawing.Point(104, 98);
            this.txt_SifreT.Name = "txt_SifreT";
            this.txt_SifreT.Size = new System.Drawing.Size(192, 20);
            this.txt_SifreT.TabIndex = 0;
            this.txt_SifreT.UseSystemPasswordChar = true;
            this.txt_SifreT.TextChanged += new System.EventHandler(this.txt_SifreT_TextChanged);
            // 
            // btn_Restart
            // 
            this.btn_Restart.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Restart.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Restart.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__10_;
            this.btn_Restart.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Restart.Location = new System.Drawing.Point(104, 124);
            this.btn_Restart.Name = "btn_Restart";
            this.btn_Restart.Size = new System.Drawing.Size(88, 62);
            this.btn_Restart.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Restart.TabIndex = 4;
            this.btn_Restart.Text = "Yeniden Başlat";
            this.btn_Restart.Click += new System.EventHandler(this.btn_Restart_Click);
            // 
            // btn_SifreDegistir
            // 
            this.btn_SifreDegistir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_SifreDegistir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_SifreDegistir.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__8_;
            this.btn_SifreDegistir.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_SifreDegistir.Location = new System.Drawing.Point(208, 124);
            this.btn_SifreDegistir.Name = "btn_SifreDegistir";
            this.btn_SifreDegistir.Size = new System.Drawing.Size(88, 62);
            this.btn_SifreDegistir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_SifreDegistir.TabIndex = 3;
            this.btn_SifreDegistir.Text = "Şifre Değiştir";
            this.btn_SifreDegistir.Click += new System.EventHandler(this.btn_SifreDegistir_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 191);
            this.Controls.Add(this.txt_SifreT);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KulAdi);
            this.Controls.Add(this.btn_Restart);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_KulAdi);
            this.Controls.Add(this.btn_SifreDegistir);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı İşlemleri";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager StilYonetici;
        private DevComponents.DotNetBar.LabelX lbl_Sifre;
        private DevComponents.DotNetBar.LabelX lbl_KulAdi;
        private DevComponents.DotNetBar.ButtonX btn_SifreDegistir;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btn_Restart;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_KulAdi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Sifre;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SifreT;
    }
}