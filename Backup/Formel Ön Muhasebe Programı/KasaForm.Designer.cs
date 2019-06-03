namespace Formel_Ön_Muhasebe_Programı
{
    partial class KasaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaForm));
            this.StilYonetici = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lbl_Kasaadi = new DevComponents.DotNetBar.LabelX();
            this.lbl_ParaBirimi = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.lbl_Bakiye = new DevComponents.DotNetBar.LabelX();
            this.txt_KasaAdi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmBox_ParaBirim = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.gP_KASA = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dTP_gTarihi = new System.Windows.Forms.DateTimePicker();
            this.lbl_giristarihi = new DevComponents.DotNetBar.LabelX();
            this.txt_Notlar = new System.Windows.Forms.RichTextBox();
            this.txt_KasaKod = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.lbl_KasaKod = new DevComponents.DotNetBar.LabelX();
            this.txt_Tbakiye = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btn_Kaydet = new DevComponents.DotNetBar.ButtonX();
            this.btn_Degistir = new DevComponents.DotNetBar.ButtonX();
            this.btn_Vazgec = new DevComponents.DotNetBar.ButtonX();
            this.gP_Ara = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lbl_araKasaAdi = new DevComponents.DotNetBar.LabelX();
            this.txt_araKadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmBox_araPbirim = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_araParabirimi = new DevComponents.DotNetBar.LabelX();
            this.dGView_Kasa = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.KasaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KasaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParaBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TBakiye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sil = new DevComponents.DotNetBar.ButtonX();
            this.btn_excel = new DevComponents.DotNetBar.ButtonX();
            this.btn_raporla = new DevComponents.DotNetBar.ButtonX();
            this.gP_KASA.SuspendLayout();
            this.gP_Ara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Kasa)).BeginInit();
            this.SuspendLayout();
            // 
            // StilYonetici
            // 
            this.StilYonetici.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // lbl_Kasaadi
            // 
            this.lbl_Kasaadi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Kasaadi.BackgroundStyle.Class = "";
            this.lbl_Kasaadi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Kasaadi.Location = new System.Drawing.Point(14, 50);
            this.lbl_Kasaadi.Name = "lbl_Kasaadi";
            this.lbl_Kasaadi.Size = new System.Drawing.Size(75, 23);
            this.lbl_Kasaadi.TabIndex = 0;
            this.lbl_Kasaadi.Text = "Kasa Adı  * : ";
            // 
            // lbl_ParaBirimi
            // 
            this.lbl_ParaBirimi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_ParaBirimi.BackgroundStyle.Class = "";
            this.lbl_ParaBirimi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_ParaBirimi.Location = new System.Drawing.Point(14, 93);
            this.lbl_ParaBirimi.Name = "lbl_ParaBirimi";
            this.lbl_ParaBirimi.Size = new System.Drawing.Size(75, 23);
            this.lbl_ParaBirimi.TabIndex = 1;
            this.lbl_ParaBirimi.Text = "Para Birimi  * : ";
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(501, 50);
            this.labelX3.Name = "labelX3";
            this.labelX3.SingleLineColor = System.Drawing.Color.Transparent;
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Notlar: ";
            // 
            // lbl_Bakiye
            // 
            this.lbl_Bakiye.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Bakiye.BackgroundStyle.Class = "";
            this.lbl_Bakiye.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Bakiye.Location = new System.Drawing.Point(501, 10);
            this.lbl_Bakiye.Name = "lbl_Bakiye";
            this.lbl_Bakiye.Size = new System.Drawing.Size(97, 23);
            this.lbl_Bakiye.TabIndex = 1;
            this.lbl_Bakiye.Text = "Toplam Bakiye  * : ";
            // 
            // txt_KasaAdi
            // 
            // 
            // 
            // 
            this.txt_KasaAdi.Border.Class = "TextBoxBorder";
            this.txt_KasaAdi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_KasaAdi.Location = new System.Drawing.Point(118, 53);
            this.txt_KasaAdi.Name = "txt_KasaAdi";
            this.txt_KasaAdi.Size = new System.Drawing.Size(173, 20);
            this.txt_KasaAdi.TabIndex = 2;
            this.txt_KasaAdi.TextChanged += new System.EventHandler(this.txt_KasaAdi_TextChanged);
            // 
            // cmBox_ParaBirim
            // 
            this.cmBox_ParaBirim.DisplayMember = "Text";
            this.cmBox_ParaBirim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_ParaBirim.FormattingEnabled = true;
            this.cmBox_ParaBirim.ItemHeight = 14;
            this.cmBox_ParaBirim.Location = new System.Drawing.Point(117, 96);
            this.cmBox_ParaBirim.Name = "cmBox_ParaBirim";
            this.cmBox_ParaBirim.Size = new System.Drawing.Size(174, 20);
            this.cmBox_ParaBirim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_ParaBirim.TabIndex = 4;
            // 
            // gP_KASA
            // 
            this.gP_KASA.BackColor = System.Drawing.Color.Transparent;
            this.gP_KASA.CanvasColor = System.Drawing.SystemColors.Control;
            this.gP_KASA.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gP_KASA.Controls.Add(this.dTP_gTarihi);
            this.gP_KASA.Controls.Add(this.lbl_giristarihi);
            this.gP_KASA.Controls.Add(this.txt_Notlar);
            this.gP_KASA.Controls.Add(this.lbl_Kasaadi);
            this.gP_KASA.Controls.Add(this.txt_KasaKod);
            this.gP_KASA.Controls.Add(this.lbl_ParaBirimi);
            this.gP_KASA.Controls.Add(this.cmBox_ParaBirim);
            this.gP_KASA.Controls.Add(this.labelX3);
            this.gP_KASA.Controls.Add(this.lbl_KasaKod);
            this.gP_KASA.Controls.Add(this.lbl_Bakiye);
            this.gP_KASA.Controls.Add(this.txt_Tbakiye);
            this.gP_KASA.Controls.Add(this.txt_KasaAdi);
            this.gP_KASA.Location = new System.Drawing.Point(12, 12);
            this.gP_KASA.Name = "gP_KASA";
            this.gP_KASA.Size = new System.Drawing.Size(806, 193);
            // 
            // 
            // 
            this.gP_KASA.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gP_KASA.Style.BackColorGradientAngle = 90;
            this.gP_KASA.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gP_KASA.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_KASA.Style.BorderBottomWidth = 1;
            this.gP_KASA.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gP_KASA.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_KASA.Style.BorderLeftWidth = 1;
            this.gP_KASA.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_KASA.Style.BorderRightWidth = 1;
            this.gP_KASA.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_KASA.Style.BorderTopWidth = 1;
            this.gP_KASA.Style.Class = "";
            this.gP_KASA.Style.CornerDiameter = 4;
            this.gP_KASA.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gP_KASA.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gP_KASA.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gP_KASA.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gP_KASA.StyleMouseDown.Class = "";
            this.gP_KASA.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gP_KASA.StyleMouseOver.Class = "";
            this.gP_KASA.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gP_KASA.TabIndex = 6;
            this.gP_KASA.Text = "KASA";
            // 
            // dTP_gTarihi
            // 
            this.dTP_gTarihi.Location = new System.Drawing.Point(118, 135);
            this.dTP_gTarihi.Name = "dTP_gTarihi";
            this.dTP_gTarihi.Size = new System.Drawing.Size(200, 20);
            this.dTP_gTarihi.TabIndex = 8;
            // 
            // lbl_giristarihi
            // 
            // 
            // 
            // 
            this.lbl_giristarihi.BackgroundStyle.Class = "";
            this.lbl_giristarihi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_giristarihi.Location = new System.Drawing.Point(14, 132);
            this.lbl_giristarihi.Name = "lbl_giristarihi";
            this.lbl_giristarihi.Size = new System.Drawing.Size(86, 23);
            this.lbl_giristarihi.TabIndex = 7;
            this.lbl_giristarihi.Text = "Giriş Tarihi   *  :";
            // 
            // txt_Notlar
            // 
            this.txt_Notlar.Location = new System.Drawing.Point(590, 52);
            this.txt_Notlar.Name = "txt_Notlar";
            this.txt_Notlar.Size = new System.Drawing.Size(187, 103);
            this.txt_Notlar.TabIndex = 6;
            this.txt_Notlar.Text = "";
            this.txt_Notlar.TextChanged += new System.EventHandler(this.txt_Notlar_TextChanged);
            // 
            // txt_KasaKod
            // 
            // 
            // 
            // 
            this.txt_KasaKod.BackgroundStyle.Class = "";
            this.txt_KasaKod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_KasaKod.ButtonClear.Visible = true;
            this.txt_KasaKod.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_KasaKod.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_KasaKod.Location = new System.Drawing.Point(117, 10);
            this.txt_KasaKod.Name = "txt_KasaKod";
            this.txt_KasaKod.ReadOnly = true;
            this.txt_KasaKod.Size = new System.Drawing.Size(174, 20);
            this.txt_KasaKod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txt_KasaKod.TabIndex = 5;
            this.txt_KasaKod.Text = "";
            this.txt_KasaKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_KasaKod.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // lbl_KasaKod
            // 
            this.lbl_KasaKod.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_KasaKod.BackgroundStyle.Class = "";
            this.lbl_KasaKod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_KasaKod.Location = new System.Drawing.Point(14, 7);
            this.lbl_KasaKod.Name = "lbl_KasaKod";
            this.lbl_KasaKod.Size = new System.Drawing.Size(97, 23);
            this.lbl_KasaKod.TabIndex = 1;
            this.lbl_KasaKod.Text = "Kasa Kod  * : ";
            // 
            // txt_Tbakiye
            // 
            // 
            // 
            // 
            this.txt_Tbakiye.Border.Class = "TextBoxBorder";
            this.txt_Tbakiye.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Tbakiye.Location = new System.Drawing.Point(604, 13);
            this.txt_Tbakiye.Name = "txt_Tbakiye";
            this.txt_Tbakiye.Size = new System.Drawing.Size(173, 20);
            this.txt_Tbakiye.TabIndex = 2;
            this.txt_Tbakiye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Tbakiye_KeyPress);
            this.txt_Tbakiye.TextChanged += new System.EventHandler(this.txt_Tbakiye_TextChanged);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Kaydet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Kaydet.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.kaydet;
            this.btn_Kaydet.Location = new System.Drawing.Point(827, 23);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(102, 49);
            this.btn_Kaydet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Kaydet.TabIndex = 7;
            this.btn_Kaydet.Text = "Keydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Degistir
            // 
            this.btn_Degistir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Degistir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Degistir.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Güncelle;
            this.btn_Degistir.Location = new System.Drawing.Point(827, 78);
            this.btn_Degistir.Name = "btn_Degistir";
            this.btn_Degistir.Size = new System.Drawing.Size(102, 49);
            this.btn_Degistir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Degistir.TabIndex = 0;
            this.btn_Degistir.Text = "Güncelle";
            this.btn_Degistir.Click += new System.EventHandler(this.btn_Degistir_Click);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Vazgec.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Vazgec.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.vazgeç;
            this.btn_Vazgec.Location = new System.Drawing.Point(827, 243);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(102, 49);
            this.btn_Vazgec.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Vazgec.TabIndex = 0;
            this.btn_Vazgec.Text = "Vazgeç";
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // gP_Ara
            // 
            this.gP_Ara.CanvasColor = System.Drawing.SystemColors.Control;
            this.gP_Ara.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gP_Ara.Controls.Add(this.lbl_araKasaAdi);
            this.gP_Ara.Controls.Add(this.txt_araKadi);
            this.gP_Ara.Controls.Add(this.cmBox_araPbirim);
            this.gP_Ara.Controls.Add(this.lbl_araParabirimi);
            this.gP_Ara.Location = new System.Drawing.Point(14, 211);
            this.gP_Ara.Name = "gP_Ara";
            this.gP_Ara.Size = new System.Drawing.Size(804, 86);
            // 
            // 
            // 
            this.gP_Ara.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gP_Ara.Style.BackColorGradientAngle = 90;
            this.gP_Ara.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gP_Ara.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Ara.Style.BorderBottomWidth = 1;
            this.gP_Ara.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gP_Ara.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Ara.Style.BorderLeftWidth = 1;
            this.gP_Ara.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Ara.Style.BorderRightWidth = 1;
            this.gP_Ara.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Ara.Style.BorderTopWidth = 1;
            this.gP_Ara.Style.Class = "";
            this.gP_Ara.Style.CornerDiameter = 4;
            this.gP_Ara.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gP_Ara.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            // 
            // 
            // 
            this.gP_Ara.StyleMouseDown.Class = "";
            this.gP_Ara.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gP_Ara.StyleMouseOver.Class = "";
            this.gP_Ara.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gP_Ara.TabIndex = 8;
            this.gP_Ara.Text = "Gelişmiş Arama Paneli";
            // 
            // lbl_araKasaAdi
            // 
            this.lbl_araKasaAdi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_araKasaAdi.BackgroundStyle.Class = "";
            this.lbl_araKasaAdi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_araKasaAdi.Location = new System.Drawing.Point(37, 20);
            this.lbl_araKasaAdi.Name = "lbl_araKasaAdi";
            this.lbl_araKasaAdi.Size = new System.Drawing.Size(75, 23);
            this.lbl_araKasaAdi.TabIndex = 0;
            this.lbl_araKasaAdi.Text = "Kasa Adı: ";
            // 
            // txt_araKadi
            // 
            // 
            // 
            // 
            this.txt_araKadi.Border.Class = "TextBoxBorder";
            this.txt_araKadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_araKadi.Location = new System.Drawing.Point(118, 23);
            this.txt_araKadi.Name = "txt_araKadi";
            this.txt_araKadi.Size = new System.Drawing.Size(174, 20);
            this.txt_araKadi.TabIndex = 2;
            this.txt_araKadi.TextChanged += new System.EventHandler(this.txt_araKadi_TextChanged);
            // 
            // cmBox_araPbirim
            // 
            this.cmBox_araPbirim.DisplayMember = "Text";
            this.cmBox_araPbirim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_araPbirim.FormattingEnabled = true;
            this.cmBox_araPbirim.ItemHeight = 14;
            this.cmBox_araPbirim.Location = new System.Drawing.Point(592, 23);
            this.cmBox_araPbirim.Name = "cmBox_araPbirim";
            this.cmBox_araPbirim.Size = new System.Drawing.Size(173, 20);
            this.cmBox_araPbirim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_araPbirim.TabIndex = 4;
            this.cmBox_araPbirim.SelectedIndexChanged += new System.EventHandler(this.cmBox_araPbirim_SelectedIndexChanged);
            // 
            // lbl_araParabirimi
            // 
            this.lbl_araParabirimi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_araParabirimi.BackgroundStyle.Class = "";
            this.lbl_araParabirimi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_araParabirimi.Location = new System.Drawing.Point(489, 20);
            this.lbl_araParabirimi.Name = "lbl_araParabirimi";
            this.lbl_araParabirimi.Size = new System.Drawing.Size(75, 23);
            this.lbl_araParabirimi.TabIndex = 1;
            this.lbl_araParabirimi.Text = "Para Birimi: ";
            // 
            // dGView_Kasa
            // 
            this.dGView_Kasa.AllowUserToAddRows = false;
            this.dGView_Kasa.AllowUserToDeleteRows = false;
            this.dGView_Kasa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Kasa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KasaID,
            this.KasaAdi,
            this.ParaBirimi,
            this.GirisTarihi,
            this.TBakiye,
            this.Notlar});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView_Kasa.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGView_Kasa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dGView_Kasa.Location = new System.Drawing.Point(12, 311);
            this.dGView_Kasa.Name = "dGView_Kasa";
            this.dGView_Kasa.ReadOnly = true;
            this.dGView_Kasa.Size = new System.Drawing.Size(806, 381);
            this.dGView_Kasa.TabIndex = 9;
            this.dGView_Kasa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Kasa_CellDoubleClick);
            this.dGView_Kasa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Kasa_CellClick);
            // 
            // KasaID
            // 
            this.KasaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KasaID.DataPropertyName = "KasaID";
            this.KasaID.HeaderText = "Kasa Kod";
            this.KasaID.Name = "KasaID";
            this.KasaID.ReadOnly = true;
            this.KasaID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KasaID.Visible = false;
            // 
            // KasaAdi
            // 
            this.KasaAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KasaAdi.DataPropertyName = "KasaAdi";
            this.KasaAdi.FillWeight = 76.56066F;
            this.KasaAdi.HeaderText = "Kasa Adı";
            this.KasaAdi.Name = "KasaAdi";
            this.KasaAdi.ReadOnly = true;
            this.KasaAdi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ParaBirimi
            // 
            this.ParaBirimi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ParaBirimi.DataPropertyName = "ParaBirimi";
            this.ParaBirimi.FillWeight = 76.56066F;
            this.ParaBirimi.HeaderText = "Para Birimi";
            this.ParaBirimi.Name = "ParaBirimi";
            this.ParaBirimi.ReadOnly = true;
            this.ParaBirimi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // GirisTarihi
            // 
            this.GirisTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GirisTarihi.DataPropertyName = "GirisTarihi";
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.GirisTarihi.DefaultCellStyle = dataGridViewCellStyle1;
            this.GirisTarihi.FillWeight = 101.5229F;
            this.GirisTarihi.HeaderText = "Giriş Tarihi";
            this.GirisTarihi.Name = "GirisTarihi";
            this.GirisTarihi.ReadOnly = true;
            this.GirisTarihi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TBakiye
            // 
            this.TBakiye.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TBakiye.DataPropertyName = "TBakiye";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.TBakiye.DefaultCellStyle = dataGridViewCellStyle2;
            this.TBakiye.FillWeight = 76.56066F;
            this.TBakiye.HeaderText = "Toplam Bakiye";
            this.TBakiye.Name = "TBakiye";
            this.TBakiye.ReadOnly = true;
            this.TBakiye.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Notlar
            // 
            this.Notlar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Notlar.DataPropertyName = "Notlar";
            this.Notlar.FillWeight = 168.7952F;
            this.Notlar.HeaderText = "Notlar";
            this.Notlar.Name = "Notlar";
            this.Notlar.ReadOnly = true;
            this.Notlar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btn_Sil
            // 
            this.btn_Sil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sil.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Sil;
            this.btn_Sil.Location = new System.Drawing.Point(827, 133);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(102, 49);
            this.btn_Sil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sil.TabIndex = 0;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_excel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_excel.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Exel;
            this.btn_excel.Location = new System.Drawing.Point(827, 188);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(102, 49);
            this.btn_excel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_excel.TabIndex = 10;
            this.btn_excel.Text = "Excel";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_raporla
            // 
            this.btn_raporla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_raporla.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_raporla.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.raporlama;
            this.btn_raporla.Location = new System.Drawing.Point(827, 298);
            this.btn_raporla.Name = "btn_raporla";
            this.btn_raporla.Size = new System.Drawing.Size(102, 49);
            this.btn_raporla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_raporla.TabIndex = 11;
            this.btn_raporla.Text = "Raporla";
            this.btn_raporla.Click += new System.EventHandler(this.btn_raporla_Click);
            // 
            // KasaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 704);
            this.Controls.Add(this.btn_raporla);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.dGView_Kasa);
            this.Controls.Add(this.gP_Ara);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_Degistir);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.gP_KASA);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KasaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KasaForm";
            this.Load += new System.EventHandler(this.KasaForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KasaForm_FormClosing);
            this.gP_KASA.ResumeLayout(false);
            this.gP_Ara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Kasa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager StilYonetici;
        private DevComponents.DotNetBar.LabelX lbl_Kasaadi;
        private DevComponents.DotNetBar.LabelX lbl_ParaBirimi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX lbl_Bakiye;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_KasaAdi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_ParaBirim;
        private DevComponents.DotNetBar.Controls.GroupPanel gP_KASA;
        private System.Windows.Forms.RichTextBox txt_Notlar;
        private DevComponents.DotNetBar.ButtonX btn_Kaydet;
        private DevComponents.DotNetBar.ButtonX btn_Degistir;
        private DevComponents.DotNetBar.ButtonX btn_Vazgec;
        private DevComponents.DotNetBar.Controls.GroupPanel gP_Ara;
        private DevComponents.DotNetBar.LabelX lbl_araKasaAdi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_araKadi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_araPbirim;
        private DevComponents.DotNetBar.LabelX lbl_araParabirimi;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGView_Kasa;
        private DevComponents.DotNetBar.ButtonX btn_Sil;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_KasaKod;
        private DevComponents.DotNetBar.LabelX lbl_KasaKod;
        private DevComponents.DotNetBar.ButtonX btn_excel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Tbakiye;
        private System.Windows.Forms.DateTimePicker dTP_gTarihi;
        private DevComponents.DotNetBar.LabelX lbl_giristarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KasaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn KasaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParaBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TBakiye;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notlar;
        private DevComponents.DotNetBar.ButtonX btn_raporla;
    }
}