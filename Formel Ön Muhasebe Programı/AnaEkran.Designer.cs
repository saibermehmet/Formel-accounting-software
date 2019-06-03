namespace Formel_Ön_Muhasebe_Programı
{
    partial class Form_Ana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ana));
            this.stylM_Ana = new DevComponents.DotNetBar.StyleManager(this.components);
            this.bubbleBarTab3 = new DevComponents.DotNetBar.BubbleBarTab(this.components);
            this.Pnl_Gecisler = new DevComponents.DotNetBar.PanelEx();
            this.st_Strip = new System.Windows.Forms.StatusStrip();
            this.lbl_Saat = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmr_saat = new System.Windows.Forms.Timer(this.components);
            this.btn_Cikis = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Araclar = new DevComponents.DotNetBar.ButtonX();
            this.altntn_rehber = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Kulislem = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hesapM = new DevComponents.DotNetBar.ButtonItem();
            this.btn_hakkinda = new DevComponents.DotNetBar.ButtonX();
            this.btn_tanitim = new DevComponents.DotNetBar.ButtonItem();
            this.btn_Fatura = new DevComponents.DotNetBar.ButtonX();
            this.btn_Kasa = new DevComponents.DotNetBar.ButtonX();
            this.btn_Stok = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cari = new DevComponents.DotNetBar.ButtonX();
            this.Pnl_Gecisler.SuspendLayout();
            this.st_Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stylM_Ana
            // 
            this.stylM_Ana.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // bubbleBarTab3
            // 
            this.bubbleBarTab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.bubbleBarTab3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(168)))), ((int)(((byte)(228)))));
            this.bubbleBarTab3.DarkBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bubbleBarTab3.LightBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bubbleBarTab3.Name = "bubbleBarTab3";
            this.bubbleBarTab3.PredefinedColor = DevComponents.DotNetBar.eTabItemColor.Blue;
            this.bubbleBarTab3.Text = "My Tab";
            this.bubbleBarTab3.TextColor = System.Drawing.Color.Black;
            // 
            // Pnl_Gecisler
            // 
            this.Pnl_Gecisler.CanvasColor = System.Drawing.SystemColors.Control;
            this.Pnl_Gecisler.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.Pnl_Gecisler.Controls.Add(this.btn_Araclar);
            this.Pnl_Gecisler.Controls.Add(this.btn_Cikis);
            this.Pnl_Gecisler.Controls.Add(this.btn_hakkinda);
            this.Pnl_Gecisler.Controls.Add(this.btn_Fatura);
            this.Pnl_Gecisler.Controls.Add(this.btn_Kasa);
            this.Pnl_Gecisler.Controls.Add(this.btn_Stok);
            this.Pnl_Gecisler.Controls.Add(this.btn_Cari);
            this.Pnl_Gecisler.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Gecisler.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Gecisler.Name = "Pnl_Gecisler";
            this.Pnl_Gecisler.Size = new System.Drawing.Size(1215, 87);
            this.Pnl_Gecisler.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.Pnl_Gecisler.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Pnl_Gecisler.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.Pnl_Gecisler.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.Pnl_Gecisler.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Pnl_Gecisler.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.Pnl_Gecisler.Style.GradientAngle = 90;
            this.Pnl_Gecisler.TabIndex = 0;
            // 
            // st_Strip
            // 
            this.st_Strip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.st_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Saat});
            this.st_Strip.Location = new System.Drawing.Point(0, 581);
            this.st_Strip.Name = "st_Strip";
            this.st_Strip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.st_Strip.Size = new System.Drawing.Size(1215, 22);
            this.st_Strip.TabIndex = 1;
            this.st_Strip.Text = "st_Strip";
            // 
            // lbl_Saat
            // 
            this.lbl_Saat.Name = "lbl_Saat";
            this.lbl_Saat.Size = new System.Drawing.Size(29, 17);
            this.lbl_Saat.Text = "Saat";
            // 
            // tmr_saat
            // 
            this.tmr_saat.Tick += new System.EventHandler(this.tmr_saat_Tick);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cikis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cikis.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__4_;
            this.btn_Cikis.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Cikis.Location = new System.Drawing.Point(785, 12);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(99, 64);
            this.btn_Cikis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cikis.TabIndex = 6;
            this.btn_Cikis.Text = "&Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.muhasebe1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1215, 494);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Araclar
            // 
            this.btn_Araclar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Araclar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Araclar.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon2;
            this.btn_Araclar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Araclar.Location = new System.Drawing.Point(533, 12);
            this.btn_Araclar.Name = "btn_Araclar";
            this.btn_Araclar.Size = new System.Drawing.Size(99, 64);
            this.btn_Araclar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Araclar.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.altntn_rehber,
            this.btn_Kulislem,
            this.btn_hesapM});
            this.btn_Araclar.TabIndex = 4;
            this.btn_Araclar.Text = "Araçlar";
            // 
            // altntn_rehber
            // 
            this.altntn_rehber.GlobalItem = false;
            this.altntn_rehber.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__2_;
            this.altntn_rehber.Name = "altntn_rehber";
            this.altntn_rehber.Text = "&Rehber";
            this.altntn_rehber.Click += new System.EventHandler(this.altntn_rehber_Click);
            // 
            // btn_Kulislem
            // 
            this.btn_Kulislem.GlobalItem = false;
            this.btn_Kulislem.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__1_1;
            this.btn_Kulislem.Name = "btn_Kulislem";
            this.btn_Kulislem.Text = "&Kullanıcı İşlemleri";
            this.btn_Kulislem.Click += new System.EventHandler(this.btn_Kulislem_Click);
            // 
            // btn_hesapM
            // 
            this.btn_hesapM.GlobalItem = false;
            this.btn_hesapM.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Calculator;
            this.btn_hesapM.Name = "btn_hesapM";
            this.btn_hesapM.Text = "Hesap Makinesi";
            this.btn_hesapM.Click += new System.EventHandler(this.btn_hesapM_Click);
            // 
            // btn_hakkinda
            // 
            this.btn_hakkinda.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_hakkinda.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_hakkinda.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__3_;
            this.btn_hakkinda.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_hakkinda.Location = new System.Drawing.Point(659, 12);
            this.btn_hakkinda.Name = "btn_hakkinda";
            this.btn_hakkinda.Size = new System.Drawing.Size(99, 64);
            this.btn_hakkinda.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_hakkinda.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btn_tanitim});
            this.btn_hakkinda.TabIndex = 5;
            this.btn_hakkinda.Text = "&Hakkında";
            this.btn_hakkinda.Click += new System.EventHandler(this.btn_hakkinda_Click);
            // 
            // btn_tanitim
            // 
            this.btn_tanitim.GlobalItem = false;
            this.btn_tanitim.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.tanıtım;
            this.btn_tanitim.Name = "btn_tanitim";
            this.btn_tanitim.Text = "Tanıtım";
            this.btn_tanitim.Click += new System.EventHandler(this.btn_tanitim_Click);
            // 
            // btn_Fatura
            // 
            this.btn_Fatura.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Fatura.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Fatura.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__1_;
            this.btn_Fatura.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Fatura.Location = new System.Drawing.Point(397, 12);
            this.btn_Fatura.Name = "btn_Fatura";
            this.btn_Fatura.Size = new System.Drawing.Size(99, 64);
            this.btn_Fatura.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Fatura.TabIndex = 3;
            this.btn_Fatura.Text = "&Fatura";
            this.btn_Fatura.Click += new System.EventHandler(this.btn_Fatura_Click);
            // 
            // btn_Kasa
            // 
            this.btn_Kasa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Kasa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Kasa.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon;
            this.btn_Kasa.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Kasa.Location = new System.Drawing.Point(262, 12);
            this.btn_Kasa.Name = "btn_Kasa";
            this.btn_Kasa.Size = new System.Drawing.Size(99, 64);
            this.btn_Kasa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Kasa.TabIndex = 2;
            this.btn_Kasa.Text = "&Kasa";
            this.btn_Kasa.Click += new System.EventHandler(this.btn_Kasa_Click);
            // 
            // btn_Stok
            // 
            this.btn_Stok.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Stok.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Stok.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources._1399429928_103469;
            this.btn_Stok.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Stok.Location = new System.Drawing.Point(137, 12);
            this.btn_Stok.Name = "btn_Stok";
            this.btn_Stok.Size = new System.Drawing.Size(99, 64);
            this.btn_Stok.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Stok.TabIndex = 1;
            this.btn_Stok.Text = "&Stok";
            this.btn_Stok.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btn_Cari
            // 
            this.btn_Cari.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cari.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cari.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicondfgdf;
            this.btn_Cari.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.btn_Cari.Location = new System.Drawing.Point(12, 12);
            this.btn_Cari.Name = "btn_Cari";
            this.btn_Cari.Size = new System.Drawing.Size(99, 64);
            this.btn_Cari.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cari.TabIndex = 0;
            this.btn_Cari.Text = "&Cari Hesaplar";
            this.btn_Cari.Click += new System.EventHandler(this.btn_Cari_Click);
            // 
            // Form_Ana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cikis;
            this.ClientSize = new System.Drawing.Size(1215, 603);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.st_Strip);
            this.Controls.Add(this.Pnl_Gecisler);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(941, 607);
            this.Name = "Form_Ana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formel Ön Muhasebe";
            this.Load += new System.EventHandler(this.Form_Ana_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Ana_FormClosing);
            this.Pnl_Gecisler.ResumeLayout(false);
            this.st_Strip.ResumeLayout(false);
            this.st_Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager stylM_Ana;
        private DevComponents.DotNetBar.BubbleBarTab bubbleBarTab3;
        private DevComponents.DotNetBar.PanelEx Pnl_Gecisler;
        private DevComponents.DotNetBar.ButtonX btn_Cari;
        private DevComponents.DotNetBar.ButtonX btn_Cikis;
        private DevComponents.DotNetBar.ButtonX btn_hakkinda;
        private DevComponents.DotNetBar.ButtonX btn_Fatura;
        private DevComponents.DotNetBar.ButtonX btn_Kasa;
        private DevComponents.DotNetBar.ButtonX btn_Stok;
        private DevComponents.DotNetBar.ButtonX btn_Araclar;
        private DevComponents.DotNetBar.ButtonItem altntn_rehber;
        private System.Windows.Forms.StatusStrip st_Strip;
        private DevComponents.DotNetBar.ButtonItem btn_Kulislem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevComponents.DotNetBar.ButtonItem btn_hesapM;
        private System.Windows.Forms.Timer tmr_saat;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Saat;
        private DevComponents.DotNetBar.ButtonItem btn_tanitim;

    }
}