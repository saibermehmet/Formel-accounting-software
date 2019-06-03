namespace Formel_Ön_Muhasebe_Programı
{
    partial class RehberForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RehberForm));
            this.StilYonetici = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lbl_AdSoyad = new System.Windows.Forms.Label();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.lbl_Fax = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_web = new System.Windows.Forms.Label();
            this.lbl_adres = new System.Windows.Forms.Label();
            this.txt_email = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Tel = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.txt_Ad = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_web = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_adres = new System.Windows.Forms.RichTextBox();
            this.gP_kisibilgileri = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_fax = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dGView_Kisiler = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.KisiID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KisiAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Web = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Kaydet = new DevComponents.DotNetBar.ButtonX();
            this.btn_Guncelle = new DevComponents.DotNetBar.ButtonX();
            this.btn_Sil = new DevComponents.DotNetBar.ButtonX();
            this.btn_vazgec = new DevComponents.DotNetBar.ButtonX();
            this.btn_excel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Cikis = new DevComponents.DotNetBar.ButtonX();
            this.btn_raporla = new DevComponents.DotNetBar.ButtonX();
            this.gP_kisibilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Kisiler)).BeginInit();
            this.SuspendLayout();
            // 
            // StilYonetici
            // 
            this.StilYonetici.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // lbl_AdSoyad
            // 
            this.lbl_AdSoyad.AutoSize = true;
            this.lbl_AdSoyad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_AdSoyad.Location = new System.Drawing.Point(13, 16);
            this.lbl_AdSoyad.Name = "lbl_AdSoyad";
            this.lbl_AdSoyad.Size = new System.Drawing.Size(76, 13);
            this.lbl_AdSoyad.TabIndex = 0;
            this.lbl_AdSoyad.Text = "Adı Soyadı   * :";
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tel.Location = new System.Drawing.Point(13, 45);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(62, 13);
            this.lbl_Tel.TabIndex = 0;
            this.lbl_Tel.Text = "Telefon   * :";
            // 
            // lbl_Fax
            // 
            this.lbl_Fax.AutoSize = true;
            this.lbl_Fax.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Fax.Location = new System.Drawing.Point(13, 74);
            this.lbl_Fax.Name = "lbl_Fax";
            this.lbl_Fax.Size = new System.Drawing.Size(30, 13);
            this.lbl_Fax.TabIndex = 0;
            this.lbl_Fax.Text = "Fax: ";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Email.Location = new System.Drawing.Point(398, 16);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(51, 13);
            this.lbl_Email.TabIndex = 0;
            this.lbl_Email.Text = "Email  * : ";
            // 
            // lbl_web
            // 
            this.lbl_web.AutoSize = true;
            this.lbl_web.BackColor = System.Drawing.Color.Transparent;
            this.lbl_web.Location = new System.Drawing.Point(398, 45);
            this.lbl_web.Name = "lbl_web";
            this.lbl_web.Size = new System.Drawing.Size(36, 13);
            this.lbl_web.TabIndex = 0;
            this.lbl_web.Text = "Web: ";
            // 
            // lbl_adres
            // 
            this.lbl_adres.AutoSize = true;
            this.lbl_adres.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adres.Location = new System.Drawing.Point(398, 74);
            this.lbl_adres.Name = "lbl_adres";
            this.lbl_adres.Size = new System.Drawing.Size(40, 13);
            this.lbl_adres.TabIndex = 0;
            this.lbl_adres.Text = "Adres: ";
            // 
            // txt_email
            // 
            // 
            // 
            // 
            this.txt_email.Border.Class = "TextBoxBorder";
            this.txt_email.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_email.Location = new System.Drawing.Point(459, 14);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(185, 20);
            this.txt_email.TabIndex = 1;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_Tel
            // 
            // 
            // 
            // 
            this.txt_Tel.BackgroundStyle.Class = "TextBoxBorder";
            this.txt_Tel.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Tel.ButtonClear.Visible = true;
            this.txt_Tel.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_Tel.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_Tel.Location = new System.Drawing.Point(95, 45);
            this.txt_Tel.Mask = "(999) 000-0000";
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(185, 20);
            this.txt_Tel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txt_Tel.TabIndex = 2;
            this.txt_Tel.Text = "";
            this.txt_Tel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Tel.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // txt_Ad
            // 
            // 
            // 
            // 
            this.txt_Ad.Border.Class = "TextBoxBorder";
            this.txt_Ad.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Ad.Location = new System.Drawing.Point(95, 14);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(185, 20);
            this.txt_Ad.TabIndex = 1;
            this.txt_Ad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Ad_KeyPress);
            this.txt_Ad.TextChanged += new System.EventHandler(this.txt_Ad_TextChanged);
            // 
            // txt_web
            // 
            // 
            // 
            // 
            this.txt_web.Border.Class = "TextBoxBorder";
            this.txt_web.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_web.Location = new System.Drawing.Point(459, 43);
            this.txt_web.Name = "txt_web";
            this.txt_web.Size = new System.Drawing.Size(185, 20);
            this.txt_web.TabIndex = 1;
            this.txt_web.TextChanged += new System.EventHandler(this.txt_web_TextChanged);
            // 
            // txt_adres
            // 
            this.txt_adres.Location = new System.Drawing.Point(459, 69);
            this.txt_adres.Name = "txt_adres";
            this.txt_adres.Size = new System.Drawing.Size(185, 61);
            this.txt_adres.TabIndex = 3;
            this.txt_adres.Text = "";
            this.txt_adres.TextChanged += new System.EventHandler(this.txt_adres_TextChanged);
            // 
            // gP_kisibilgileri
            // 
            this.gP_kisibilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gP_kisibilgileri.CanvasColor = System.Drawing.SystemColors.Control;
            this.gP_kisibilgileri.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gP_kisibilgileri.Controls.Add(this.txt_fax);
            this.gP_kisibilgileri.Controls.Add(this.lbl_AdSoyad);
            this.gP_kisibilgileri.Controls.Add(this.txt_adres);
            this.gP_kisibilgileri.Controls.Add(this.lbl_Tel);
            this.gP_kisibilgileri.Controls.Add(this.txt_web);
            this.gP_kisibilgileri.Controls.Add(this.txt_Tel);
            this.gP_kisibilgileri.Controls.Add(this.txt_email);
            this.gP_kisibilgileri.Controls.Add(this.lbl_Fax);
            this.gP_kisibilgileri.Controls.Add(this.lbl_adres);
            this.gP_kisibilgileri.Controls.Add(this.lbl_web);
            this.gP_kisibilgileri.Controls.Add(this.txt_Ad);
            this.gP_kisibilgileri.Controls.Add(this.lbl_Email);
            this.gP_kisibilgileri.Location = new System.Drawing.Point(12, 12);
            this.gP_kisibilgileri.Name = "gP_kisibilgileri";
            this.gP_kisibilgileri.Size = new System.Drawing.Size(673, 167);
            // 
            // 
            // 
            this.gP_kisibilgileri.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gP_kisibilgileri.Style.BackColorGradientAngle = 90;
            this.gP_kisibilgileri.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gP_kisibilgileri.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_kisibilgileri.Style.BorderBottomWidth = 1;
            this.gP_kisibilgileri.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gP_kisibilgileri.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_kisibilgileri.Style.BorderLeftWidth = 1;
            this.gP_kisibilgileri.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_kisibilgileri.Style.BorderRightWidth = 1;
            this.gP_kisibilgileri.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_kisibilgileri.Style.BorderTopWidth = 1;
            this.gP_kisibilgileri.Style.Class = "";
            this.gP_kisibilgileri.Style.CornerDiameter = 4;
            this.gP_kisibilgileri.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gP_kisibilgileri.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gP_kisibilgileri.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gP_kisibilgileri.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gP_kisibilgileri.StyleMouseDown.Class = "";
            this.gP_kisibilgileri.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gP_kisibilgileri.StyleMouseOver.Class = "";
            this.gP_kisibilgileri.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gP_kisibilgileri.TabIndex = 4;
            this.gP_kisibilgileri.Text = "Kişi Bilgileri";
            // 
            // txt_fax
            // 
            // 
            // 
            // 
            this.txt_fax.Border.Class = "TextBoxBorder";
            this.txt_fax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_fax.Location = new System.Drawing.Point(95, 72);
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(185, 20);
            this.txt_fax.TabIndex = 9;
            this.txt_fax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_fax_KeyPress);
            this.txt_fax.TextChanged += new System.EventHandler(this.txt_fax_TextChanged);
            // 
            // dGView_Kisiler
            // 
            this.dGView_Kisiler.AllowUserToAddRows = false;
            this.dGView_Kisiler.AllowUserToDeleteRows = false;
            this.dGView_Kisiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Kisiler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KisiID,
            this.KisiAdi,
            this.Telefon,
            this.Fax,
            this.Email,
            this.Web,
            this.Adres});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView_Kisiler.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGView_Kisiler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dGView_Kisiler.Location = new System.Drawing.Point(12, 197);
            this.dGView_Kisiler.Name = "dGView_Kisiler";
            this.dGView_Kisiler.ReadOnly = true;
            this.dGView_Kisiler.Size = new System.Drawing.Size(673, 324);
            this.dGView_Kisiler.TabIndex = 5;
            this.dGView_Kisiler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Kisiler_CellDoubleClick);
            this.dGView_Kisiler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Kisiler_CellClick);
            // 
            // KisiID
            // 
            this.KisiID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KisiID.DataPropertyName = "KisiID";
            this.KisiID.HeaderText = "KisiID";
            this.KisiID.Name = "KisiID";
            this.KisiID.ReadOnly = true;
            this.KisiID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KisiID.Visible = false;
            // 
            // KisiAdi
            // 
            this.KisiAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KisiAdi.DataPropertyName = "KisiAdi";
            this.KisiAdi.HeaderText = "Adı Soyadı";
            this.KisiAdi.Name = "KisiAdi";
            this.KisiAdi.ReadOnly = true;
            this.KisiAdi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Telefon
            // 
            this.Telefon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Fax
            // 
            this.Fax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            this.Fax.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Web
            // 
            this.Web.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Web.DataPropertyName = "Web";
            this.Web.HeaderText = "Web";
            this.Web.Name = "Web";
            this.Web.ReadOnly = true;
            this.Web.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Kaydet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Kaydet.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.kaydet;
            this.btn_Kaydet.Location = new System.Drawing.Point(700, 25);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(102, 49);
            this.btn_Kaydet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Kaydet.TabIndex = 4;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Guncelle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Guncelle.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Güncelle;
            this.btn_Guncelle.Location = new System.Drawing.Point(700, 82);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(102, 49);
            this.btn_Guncelle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Guncelle.TabIndex = 0;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sil.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Sil;
            this.btn_Sil.Location = new System.Drawing.Point(700, 139);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(102, 49);
            this.btn_Sil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sil.TabIndex = 0;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_vazgec
            // 
            this.btn_vazgec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_vazgec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_vazgec.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.vazgeç;
            this.btn_vazgec.Location = new System.Drawing.Point(700, 253);
            this.btn_vazgec.Name = "btn_vazgec";
            this.btn_vazgec.Size = new System.Drawing.Size(102, 49);
            this.btn_vazgec.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_vazgec.TabIndex = 0;
            this.btn_vazgec.Text = "Vazgeç";
            this.btn_vazgec.Click += new System.EventHandler(this.btn_vazgec_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_excel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_excel.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Exel;
            this.btn_excel.Location = new System.Drawing.Point(700, 196);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(102, 49);
            this.btn_excel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_excel.TabIndex = 6;
            this.btn_excel.Text = "Excel";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_Cikis
            // 
            this.btn_Cikis.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Cikis.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Cikis.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Kapat;
            this.btn_Cikis.Location = new System.Drawing.Point(700, 367);
            this.btn_Cikis.Name = "btn_Cikis";
            this.btn_Cikis.Size = new System.Drawing.Size(102, 49);
            this.btn_Cikis.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Cikis.TabIndex = 8;
            this.btn_Cikis.Text = "Çıkış";
            this.btn_Cikis.Click += new System.EventHandler(this.btn_Cikis_Click);
            // 
            // btn_raporla
            // 
            this.btn_raporla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_raporla.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_raporla.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.raporlama;
            this.btn_raporla.Location = new System.Drawing.Point(700, 310);
            this.btn_raporla.Name = "btn_raporla";
            this.btn_raporla.Size = new System.Drawing.Size(102, 49);
            this.btn_raporla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_raporla.TabIndex = 9;
            this.btn_raporla.Text = "Raporla";
            this.btn_raporla.Click += new System.EventHandler(this.btn_raporla_Click);
            // 
            // RehberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 533);
            this.Controls.Add(this.btn_raporla);
            this.Controls.Add(this.btn_Cikis);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_vazgec);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.dGView_Kisiler);
            this.Controls.Add(this.gP_kisibilgileri);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RehberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.RehberForm_Load);
            this.gP_kisibilgileri.ResumeLayout(false);
            this.gP_kisibilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Kisiler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager StilYonetici;
        private System.Windows.Forms.Label lbl_AdSoyad;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.Label lbl_Fax;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_web;
        private System.Windows.Forms.Label lbl_adres;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_email;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_Tel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Ad;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_web;
        private System.Windows.Forms.RichTextBox txt_adres;
        private DevComponents.DotNetBar.Controls.GroupPanel gP_kisibilgileri;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGView_Kisiler;
        private DevComponents.DotNetBar.ButtonX btn_Kaydet;
        private DevComponents.DotNetBar.ButtonX btn_Guncelle;
        private DevComponents.DotNetBar.ButtonX btn_Sil;
        private DevComponents.DotNetBar.ButtonX btn_vazgec;
        public DevComponents.DotNetBar.Controls.TextBoxX txt_fax;
        private DevComponents.DotNetBar.ButtonX btn_excel;
        private DevComponents.DotNetBar.ButtonX btn_Cikis;
        private System.Windows.Forms.DataGridViewTextBoxColumn KisiID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KisiAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Web;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private DevComponents.DotNetBar.ButtonX btn_raporla;
    }
}