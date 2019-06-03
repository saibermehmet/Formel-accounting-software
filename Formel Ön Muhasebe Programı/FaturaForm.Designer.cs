namespace Formel_Ön_Muhasebe_Programı
{
    partial class FaturaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FaturaForm));
            this.StilYonetici = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lbl_cari = new DevComponents.DotNetBar.LabelX();
            this.cmBox_Birim = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_Cari = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_tarih = new DevComponents.DotNetBar.LabelX();
            this.lbl_belNo = new DevComponents.DotNetBar.LabelX();
            this.lbl_birim = new DevComponents.DotNetBar.LabelX();
            this.dT_Tarih = new System.Windows.Forms.DateTimePicker();
            this.lbl_vade = new DevComponents.DotNetBar.LabelX();
            this.dT_Vade = new System.Windows.Forms.DateTimePicker();
            this.lbl_aciklama = new DevComponents.DotNetBar.LabelX();
            this.txt_aciklama = new System.Windows.Forms.RichTextBox();
            this.lbl_masraf = new DevComponents.DotNetBar.LabelX();
            this.gP_Fatura = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_Stokkod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_BelNo = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_iskonto = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_tutar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Bfiyat = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_miktar = new DevComponents.Editors.IntegerInput();
            this.txt_masraf = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_tutar = new DevComponents.DotNetBar.LabelX();
            this.lbl_stokadi = new DevComponents.DotNetBar.LabelX();
            this.lbl_KDV = new DevComponents.DotNetBar.LabelX();
            this.lbl_stokkod = new DevComponents.DotNetBar.LabelX();
            this.lbl_iskonto = new DevComponents.DotNetBar.LabelX();
            this.lbl_birimfiyat = new DevComponents.DotNetBar.LabelX();
            this.lbl_miktar = new DevComponents.DotNetBar.LabelX();
            this.txt_stokadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmb_KDV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btn_kayitekle = new DevComponents.DotNetBar.ButtonX();
            this.btn_kayitsil = new DevComponents.DotNetBar.ButtonX();
            this.dGView_Fatura = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.FaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masraf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokKod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iskonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_excel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Vazgeç = new DevComponents.DotNetBar.ButtonX();
            this.btn_guncel = new DevComponents.DotNetBar.ButtonX();
            this.btn_yazdir = new DevComponents.DotNetBar.ButtonX();
            this.btn_raporla = new DevComponents.DotNetBar.ButtonX();
            this.gP_Fatura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Fatura)).BeginInit();
            this.SuspendLayout();
            // 
            // StilYonetici
            // 
            this.StilYonetici.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // lbl_cari
            // 
            this.lbl_cari.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_cari.BackgroundStyle.Class = "";
            this.lbl_cari.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_cari.Location = new System.Drawing.Point(19, 44);
            this.lbl_cari.Name = "lbl_cari";
            this.lbl_cari.Size = new System.Drawing.Size(75, 23);
            this.lbl_cari.TabIndex = 1;
            this.lbl_cari.Text = "Cari  * : ";
            // 
            // cmBox_Birim
            // 
            this.cmBox_Birim.DisplayMember = "Text";
            this.cmBox_Birim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_Birim.FormattingEnabled = true;
            this.cmBox_Birim.ItemHeight = 14;
            this.cmBox_Birim.Location = new System.Drawing.Point(454, 110);
            this.cmBox_Birim.Name = "cmBox_Birim";
            this.cmBox_Birim.Size = new System.Drawing.Size(160, 20);
            this.cmBox_Birim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_Birim.TabIndex = 8;
            // 
            // txt_Cari
            // 
            // 
            // 
            // 
            this.txt_Cari.Border.Class = "TextBoxBorder";
            this.txt_Cari.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Cari.Location = new System.Drawing.Point(100, 47);
            this.txt_Cari.Name = "txt_Cari";
            this.txt_Cari.ReadOnly = true;
            this.txt_Cari.Size = new System.Drawing.Size(160, 20);
            this.txt_Cari.TabIndex = 1;
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_tarih.BackgroundStyle.Class = "";
            this.lbl_tarih.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_tarih.Location = new System.Drawing.Point(19, 80);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(75, 23);
            this.lbl_tarih.TabIndex = 0;
            this.lbl_tarih.Text = "Tarih  * : ";
            // 
            // lbl_belNo
            // 
            this.lbl_belNo.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_belNo.BackgroundStyle.Class = "";
            this.lbl_belNo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_belNo.Location = new System.Drawing.Point(19, 12);
            this.lbl_belNo.Name = "lbl_belNo";
            this.lbl_belNo.Size = new System.Drawing.Size(75, 23);
            this.lbl_belNo.TabIndex = 1;
            this.lbl_belNo.Text = "Belge No  * :";
            // 
            // lbl_birim
            // 
            this.lbl_birim.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_birim.BackgroundStyle.Class = "";
            this.lbl_birim.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_birim.Location = new System.Drawing.Point(373, 109);
            this.lbl_birim.Name = "lbl_birim";
            this.lbl_birim.SingleLineColor = System.Drawing.Color.Transparent;
            this.lbl_birim.Size = new System.Drawing.Size(75, 23);
            this.lbl_birim.TabIndex = 0;
            this.lbl_birim.Text = "Birim  * :";
            // 
            // dT_Tarih
            // 
            this.dT_Tarih.Location = new System.Drawing.Point(100, 79);
            this.dT_Tarih.Name = "dT_Tarih";
            this.dT_Tarih.Size = new System.Drawing.Size(160, 20);
            this.dT_Tarih.TabIndex = 2;
            // 
            // lbl_vade
            // 
            this.lbl_vade.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_vade.BackgroundStyle.Class = "";
            this.lbl_vade.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_vade.Location = new System.Drawing.Point(19, 109);
            this.lbl_vade.Name = "lbl_vade";
            this.lbl_vade.SingleLineColor = System.Drawing.Color.Transparent;
            this.lbl_vade.Size = new System.Drawing.Size(75, 23);
            this.lbl_vade.TabIndex = 0;
            this.lbl_vade.Text = "Vade  * : ";
            // 
            // dT_Vade
            // 
            this.dT_Vade.Location = new System.Drawing.Point(100, 113);
            this.dT_Vade.Name = "dT_Vade";
            this.dT_Vade.Size = new System.Drawing.Size(160, 20);
            this.dT_Vade.TabIndex = 5;
            // 
            // lbl_aciklama
            // 
            this.lbl_aciklama.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_aciklama.BackgroundStyle.Class = "";
            this.lbl_aciklama.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_aciklama.Location = new System.Drawing.Point(716, 114);
            this.lbl_aciklama.Name = "lbl_aciklama";
            this.lbl_aciklama.SingleLineColor = System.Drawing.Color.Transparent;
            this.lbl_aciklama.Size = new System.Drawing.Size(75, 23);
            this.lbl_aciklama.TabIndex = 6;
            this.lbl_aciklama.Text = "Açıklama: ";
            // 
            // txt_aciklama
            // 
            this.txt_aciklama.Location = new System.Drawing.Point(797, 114);
            this.txt_aciklama.Name = "txt_aciklama";
            this.txt_aciklama.Size = new System.Drawing.Size(160, 52);
            this.txt_aciklama.TabIndex = 11;
            this.txt_aciklama.Text = "";
            this.txt_aciklama.TextChanged += new System.EventHandler(this.txt_aciklama_TextChanged);
            // 
            // lbl_masraf
            // 
            this.lbl_masraf.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_masraf.BackgroundStyle.Class = "";
            this.lbl_masraf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_masraf.Location = new System.Drawing.Point(19, 140);
            this.lbl_masraf.Name = "lbl_masraf";
            this.lbl_masraf.Size = new System.Drawing.Size(75, 23);
            this.lbl_masraf.TabIndex = 1;
            this.lbl_masraf.Text = "Masraf:";
            // 
            // gP_Fatura
            // 
            this.gP_Fatura.CanvasColor = System.Drawing.SystemColors.Control;
            this.gP_Fatura.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gP_Fatura.Controls.Add(this.txt_Stokkod);
            this.gP_Fatura.Controls.Add(this.txt_BelNo);
            this.gP_Fatura.Controls.Add(this.txt_iskonto);
            this.gP_Fatura.Controls.Add(this.txt_tutar);
            this.gP_Fatura.Controls.Add(this.txt_Bfiyat);
            this.gP_Fatura.Controls.Add(this.txt_miktar);
            this.gP_Fatura.Controls.Add(this.txt_masraf);
            this.gP_Fatura.Controls.Add(this.txt_aciklama);
            this.gP_Fatura.Controls.Add(this.lbl_tarih);
            this.gP_Fatura.Controls.Add(this.lbl_tutar);
            this.gP_Fatura.Controls.Add(this.lbl_aciklama);
            this.gP_Fatura.Controls.Add(this.lbl_vade);
            this.gP_Fatura.Controls.Add(this.lbl_stokadi);
            this.gP_Fatura.Controls.Add(this.lbl_cari);
            this.gP_Fatura.Controls.Add(this.lbl_KDV);
            this.gP_Fatura.Controls.Add(this.lbl_birim);
            this.gP_Fatura.Controls.Add(this.lbl_stokkod);
            this.gP_Fatura.Controls.Add(this.lbl_belNo);
            this.gP_Fatura.Controls.Add(this.dT_Vade);
            this.gP_Fatura.Controls.Add(this.lbl_iskonto);
            this.gP_Fatura.Controls.Add(this.lbl_birimfiyat);
            this.gP_Fatura.Controls.Add(this.lbl_miktar);
            this.gP_Fatura.Controls.Add(this.lbl_masraf);
            this.gP_Fatura.Controls.Add(this.dT_Tarih);
            this.gP_Fatura.Controls.Add(this.txt_stokadi);
            this.gP_Fatura.Controls.Add(this.cmb_KDV);
            this.gP_Fatura.Controls.Add(this.txt_Cari);
            this.gP_Fatura.Controls.Add(this.cmBox_Birim);
            this.gP_Fatura.Location = new System.Drawing.Point(12, 12);
            this.gP_Fatura.Name = "gP_Fatura";
            this.gP_Fatura.Size = new System.Drawing.Size(975, 197);
            // 
            // 
            // 
            this.gP_Fatura.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gP_Fatura.Style.BackColorGradientAngle = 90;
            this.gP_Fatura.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gP_Fatura.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Fatura.Style.BorderBottomWidth = 1;
            this.gP_Fatura.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gP_Fatura.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Fatura.Style.BorderLeftWidth = 1;
            this.gP_Fatura.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Fatura.Style.BorderRightWidth = 1;
            this.gP_Fatura.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gP_Fatura.Style.BorderTopWidth = 1;
            this.gP_Fatura.Style.Class = "";
            this.gP_Fatura.Style.CornerDiameter = 4;
            this.gP_Fatura.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gP_Fatura.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gP_Fatura.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gP_Fatura.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gP_Fatura.StyleMouseDown.Class = "";
            this.gP_Fatura.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gP_Fatura.StyleMouseOver.Class = "";
            this.gP_Fatura.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gP_Fatura.TabIndex = 8;
            this.gP_Fatura.Text = "FATURA";
            // 
            // txt_Stokkod
            // 
            // 
            // 
            // 
            this.txt_Stokkod.Border.Class = "TextBoxBorder";
            this.txt_Stokkod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Stokkod.Location = new System.Drawing.Point(454, 15);
            this.txt_Stokkod.Name = "txt_Stokkod";
            this.txt_Stokkod.ReadOnly = true;
            this.txt_Stokkod.Size = new System.Drawing.Size(160, 20);
            this.txt_Stokkod.TabIndex = 19;
            // 
            // txt_BelNo
            // 
            // 
            // 
            // 
            this.txt_BelNo.Border.Class = "TextBoxBorder";
            this.txt_BelNo.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_BelNo.Location = new System.Drawing.Point(100, 12);
            this.txt_BelNo.Name = "txt_BelNo";
            this.txt_BelNo.ReadOnly = true;
            this.txt_BelNo.Size = new System.Drawing.Size(160, 20);
            this.txt_BelNo.TabIndex = 19;
            // 
            // txt_iskonto
            // 
            // 
            // 
            // 
            this.txt_iskonto.Border.Class = "TextBoxBorder";
            this.txt_iskonto.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_iskonto.Location = new System.Drawing.Point(797, 83);
            this.txt_iskonto.Name = "txt_iskonto";
            this.txt_iskonto.Size = new System.Drawing.Size(160, 20);
            this.txt_iskonto.TabIndex = 18;
            this.txt_iskonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_iskonto_KeyPress);
            this.txt_iskonto.TextChanged += new System.EventHandler(this.txt_iskonto_TextChanged);
            // 
            // txt_tutar
            // 
            // 
            // 
            // 
            this.txt_tutar.Border.Class = "TextBoxBorder";
            this.txt_tutar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_tutar.Location = new System.Drawing.Point(797, 48);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(160, 20);
            this.txt_tutar.TabIndex = 18;
            this.txt_tutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tutar_KeyPress);
            this.txt_tutar.TextChanged += new System.EventHandler(this.txt_tutar_TextChanged);
            // 
            // txt_Bfiyat
            // 
            // 
            // 
            // 
            this.txt_Bfiyat.Border.Class = "TextBoxBorder";
            this.txt_Bfiyat.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Bfiyat.Location = new System.Drawing.Point(797, 15);
            this.txt_Bfiyat.Name = "txt_Bfiyat";
            this.txt_Bfiyat.Size = new System.Drawing.Size(160, 20);
            this.txt_Bfiyat.TabIndex = 17;
            this.txt_Bfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Bfiyat_KeyPress);
            this.txt_Bfiyat.TextChanged += new System.EventHandler(this.txt_Bfiyat_TextChanged);
            // 
            // txt_miktar
            // 
            // 
            // 
            // 
            this.txt_miktar.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txt_miktar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_miktar.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.txt_miktar.Location = new System.Drawing.Point(454, 76);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.ShowUpDown = true;
            this.txt_miktar.Size = new System.Drawing.Size(160, 20);
            this.txt_miktar.TabIndex = 16;
            // 
            // txt_masraf
            // 
            // 
            // 
            // 
            this.txt_masraf.Border.Class = "TextBoxBorder";
            this.txt_masraf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_masraf.Location = new System.Drawing.Point(100, 140);
            this.txt_masraf.Name = "txt_masraf";
            this.txt_masraf.Size = new System.Drawing.Size(160, 20);
            this.txt_masraf.TabIndex = 15;
            this.txt_masraf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_masraf_KeyPress);
            this.txt_masraf.TextChanged += new System.EventHandler(this.txt_masraf_TextChanged);
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_tutar.BackgroundStyle.Class = "";
            this.lbl_tutar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_tutar.Location = new System.Drawing.Point(716, 45);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.SingleLineColor = System.Drawing.Color.Transparent;
            this.lbl_tutar.Size = new System.Drawing.Size(75, 23);
            this.lbl_tutar.TabIndex = 6;
            this.lbl_tutar.Text = "Tutar  * : ";
            // 
            // lbl_stokadi
            // 
            this.lbl_stokadi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_stokadi.BackgroundStyle.Class = "";
            this.lbl_stokadi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_stokadi.Location = new System.Drawing.Point(373, 45);
            this.lbl_stokadi.Name = "lbl_stokadi";
            this.lbl_stokadi.Size = new System.Drawing.Size(75, 23);
            this.lbl_stokadi.TabIndex = 1;
            this.lbl_stokadi.Text = "Stok Adı  * : ";
            // 
            // lbl_KDV
            // 
            this.lbl_KDV.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_KDV.BackgroundStyle.Class = "";
            this.lbl_KDV.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_KDV.Location = new System.Drawing.Point(373, 140);
            this.lbl_KDV.Name = "lbl_KDV";
            this.lbl_KDV.SingleLineColor = System.Drawing.Color.Transparent;
            this.lbl_KDV.Size = new System.Drawing.Size(75, 23);
            this.lbl_KDV.TabIndex = 0;
            this.lbl_KDV.Text = "KDV(%)  * : ";
            // 
            // lbl_stokkod
            // 
            this.lbl_stokkod.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_stokkod.BackgroundStyle.Class = "";
            this.lbl_stokkod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_stokkod.Location = new System.Drawing.Point(373, 12);
            this.lbl_stokkod.Name = "lbl_stokkod";
            this.lbl_stokkod.Size = new System.Drawing.Size(75, 23);
            this.lbl_stokkod.TabIndex = 1;
            this.lbl_stokkod.Text = "Stok Kod  * : ";
            // 
            // lbl_iskonto
            // 
            this.lbl_iskonto.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_iskonto.BackgroundStyle.Class = "";
            this.lbl_iskonto.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_iskonto.Location = new System.Drawing.Point(716, 80);
            this.lbl_iskonto.Name = "lbl_iskonto";
            this.lbl_iskonto.Size = new System.Drawing.Size(75, 23);
            this.lbl_iskonto.TabIndex = 1;
            this.lbl_iskonto.Text = "İskonto: ";
            // 
            // lbl_birimfiyat
            // 
            this.lbl_birimfiyat.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_birimfiyat.BackgroundStyle.Class = "";
            this.lbl_birimfiyat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_birimfiyat.Location = new System.Drawing.Point(716, 12);
            this.lbl_birimfiyat.Name = "lbl_birimfiyat";
            this.lbl_birimfiyat.Size = new System.Drawing.Size(75, 23);
            this.lbl_birimfiyat.TabIndex = 1;
            this.lbl_birimfiyat.Text = "Birim Fiyat  * :";
            // 
            // lbl_miktar
            // 
            this.lbl_miktar.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_miktar.BackgroundStyle.Class = "";
            this.lbl_miktar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_miktar.Location = new System.Drawing.Point(373, 76);
            this.lbl_miktar.Name = "lbl_miktar";
            this.lbl_miktar.Size = new System.Drawing.Size(75, 23);
            this.lbl_miktar.TabIndex = 1;
            this.lbl_miktar.Text = "Miktar  * : ";
            // 
            // txt_stokadi
            // 
            // 
            // 
            // 
            this.txt_stokadi.Border.Class = "TextBoxBorder";
            this.txt_stokadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_stokadi.Location = new System.Drawing.Point(454, 45);
            this.txt_stokadi.Name = "txt_stokadi";
            this.txt_stokadi.ReadOnly = true;
            this.txt_stokadi.Size = new System.Drawing.Size(160, 20);
            this.txt_stokadi.TabIndex = 13;
            // 
            // cmb_KDV
            // 
            this.cmb_KDV.DisplayMember = "Text";
            this.cmb_KDV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_KDV.FormattingEnabled = true;
            this.cmb_KDV.ItemHeight = 14;
            this.cmb_KDV.Location = new System.Drawing.Point(454, 143);
            this.cmb_KDV.Name = "cmb_KDV";
            this.cmb_KDV.Size = new System.Drawing.Size(160, 20);
            this.cmb_KDV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmb_KDV.TabIndex = 9;
            // 
            // btn_kayitekle
            // 
            this.btn_kayitekle.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_kayitekle.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_kayitekle.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.kaydet;
            this.btn_kayitekle.Location = new System.Drawing.Point(993, 27);
            this.btn_kayitekle.Name = "btn_kayitekle";
            this.btn_kayitekle.Size = new System.Drawing.Size(102, 49);
            this.btn_kayitekle.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_kayitekle.TabIndex = 8;
            this.btn_kayitekle.Text = "Kayıt Ekle";
            // 
            // btn_kayitsil
            // 
            this.btn_kayitsil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_kayitsil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_kayitsil.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Sil;
            this.btn_kayitsil.Location = new System.Drawing.Point(993, 139);
            this.btn_kayitsil.Name = "btn_kayitsil";
            this.btn_kayitsil.Size = new System.Drawing.Size(102, 49);
            this.btn_kayitsil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_kayitsil.TabIndex = 0;
            this.btn_kayitsil.Text = "Kayıt Sil";
            // 
            // dGView_Fatura
            // 
            this.dGView_Fatura.AllowUserToAddRows = false;
            this.dGView_Fatura.AllowUserToDeleteRows = false;
            this.dGView_Fatura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Fatura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FaturaID,
            this.CariID,
            this.Tarih,
            this.Vade,
            this.Masraf,
            this.StokKod,
            this.StokAdi,
            this.Miktar,
            this.Birim,
            this.KDV,
            this.BirimFiyat,
            this.Tutar,
            this.Iskonto,
            this.Aciklama});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView_Fatura.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGView_Fatura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dGView_Fatura.Location = new System.Drawing.Point(12, 215);
            this.dGView_Fatura.Name = "dGView_Fatura";
            this.dGView_Fatura.ReadOnly = true;
            this.dGView_Fatura.Size = new System.Drawing.Size(975, 389);
            this.dGView_Fatura.TabIndex = 9;
            // 
            // FaturaID
            // 
            this.FaturaID.DataPropertyName = "FaturaID";
            this.FaturaID.HeaderText = "Fatura ID";
            this.FaturaID.Name = "FaturaID";
            this.FaturaID.ReadOnly = true;
            this.FaturaID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.FaturaID.Width = 67;
            // 
            // CariID
            // 
            this.CariID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CariID.DataPropertyName = "CariID";
            this.CariID.HeaderText = "Cari ID";
            this.CariID.MinimumWidth = 75;
            this.CariID.Name = "CariID";
            this.CariID.ReadOnly = true;
            this.CariID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Tarih
            // 
            this.Tarih.DataPropertyName = "Tarih";
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.ReadOnly = true;
            this.Tarih.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tarih.Width = 75;
            // 
            // Vade
            // 
            this.Vade.DataPropertyName = "Vade";
            this.Vade.HeaderText = "Vade";
            this.Vade.Name = "Vade";
            this.Vade.ReadOnly = true;
            this.Vade.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Vade.Width = 75;
            // 
            // Masraf
            // 
            this.Masraf.DataPropertyName = "Masraf";
            this.Masraf.HeaderText = "Masraf";
            this.Masraf.Name = "Masraf";
            this.Masraf.ReadOnly = true;
            this.Masraf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Masraf.Width = 75;
            // 
            // StokKod
            // 
            this.StokKod.DataPropertyName = "StokKod";
            this.StokKod.HeaderText = "Stok Kod";
            this.StokKod.Name = "StokKod";
            this.StokKod.ReadOnly = true;
            this.StokKod.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StokKod.Width = 85;
            // 
            // StokAdi
            // 
            this.StokAdi.DataPropertyName = "StokAdi";
            this.StokAdi.HeaderText = "Stok Adı";
            this.StokAdi.Name = "StokAdi";
            this.StokAdi.ReadOnly = true;
            this.StokAdi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.StokAdi.Width = 75;
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            this.Miktar.ReadOnly = true;
            this.Miktar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Miktar.Width = 75;
            // 
            // Birim
            // 
            this.Birim.DataPropertyName = "Birim";
            this.Birim.HeaderText = "Birim";
            this.Birim.Name = "Birim";
            this.Birim.ReadOnly = true;
            this.Birim.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Birim.Width = 75;
            // 
            // KDV
            // 
            this.KDV.DataPropertyName = "KDV";
            this.KDV.HeaderText = "KDV";
            this.KDV.Name = "KDV";
            this.KDV.ReadOnly = true;
            this.KDV.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KDV.Width = 75;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            this.BirimFiyat.HeaderText = "Birim Fiyat";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            this.BirimFiyat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.BirimFiyat.Width = 90;
            // 
            // Tutar
            // 
            this.Tutar.DataPropertyName = "Tutar";
            this.Tutar.HeaderText = "Tutar";
            this.Tutar.Name = "Tutar";
            this.Tutar.ReadOnly = true;
            this.Tutar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tutar.Width = 75;
            // 
            // Iskonto
            // 
            this.Iskonto.DataPropertyName = "Iskonto";
            this.Iskonto.HeaderText = "Iskonto";
            this.Iskonto.Name = "Iskonto";
            this.Iskonto.ReadOnly = true;
            this.Iskonto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Iskonto.Width = 75;
            // 
            // Aciklama
            // 
            this.Aciklama.DataPropertyName = "Aciklama";
            this.Aciklama.HeaderText = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Aciklama.Width = 120;
            // 
            // btn_excel
            // 
            this.btn_excel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_excel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_excel.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Exel;
            this.btn_excel.Location = new System.Drawing.Point(993, 195);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(102, 49);
            this.btn_excel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_excel.TabIndex = 11;
            this.btn_excel.Text = "Excel";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_Vazgeç
            // 
            this.btn_Vazgeç.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Vazgeç.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Vazgeç.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.vazgeç;
            this.btn_Vazgeç.Location = new System.Drawing.Point(993, 251);
            this.btn_Vazgeç.Name = "btn_Vazgeç";
            this.btn_Vazgeç.Size = new System.Drawing.Size(102, 49);
            this.btn_Vazgeç.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Vazgeç.TabIndex = 10;
            this.btn_Vazgeç.Text = "Vazgeç";
            this.btn_Vazgeç.Click += new System.EventHandler(this.btn_Vazgeç_Click);
            // 
            // btn_guncel
            // 
            this.btn_guncel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guncel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guncel.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Güncelle;
            this.btn_guncel.Location = new System.Drawing.Point(993, 83);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(102, 49);
            this.btn_guncel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guncel.TabIndex = 12;
            this.btn_guncel.Text = "Güncelle";
            // 
            // btn_yazdir
            // 
            this.btn_yazdir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_yazdir.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_yazdir.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.favicon__6_;
            this.btn_yazdir.Location = new System.Drawing.Point(993, 307);
            this.btn_yazdir.Name = "btn_yazdir";
            this.btn_yazdir.Size = new System.Drawing.Size(102, 49);
            this.btn_yazdir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_yazdir.TabIndex = 0;
            this.btn_yazdir.Text = "Yazdır";
            // 
            // btn_raporla
            // 
            this.btn_raporla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_raporla.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_raporla.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.raporlama;
            this.btn_raporla.Location = new System.Drawing.Point(993, 363);
            this.btn_raporla.Name = "btn_raporla";
            this.btn_raporla.Size = new System.Drawing.Size(100, 49);
            this.btn_raporla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_raporla.TabIndex = 13;
            this.btn_raporla.Text = "Raporla";
            this.btn_raporla.Click += new System.EventHandler(this.btn_raporla_Click);
            // 
            // FaturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1106, 616);
            this.Controls.Add(this.btn_raporla);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.btn_Vazgeç);
            this.Controls.Add(this.dGView_Fatura);
            this.Controls.Add(this.btn_kayitekle);
            this.Controls.Add(this.btn_yazdir);
            this.Controls.Add(this.btn_kayitsil);
            this.Controls.Add(this.gP_Fatura);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FaturaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura";
            this.Load += new System.EventHandler(this.FaturaForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FaturaForm_FormClosing);
            this.gP_Fatura.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_miktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Fatura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager StilYonetici;
        private DevComponents.DotNetBar.LabelX lbl_cari;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_Birim;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Cari;
        private DevComponents.DotNetBar.LabelX lbl_tarih;
        private DevComponents.DotNetBar.LabelX lbl_belNo;
        private DevComponents.DotNetBar.LabelX lbl_birim;
        private System.Windows.Forms.DateTimePicker dT_Tarih;
        private DevComponents.DotNetBar.LabelX lbl_vade;
        private System.Windows.Forms.DateTimePicker dT_Vade;
        private DevComponents.DotNetBar.LabelX lbl_aciklama;
        private System.Windows.Forms.RichTextBox txt_aciklama;
        private DevComponents.DotNetBar.LabelX lbl_masraf;
        private DevComponents.DotNetBar.Controls.GroupPanel gP_Fatura;
        private DevComponents.DotNetBar.LabelX lbl_tutar;
        private DevComponents.DotNetBar.LabelX lbl_stokadi;
        private DevComponents.DotNetBar.LabelX lbl_stokkod;
        private DevComponents.DotNetBar.LabelX lbl_miktar;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_stokadi;
        private DevComponents.DotNetBar.LabelX lbl_KDV;
        private DevComponents.DotNetBar.LabelX lbl_iskonto;
        private DevComponents.DotNetBar.LabelX lbl_birimfiyat;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmb_KDV;
        private DevComponents.DotNetBar.ButtonX btn_kayitekle;
        private DevComponents.DotNetBar.ButtonX btn_kayitsil;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGView_Fatura;
        private DevComponents.DotNetBar.ButtonX btn_excel;
        private DevComponents.DotNetBar.ButtonX btn_Vazgeç;
        private DevComponents.DotNetBar.ButtonX btn_guncel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_tutar;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Bfiyat;
        private DevComponents.Editors.IntegerInput txt_miktar;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_masraf;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_iskonto;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Stokkod;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_BelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masraf;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokKod;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birim;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iskonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private DevComponents.DotNetBar.ButtonX btn_yazdir;
        private DevComponents.DotNetBar.ButtonX btn_raporla;
    }
}