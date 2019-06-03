namespace Formel_Ön_Muhasebe_Programı
{
    partial class Form_Cari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Cari));
            this.StilYonetici = new DevComponents.DotNetBar.StyleManager(this.components);
            this.dGView_Cari = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.CariID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IlgiliKisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Il = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alacak = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Verecek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VergiNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_carisil = new DevComponents.DotNetBar.ButtonX();
            this.gP_Cariarama = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmBox_İl = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_ilara = new DevComponents.DotNetBar.LabelX();
            this.txt_cariadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_cariadiara = new DevComponents.DotNetBar.LabelX();
            this.txt_carikod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_cariKodara = new DevComponents.DotNetBar.LabelX();
            this.btn_Goster = new DevComponents.DotNetBar.ButtonX();
            this.btn_cariguncelle = new DevComponents.DotNetBar.ButtonX();
            this.btn_cariekle = new DevComponents.DotNetBar.ButtonX();
            this.btn_excel = new DevComponents.DotNetBar.ButtonX();
            this.btn_raporla = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Cari)).BeginInit();
            this.gP_Cariarama.SuspendLayout();
            this.SuspendLayout();
            // 
            // StilYonetici
            // 
            this.StilYonetici.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // dGView_Cari
            // 
            this.dGView_Cari.AllowUserToAddRows = false;
            this.dGView_Cari.AllowUserToDeleteRows = false;
            this.dGView_Cari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Cari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CariID,
            this.CariAdi,
            this.IlgiliKisi,
            this.TCno,
            this.Il,
            this.Iskonto,
            this.Alacak,
            this.Verecek,
            this.Risk,
            this.Email,
            this.Fax,
            this.Telefon,
            this.VergiDa,
            this.VergiNo,
            this.ParaB,
            this.Adres});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView_Cari.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGView_Cari.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dGView_Cari.Location = new System.Drawing.Point(12, 97);
            this.dGView_Cari.Name = "dGView_Cari";
            this.dGView_Cari.ReadOnly = true;
            this.dGView_Cari.Size = new System.Drawing.Size(962, 446);
            this.dGView_Cari.TabIndex = 4;
            this.dGView_Cari.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Cari_CellDoubleClick);
            this.dGView_Cari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Cari_CellClick);
            // 
            // CariID
            // 
            this.CariID.DataPropertyName = "CariID";
            this.CariID.HeaderText = "Cari Kod";
            this.CariID.Name = "CariID";
            this.CariID.ReadOnly = true;
            this.CariID.Visible = false;
            // 
            // CariAdi
            // 
            this.CariAdi.DataPropertyName = "CariAdi";
            this.CariAdi.HeaderText = "Cari Adı";
            this.CariAdi.Name = "CariAdi";
            this.CariAdi.ReadOnly = true;
            this.CariAdi.Width = 115;
            // 
            // IlgiliKisi
            // 
            this.IlgiliKisi.DataPropertyName = "IlgiliKisi";
            this.IlgiliKisi.HeaderText = "İlgili Kişi";
            this.IlgiliKisi.Name = "IlgiliKisi";
            this.IlgiliKisi.ReadOnly = true;
            this.IlgiliKisi.Width = 115;
            // 
            // TCno
            // 
            this.TCno.DataPropertyName = "TCno";
            this.TCno.HeaderText = "TC Kimlik";
            this.TCno.Name = "TCno";
            this.TCno.ReadOnly = true;
            this.TCno.Width = 116;
            // 
            // Il
            // 
            this.Il.DataPropertyName = "Il";
            this.Il.HeaderText = "İl";
            this.Il.Name = "Il";
            this.Il.ReadOnly = true;
            this.Il.Width = 115;
            // 
            // Iskonto
            // 
            this.Iskonto.DataPropertyName = "Iskonto";
            this.Iskonto.HeaderText = "İskonto";
            this.Iskonto.Name = "Iskonto";
            this.Iskonto.ReadOnly = true;
            this.Iskonto.Width = 115;
            // 
            // Alacak
            // 
            this.Alacak.DataPropertyName = "Tahsilat";
            this.Alacak.HeaderText = "Tahsilat";
            this.Alacak.Name = "Alacak";
            this.Alacak.ReadOnly = true;
            this.Alacak.Width = 115;
            // 
            // Verecek
            // 
            this.Verecek.DataPropertyName = "Borc";
            this.Verecek.HeaderText = "Borç";
            this.Verecek.Name = "Verecek";
            this.Verecek.ReadOnly = true;
            this.Verecek.Width = 115;
            // 
            // Risk
            // 
            this.Risk.DataPropertyName = "Risk";
            this.Risk.HeaderText = "Risk";
            this.Risk.Name = "Risk";
            this.Risk.ReadOnly = true;
            this.Risk.Width = 115;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // Fax
            // 
            this.Fax.DataPropertyName = "Fax";
            this.Fax.HeaderText = "Fax";
            this.Fax.Name = "Fax";
            this.Fax.ReadOnly = true;
            this.Fax.Visible = false;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Visible = false;
            // 
            // VergiDa
            // 
            this.VergiDa.DataPropertyName = "VergiDa";
            this.VergiDa.HeaderText = "Vergi Dairesi";
            this.VergiDa.Name = "VergiDa";
            this.VergiDa.ReadOnly = true;
            this.VergiDa.Width = 116;
            // 
            // VergiNo
            // 
            this.VergiNo.DataPropertyName = "VergiNo";
            this.VergiNo.HeaderText = "Vergi No";
            this.VergiNo.Name = "VergiNo";
            this.VergiNo.ReadOnly = true;
            this.VergiNo.Width = 115;
            // 
            // ParaB
            // 
            this.ParaB.DataPropertyName = "ParaB";
            this.ParaB.HeaderText = "Para Birimi";
            this.ParaB.Name = "ParaB";
            this.ParaB.ReadOnly = true;
            this.ParaB.Width = 115;
            // 
            // Adres
            // 
            this.Adres.DataPropertyName = "Adres";
            this.Adres.HeaderText = "Adres";
            this.Adres.Name = "Adres";
            this.Adres.ReadOnly = true;
            this.Adres.Visible = false;
            // 
            // btn_carisil
            // 
            this.btn_carisil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_carisil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_carisil.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Sil;
            this.btn_carisil.Location = new System.Drawing.Point(980, 136);
            this.btn_carisil.Name = "btn_carisil";
            this.btn_carisil.Size = new System.Drawing.Size(102, 49);
            this.btn_carisil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_carisil.TabIndex = 2;
            this.btn_carisil.Text = "Sil";
            this.btn_carisil.Click += new System.EventHandler(this.btn_carisil_Click);
            // 
            // gP_Cariarama
            // 
            this.gP_Cariarama.CanvasColor = System.Drawing.SystemColors.Control;
            this.gP_Cariarama.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gP_Cariarama.Controls.Add(this.cmBox_İl);
            this.gP_Cariarama.Controls.Add(this.lbl_ilara);
            this.gP_Cariarama.Controls.Add(this.txt_cariadi);
            this.gP_Cariarama.Controls.Add(this.lbl_cariadiara);
            this.gP_Cariarama.Controls.Add(this.txt_carikod);
            this.gP_Cariarama.Controls.Add(this.lbl_cariKodara);
            this.gP_Cariarama.Location = new System.Drawing.Point(12, 12);
            this.gP_Cariarama.Name = "gP_Cariarama";
            this.gP_Cariarama.Size = new System.Drawing.Size(962, 79);
            // 
            // 
            // 
            this.gP_Cariarama.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gP_Cariarama.Style.BackColorGradientAngle = 90;
            this.gP_Cariarama.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gP_Cariarama.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Cariarama.Style.BorderBottomWidth = 1;
            this.gP_Cariarama.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gP_Cariarama.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Cariarama.Style.BorderLeftWidth = 1;
            this.gP_Cariarama.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Cariarama.Style.BorderRightWidth = 1;
            this.gP_Cariarama.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Cariarama.Style.BorderTopWidth = 1;
            this.gP_Cariarama.Style.Class = "";
            this.gP_Cariarama.Style.CornerDiameter = 4;
            this.gP_Cariarama.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gP_Cariarama.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gP_Cariarama.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gP_Cariarama.StyleMouseDown.Class = "";
            this.gP_Cariarama.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gP_Cariarama.StyleMouseOver.Class = "";
            this.gP_Cariarama.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gP_Cariarama.TabIndex = 3;
            this.gP_Cariarama.Text = "Gelişmiş Arama Paneli";
            // 
            // cmBox_İl
            // 
            this.cmBox_İl.DisplayMember = "Text";
            this.cmBox_İl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_İl.FormattingEnabled = true;
            this.cmBox_İl.ItemHeight = 14;
            this.cmBox_İl.Location = new System.Drawing.Point(743, 16);
            this.cmBox_İl.Name = "cmBox_İl";
            this.cmBox_İl.Size = new System.Drawing.Size(172, 20);
            this.cmBox_İl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_İl.TabIndex = 2;
            this.cmBox_İl.SelectedIndexChanged += new System.EventHandler(this.cmBox_İl_SelectedIndexChanged);
            // 
            // lbl_ilara
            // 
            this.lbl_ilara.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_ilara.BackgroundStyle.Class = "";
            this.lbl_ilara.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ilara.Location = new System.Drawing.Point(704, 13);
            this.lbl_ilara.Name = "lbl_ilara";
            this.lbl_ilara.Size = new System.Drawing.Size(75, 23);
            this.lbl_ilara.TabIndex = 2;
            this.lbl_ilara.Text = "İl: ";
            // 
            // txt_cariadi
            // 
            // 
            // 
            // 
            this.txt_cariadi.Border.Class = "TextBoxBorder";
            this.txt_cariadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_cariadi.Location = new System.Drawing.Point(425, 16);
            this.txt_cariadi.Name = "txt_cariadi";
            this.txt_cariadi.Size = new System.Drawing.Size(140, 20);
            this.txt_cariadi.TabIndex = 1;
            this.txt_cariadi.TextChanged += new System.EventHandler(this.txt_cariadi_TextChanged);
            // 
            // lbl_cariadiara
            // 
            this.lbl_cariadiara.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_cariadiara.BackgroundStyle.Class = "";
            this.lbl_cariadiara.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_cariadiara.Location = new System.Drawing.Point(365, 13);
            this.lbl_cariadiara.Name = "lbl_cariadiara";
            this.lbl_cariadiara.Size = new System.Drawing.Size(75, 23);
            this.lbl_cariadiara.TabIndex = 0;
            this.lbl_cariadiara.Text = "Cari Adı: ";
            // 
            // txt_carikod
            // 
            // 
            // 
            // 
            this.txt_carikod.Border.Class = "TextBoxBorder";
            this.txt_carikod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_carikod.Location = new System.Drawing.Point(78, 16);
            this.txt_carikod.Name = "txt_carikod";
            this.txt_carikod.Size = new System.Drawing.Size(140, 20);
            this.txt_carikod.TabIndex = 0;
            this.txt_carikod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_carikod_KeyPress);
            this.txt_carikod.TextChanged += new System.EventHandler(this.txt_carikod_TextChanged);
            // 
            // lbl_cariKodara
            // 
            this.lbl_cariKodara.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_cariKodara.BackgroundStyle.Class = "";
            this.lbl_cariKodara.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_cariKodara.Location = new System.Drawing.Point(14, 13);
            this.lbl_cariKodara.Name = "lbl_cariKodara";
            this.lbl_cariKodara.Size = new System.Drawing.Size(75, 23);
            this.lbl_cariKodara.TabIndex = 0;
            this.lbl_cariKodara.Text = "Cari Kod: ";
            // 
            // btn_Goster
            // 
            this.btn_Goster.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Goster.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Goster.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.göster;
            this.btn_Goster.Location = new System.Drawing.Point(980, 191);
            this.btn_Goster.Name = "btn_Goster";
            this.btn_Goster.Size = new System.Drawing.Size(102, 49);
            this.btn_Goster.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Goster.TabIndex = 5;
            this.btn_Goster.Text = "Göster";
            this.btn_Goster.Click += new System.EventHandler(this.btn_Goster_Click);
            // 
            // btn_cariguncelle
            // 
            this.btn_cariguncelle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cariguncelle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cariguncelle.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.değiştir;
            this.btn_cariguncelle.Location = new System.Drawing.Point(980, 81);
            this.btn_cariguncelle.Name = "btn_cariguncelle";
            this.btn_cariguncelle.Size = new System.Drawing.Size(102, 49);
            this.btn_cariguncelle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cariguncelle.TabIndex = 1;
            this.btn_cariguncelle.Text = "Değiştir";
            this.btn_cariguncelle.Click += new System.EventHandler(this.buttonX2_Click);
            // 
            // btn_cariekle
            // 
            this.btn_cariekle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_cariekle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_cariekle.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.ekle;
            this.btn_cariekle.Location = new System.Drawing.Point(980, 26);
            this.btn_cariekle.Name = "btn_cariekle";
            this.btn_cariekle.Size = new System.Drawing.Size(102, 49);
            this.btn_cariekle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_cariekle.TabIndex = 0;
            this.btn_cariekle.Text = "Ekle";
            this.btn_cariekle.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_excel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_excel.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Exel;
            this.btn_excel.Location = new System.Drawing.Point(980, 246);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(102, 49);
            this.btn_excel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_excel.TabIndex = 6;
            this.btn_excel.Text = "Excel";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_raporla
            // 
            this.btn_raporla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_raporla.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_raporla.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.raporlama;
            this.btn_raporla.Location = new System.Drawing.Point(980, 301);
            this.btn_raporla.Name = "btn_raporla";
            this.btn_raporla.Size = new System.Drawing.Size(100, 49);
            this.btn_raporla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_raporla.TabIndex = 7;
            this.btn_raporla.Text = "Raporla";
            this.btn_raporla.Click += new System.EventHandler(this.btn_raporla_Click);
            // 
            // Form_Cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 555);
            this.Controls.Add(this.btn_raporla);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_Goster);
            this.Controls.Add(this.gP_Cariarama);
            this.Controls.Add(this.btn_carisil);
            this.Controls.Add(this.btn_cariguncelle);
            this.Controls.Add(this.btn_cariekle);
            this.Controls.Add(this.dGView_Cari);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Cari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari";
            this.Load += new System.EventHandler(this.Form_Cari_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Cari_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Cari)).EndInit();
            this.gP_Cariarama.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager StilYonetici;
        private DevComponents.DotNetBar.ButtonX btn_cariguncelle;
        private DevComponents.DotNetBar.ButtonX btn_carisil;
        private DevComponents.DotNetBar.Controls.GroupPanel gP_Cariarama;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_cariadi;
        private DevComponents.DotNetBar.LabelX lbl_cariadiara;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_carikod;
        private DevComponents.DotNetBar.LabelX lbl_cariKodara;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_İl;
        private DevComponents.DotNetBar.LabelX lbl_ilara;
        public DevComponents.DotNetBar.Controls.DataGridViewX dGView_Cari;
        private DevComponents.DotNetBar.ButtonX btn_Goster;
        private DevComponents.DotNetBar.ButtonX btn_excel;
        public DevComponents.DotNetBar.ButtonX btn_cariekle;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn IlgiliKisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TCno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Il;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alacak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Verecek;
        private System.Windows.Forms.DataGridViewTextBoxColumn Risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiDa;
        private System.Windows.Forms.DataGridViewTextBoxColumn VergiNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private DevComponents.DotNetBar.ButtonX btn_raporla;
    }
}