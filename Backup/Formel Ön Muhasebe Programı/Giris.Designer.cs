namespace Formel_Ön_Muhasebe_Programı
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.stylM_Giris = new DevComponents.DotNetBar.StyleManager(this.components);
            this.rlbl_resim = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.lbl_Kuladi = new DevComponents.DotNetBar.LabelX();
            this.lbl_sifre = new DevComponents.DotNetBar.LabelX();
            this.txt_KAdi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Sifre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_vazgeç = new DevComponents.DotNetBar.ButtonX();
            this.Form_Giris = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // stylM_Giris
            // 
            this.stylM_Giris.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // rlbl_resim
            // 
            // 
            // 
            // 
            this.rlbl_resim.BackgroundStyle.BackColorGradientType = DevComponents.DotNetBar.eGradientType.Radial;
            this.rlbl_resim.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.rlbl_resim.BackgroundStyle.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.rlbl_resim.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.rlbl_resim.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Dash;
            this.rlbl_resim.BackgroundStyle.Class = "";
            this.rlbl_resim.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.rlbl_resim.Dock = System.Windows.Forms.DockStyle.Left;
            this.rlbl_resim.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rlbl_resim.ForeColor = System.Drawing.Color.Red;
            this.rlbl_resim.Location = new System.Drawing.Point(0, 0);
            this.rlbl_resim.Name = "rlbl_resim";
            this.rlbl_resim.Size = new System.Drawing.Size(218, 144);
            this.rlbl_resim.TabIndex = 6;
            this.rlbl_resim.Text = " Formel Yazılım";
            // 
            // lbl_Kuladi
            // 
            // 
            // 
            // 
            this.lbl_Kuladi.BackgroundStyle.Class = "";
            this.lbl_Kuladi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Kuladi.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Kuladi.Location = new System.Drawing.Point(224, 12);
            this.lbl_Kuladi.Name = "lbl_Kuladi";
            this.lbl_Kuladi.Size = new System.Drawing.Size(83, 23);
            this.lbl_Kuladi.TabIndex = 4;
            this.lbl_Kuladi.Text = "Kullanıcı Adı: ";
            // 
            // lbl_sifre
            // 
            // 
            // 
            // 
            this.lbl_sifre.BackgroundStyle.Class = "";
            this.lbl_sifre.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_sifre.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sifre.Location = new System.Drawing.Point(267, 52);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(83, 23);
            this.lbl_sifre.TabIndex = 5;
            this.lbl_sifre.Text = "Şifre: ";
            // 
            // txt_KAdi
            // 
            // 
            // 
            // 
            this.txt_KAdi.Border.Class = "TextBoxBorder";
            this.txt_KAdi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_KAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_KAdi.Location = new System.Drawing.Point(313, 17);
            this.txt_KAdi.Name = "txt_KAdi";
            this.txt_KAdi.Size = new System.Drawing.Size(196, 21);
            this.txt_KAdi.TabIndex = 0;
            // 
            // txt_Sifre
            // 
            // 
            // 
            // 
            this.txt_Sifre.Border.Class = "TextBoxBorder";
            this.txt_Sifre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.Location = new System.Drawing.Point(313, 55);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(196, 21);
            this.txt_Sifre.TabIndex = 1;
            this.txt_Sifre.UseSystemPasswordChar = true;
            // 
            // btn_vazgeç
            // 
            this.btn_vazgeç.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_vazgeç.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_vazgeç.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_vazgeç.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__4_;
            this.btn_vazgeç.Location = new System.Drawing.Point(418, 92);
            this.btn_vazgeç.Name = "btn_vazgeç";
            this.btn_vazgeç.Size = new System.Drawing.Size(89, 44);
            this.btn_vazgeç.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_vazgeç.TabIndex = 3;
            this.btn_vazgeç.Text = "&Vazgeç";
            this.btn_vazgeç.Click += new System.EventHandler(this.btn_vazgeç_Click);
            // 
            // Form_Giris
            // 
            this.Form_Giris.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.Form_Giris.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.Form_Giris.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__5_;
            this.Form_Giris.Location = new System.Drawing.Point(313, 92);
            this.Form_Giris.Name = "Form_Giris";
            this.Form_Giris.Size = new System.Drawing.Size(89, 44);
            this.Form_Giris.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Form_Giris.TabIndex = 2;
            this.Form_Giris.Text = "&Giriş";
            this.Form_Giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // Giris
            // 
            this.AcceptButton = this.Form_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_vazgeç;
            this.ClientSize = new System.Drawing.Size(519, 144);
            this.Controls.Add(this.btn_vazgeç);
            this.Controls.Add(this.Form_Giris);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_KAdi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_Kuladi);
            this.Controls.Add(this.rlbl_resim);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formel Ön Muhasebe";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager stylM_Giris;
        private DevComponents.DotNetBar.Controls.ReflectionLabel rlbl_resim;
        private DevComponents.DotNetBar.LabelX lbl_Kuladi;
        private DevComponents.DotNetBar.LabelX lbl_sifre;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_KAdi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Sifre;
        private DevComponents.DotNetBar.ButtonX Form_Giris;
        private DevComponents.DotNetBar.ButtonX btn_vazgeç;




    }
}

