namespace Formel_Ön_Muhasebe_Programı
{
    partial class Form_Stok
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Stok));
            this.StilYonetici = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lbl_Stokkod = new DevComponents.DotNetBar.LabelX();
            this.lbl_Stokadi = new DevComponents.DotNetBar.LabelX();
            this.lbl_stokgrup = new DevComponents.DotNetBar.LabelX();
            this.lbl_altgrup = new DevComponents.DotNetBar.LabelX();
            this.lbl_alisFiyati = new DevComponents.DotNetBar.LabelX();
            this.lbl_SatisFiyati = new DevComponents.DotNetBar.LabelX();
            this.lbl_KDVdahil = new DevComponents.DotNetBar.LabelX();
            this.lbl_Kdv = new DevComponents.DotNetBar.LabelX();
            this.lbl_OzelKod = new DevComponents.DotNetBar.LabelX();
            this.lbl_OrjKod = new DevComponents.DotNetBar.LabelX();
            this.lbl_Barkod = new DevComponents.DotNetBar.LabelX();
            this.cmBox_StokGrup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmBox_AltGrup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmBox_KDV = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.txt_stokadi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_AlisF = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_SatisF = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_KDVdahil = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_OzelKod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_OrjKod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txt_Barkod = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gPanel_Stokgiris = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_StokKod = new DevComponents.DotNetBar.Controls.MaskedTextBoxAdv();
            this.lbl_Adet = new DevComponents.DotNetBar.LabelX();
            this.txt_adet = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.gP_Ara = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.txt_AraSA = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lbl_araStokGrup = new DevComponents.DotNetBar.LabelX();
            this.cmBox_AraSGrup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.lbl_araStokAdi = new DevComponents.DotNetBar.LabelX();
            this.lbl_araAltGrup = new DevComponents.DotNetBar.LabelX();
            this.cmBox_AraAGrup = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.StokID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KDVli_Fiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dGView_Stok = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Stokkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stokadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AltG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlisF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kdvlif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdv0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OzelK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORJkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_guncel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Sil = new DevComponents.DotNetBar.ButtonX();
            this.btn_Kaydet = new DevComponents.DotNetBar.ButtonX();
            this.btn_excel = new DevComponents.DotNetBar.ButtonX();
            this.btn_Vazgeç = new DevComponents.DotNetBar.ButtonX();
            this.btn_raporla = new DevComponents.DotNetBar.ButtonX();
            this.gPanel_Stokgiris.SuspendLayout();
            this.gP_Ara.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Stok)).BeginInit();
            this.SuspendLayout();
            // 
            // StilYonetici
            // 
            this.StilYonetici.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Black;
            // 
            // lbl_Stokkod
            // 
            this.lbl_Stokkod.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Stokkod.BackgroundStyle.Class = "";
            this.lbl_Stokkod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Stokkod.Location = new System.Drawing.Point(15, 15);
            this.lbl_Stokkod.Name = "lbl_Stokkod";
            this.lbl_Stokkod.Size = new System.Drawing.Size(75, 23);
            this.lbl_Stokkod.TabIndex = 0;
            this.lbl_Stokkod.Text = "Stok Kod  * :";
            // 
            // lbl_Stokadi
            // 
            this.lbl_Stokadi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Stokadi.BackgroundStyle.Class = "";
            this.lbl_Stokadi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Stokadi.Location = new System.Drawing.Point(15, 44);
            this.lbl_Stokadi.Name = "lbl_Stokadi";
            this.lbl_Stokadi.Size = new System.Drawing.Size(75, 23);
            this.lbl_Stokadi.TabIndex = 0;
            this.lbl_Stokadi.Text = "Stok Adı  * :";
            // 
            // lbl_stokgrup
            // 
            this.lbl_stokgrup.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_stokgrup.BackgroundStyle.Class = "";
            this.lbl_stokgrup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_stokgrup.Location = new System.Drawing.Point(15, 73);
            this.lbl_stokgrup.Name = "lbl_stokgrup";
            this.lbl_stokgrup.Size = new System.Drawing.Size(75, 23);
            this.lbl_stokgrup.TabIndex = 0;
            this.lbl_stokgrup.Text = "Stok Grup  * :";
            // 
            // lbl_altgrup
            // 
            this.lbl_altgrup.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_altgrup.BackgroundStyle.Class = "";
            this.lbl_altgrup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_altgrup.Location = new System.Drawing.Point(15, 102);
            this.lbl_altgrup.Name = "lbl_altgrup";
            this.lbl_altgrup.Size = new System.Drawing.Size(75, 23);
            this.lbl_altgrup.TabIndex = 0;
            this.lbl_altgrup.Text = "Alt Grup  * :";
            // 
            // lbl_alisFiyati
            // 
            this.lbl_alisFiyati.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_alisFiyati.BackgroundStyle.Class = "";
            this.lbl_alisFiyati.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_alisFiyati.Location = new System.Drawing.Point(406, 15);
            this.lbl_alisFiyati.Name = "lbl_alisFiyati";
            this.lbl_alisFiyati.Size = new System.Drawing.Size(75, 23);
            this.lbl_alisFiyati.TabIndex = 0;
            this.lbl_alisFiyati.Text = "Alış Fiyatı  * :";
            // 
            // lbl_SatisFiyati
            // 
            this.lbl_SatisFiyati.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_SatisFiyati.BackgroundStyle.Class = "";
            this.lbl_SatisFiyati.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_SatisFiyati.Location = new System.Drawing.Point(406, 73);
            this.lbl_SatisFiyati.Name = "lbl_SatisFiyati";
            this.lbl_SatisFiyati.Size = new System.Drawing.Size(121, 23);
            this.lbl_SatisFiyati.TabIndex = 0;
            this.lbl_SatisFiyati.Text = "Satış Fiyatı  * :";
            // 
            // lbl_KDVdahil
            // 
            this.lbl_KDVdahil.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_KDVdahil.BackgroundStyle.Class = "";
            this.lbl_KDVdahil.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_KDVdahil.Location = new System.Drawing.Point(406, 102);
            this.lbl_KDVdahil.Name = "lbl_KDVdahil";
            this.lbl_KDVdahil.Size = new System.Drawing.Size(121, 23);
            this.lbl_KDVdahil.TabIndex = 0;
            this.lbl_KDVdahil.Text = "KDV Dahil *  :";
            // 
            // lbl_Kdv
            // 
            this.lbl_Kdv.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Kdv.BackgroundStyle.Class = "";
            this.lbl_Kdv.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Kdv.Location = new System.Drawing.Point(766, 15);
            this.lbl_Kdv.Name = "lbl_Kdv";
            this.lbl_Kdv.Size = new System.Drawing.Size(75, 23);
            this.lbl_Kdv.TabIndex = 0;
            this.lbl_Kdv.Text = "KDV(%)  * :";
            // 
            // lbl_OzelKod
            // 
            this.lbl_OzelKod.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_OzelKod.BackgroundStyle.Class = "";
            this.lbl_OzelKod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_OzelKod.Location = new System.Drawing.Point(766, 44);
            this.lbl_OzelKod.Name = "lbl_OzelKod";
            this.lbl_OzelKod.Size = new System.Drawing.Size(121, 23);
            this.lbl_OzelKod.TabIndex = 0;
            this.lbl_OzelKod.Text = "Özel Kod:";
            // 
            // lbl_OrjKod
            // 
            this.lbl_OrjKod.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_OrjKod.BackgroundStyle.Class = "";
            this.lbl_OrjKod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_OrjKod.Location = new System.Drawing.Point(766, 73);
            this.lbl_OrjKod.Name = "lbl_OrjKod";
            this.lbl_OrjKod.Size = new System.Drawing.Size(121, 23);
            this.lbl_OrjKod.TabIndex = 0;
            this.lbl_OrjKod.Text = "Orj Kod  * :";
            // 
            // lbl_Barkod
            // 
            this.lbl_Barkod.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Barkod.BackgroundStyle.Class = "";
            this.lbl_Barkod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Barkod.Location = new System.Drawing.Point(766, 102);
            this.lbl_Barkod.Name = "lbl_Barkod";
            this.lbl_Barkod.Size = new System.Drawing.Size(121, 23);
            this.lbl_Barkod.TabIndex = 0;
            this.lbl_Barkod.Text = "Barkod  * :";
            // 
            // cmBox_StokGrup
            // 
            this.cmBox_StokGrup.DisplayMember = "Text";
            this.cmBox_StokGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_StokGrup.FormattingEnabled = true;
            this.cmBox_StokGrup.ItemHeight = 14;
            this.cmBox_StokGrup.Location = new System.Drawing.Point(96, 76);
            this.cmBox_StokGrup.Name = "cmBox_StokGrup";
            this.cmBox_StokGrup.Size = new System.Drawing.Size(173, 20);
            this.cmBox_StokGrup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_StokGrup.TabIndex = 1;
            this.cmBox_StokGrup.SelectedIndexChanged += new System.EventHandler(this.cmBox_StokGrup_SelectedIndexChanged);
            // 
            // cmBox_AltGrup
            // 
            this.cmBox_AltGrup.DisplayMember = "Text";
            this.cmBox_AltGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_AltGrup.FormattingEnabled = true;
            this.cmBox_AltGrup.ItemHeight = 14;
            this.cmBox_AltGrup.Location = new System.Drawing.Point(96, 105);
            this.cmBox_AltGrup.Name = "cmBox_AltGrup";
            this.cmBox_AltGrup.Size = new System.Drawing.Size(173, 20);
            this.cmBox_AltGrup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_AltGrup.TabIndex = 1;
            // 
            // cmBox_KDV
            // 
            this.cmBox_KDV.DisplayMember = "Text";
            this.cmBox_KDV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_KDV.FormattingEnabled = true;
            this.cmBox_KDV.ItemHeight = 14;
            this.cmBox_KDV.Location = new System.Drawing.Point(855, 18);
            this.cmBox_KDV.Name = "cmBox_KDV";
            this.cmBox_KDV.Size = new System.Drawing.Size(173, 20);
            this.cmBox_KDV.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_KDV.TabIndex = 1;
            this.cmBox_KDV.SelectedIndexChanged += new System.EventHandler(this.cmBox_KDV_SelectedIndexChanged);
            // 
            // txt_stokadi
            // 
            // 
            // 
            // 
            this.txt_stokadi.Border.Class = "TextBoxBorder";
            this.txt_stokadi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_stokadi.Location = new System.Drawing.Point(96, 47);
            this.txt_stokadi.Name = "txt_stokadi";
            this.txt_stokadi.Size = new System.Drawing.Size(173, 20);
            this.txt_stokadi.TabIndex = 2;
            this.txt_stokadi.TextChanged += new System.EventHandler(this.txt_stokadi_TextChanged);
            // 
            // txt_AlisF
            // 
            // 
            // 
            // 
            this.txt_AlisF.Border.Class = "TextBoxBorder";
            this.txt_AlisF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_AlisF.Location = new System.Drawing.Point(487, 18);
            this.txt_AlisF.Name = "txt_AlisF";
            this.txt_AlisF.Size = new System.Drawing.Size(173, 20);
            this.txt_AlisF.TabIndex = 2;
            // 
            // txt_SatisF
            // 
            // 
            // 
            // 
            this.txt_SatisF.Border.Class = "TextBoxBorder";
            this.txt_SatisF.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_SatisF.Location = new System.Drawing.Point(487, 76);
            this.txt_SatisF.Name = "txt_SatisF";
            this.txt_SatisF.Size = new System.Drawing.Size(173, 20);
            this.txt_SatisF.TabIndex = 2;
            // 
            // txt_KDVdahil
            // 
            // 
            // 
            // 
            this.txt_KDVdahil.Border.Class = "TextBoxBorder";
            this.txt_KDVdahil.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_KDVdahil.Location = new System.Drawing.Point(487, 105);
            this.txt_KDVdahil.Name = "txt_KDVdahil";
            this.txt_KDVdahil.ReadOnly = true;
            this.txt_KDVdahil.Size = new System.Drawing.Size(173, 20);
            this.txt_KDVdahil.TabIndex = 2;
            this.txt_KDVdahil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KDVdahil_KeyPress);
            // 
            // txt_OzelKod
            // 
            // 
            // 
            // 
            this.txt_OzelKod.Border.Class = "TextBoxBorder";
            this.txt_OzelKod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_OzelKod.Location = new System.Drawing.Point(855, 47);
            this.txt_OzelKod.Name = "txt_OzelKod";
            this.txt_OzelKod.Size = new System.Drawing.Size(173, 20);
            this.txt_OzelKod.TabIndex = 2;
            this.txt_OzelKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OzelKod_KeyPress);
            this.txt_OzelKod.TextChanged += new System.EventHandler(this.txt_OzelKod_TextChanged);
            // 
            // txt_OrjKod
            // 
            // 
            // 
            // 
            this.txt_OrjKod.Border.Class = "TextBoxBorder";
            this.txt_OrjKod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_OrjKod.Location = new System.Drawing.Point(855, 76);
            this.txt_OrjKod.Name = "txt_OrjKod";
            this.txt_OrjKod.Size = new System.Drawing.Size(173, 20);
            this.txt_OrjKod.TabIndex = 2;
            this.txt_OrjKod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_OrjKod_KeyPress);
            this.txt_OrjKod.TextChanged += new System.EventHandler(this.txt_OrjKod_TextChanged);
            // 
            // txt_Barkod
            // 
            // 
            // 
            // 
            this.txt_Barkod.Border.Class = "TextBoxBorder";
            this.txt_Barkod.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_Barkod.Location = new System.Drawing.Point(855, 105);
            this.txt_Barkod.Name = "txt_Barkod";
            this.txt_Barkod.Size = new System.Drawing.Size(173, 20);
            this.txt_Barkod.TabIndex = 2;
            this.txt_Barkod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Barkod_KeyPress);
            this.txt_Barkod.TextChanged += new System.EventHandler(this.txt_Barkod_TextChanged);
            // 
            // gPanel_Stokgiris
            // 
            this.gPanel_Stokgiris.BackColor = System.Drawing.Color.Transparent;
            this.gPanel_Stokgiris.CanvasColor = System.Drawing.SystemColors.Control;
            this.gPanel_Stokgiris.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gPanel_Stokgiris.Controls.Add(this.txt_StokKod);
            this.gPanel_Stokgiris.Controls.Add(this.cmBox_StokGrup);
            this.gPanel_Stokgiris.Controls.Add(this.txt_Barkod);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_Stokkod);
            this.gPanel_Stokgiris.Controls.Add(this.txt_OrjKod);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_Stokadi);
            this.gPanel_Stokgiris.Controls.Add(this.txt_OzelKod);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_stokgrup);
            this.gPanel_Stokgiris.Controls.Add(this.txt_KDVdahil);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_altgrup);
            this.gPanel_Stokgiris.Controls.Add(this.txt_SatisF);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_Adet);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_alisFiyati);
            this.gPanel_Stokgiris.Controls.Add(this.txt_adet);
            this.gPanel_Stokgiris.Controls.Add(this.txt_AlisF);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_SatisFiyati);
            this.gPanel_Stokgiris.Controls.Add(this.txt_stokadi);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_KDVdahil);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_Kdv);
            this.gPanel_Stokgiris.Controls.Add(this.cmBox_KDV);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_OzelKod);
            this.gPanel_Stokgiris.Controls.Add(this.cmBox_AltGrup);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_OrjKod);
            this.gPanel_Stokgiris.Controls.Add(this.lbl_Barkod);
            this.gPanel_Stokgiris.Location = new System.Drawing.Point(12, 12);
            this.gPanel_Stokgiris.Name = "gPanel_Stokgiris";
            this.gPanel_Stokgiris.Size = new System.Drawing.Size(1050, 163);
            // 
            // 
            // 
            this.gPanel_Stokgiris.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.gPanel_Stokgiris.Style.BackColorGradientAngle = 90;
            this.gPanel_Stokgiris.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.gPanel_Stokgiris.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanel_Stokgiris.Style.BorderBottomWidth = 1;
            this.gPanel_Stokgiris.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.gPanel_Stokgiris.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanel_Stokgiris.Style.BorderLeftWidth = 1;
            this.gPanel_Stokgiris.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanel_Stokgiris.Style.BorderRightWidth = 1;
            this.gPanel_Stokgiris.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.gPanel_Stokgiris.Style.BorderTopWidth = 1;
            this.gPanel_Stokgiris.Style.Class = "";
            this.gPanel_Stokgiris.Style.CornerDiameter = 4;
            this.gPanel_Stokgiris.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.gPanel_Stokgiris.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.gPanel_Stokgiris.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.gPanel_Stokgiris.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.gPanel_Stokgiris.StyleMouseDown.Class = "";
            this.gPanel_Stokgiris.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.gPanel_Stokgiris.StyleMouseOver.Class = "";
            this.gPanel_Stokgiris.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.gPanel_Stokgiris.TabIndex = 3;
            this.gPanel_Stokgiris.Text = "STOK GİRİŞİ";
            // 
            // txt_StokKod
            // 
            // 
            // 
            // 
            this.txt_StokKod.BackgroundStyle.Class = "";
            this.txt_StokKod.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_StokKod.ButtonClear.Visible = true;
            this.txt_StokKod.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txt_StokKod.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txt_StokKod.Location = new System.Drawing.Point(96, 15);
            this.txt_StokKod.Name = "txt_StokKod";
            this.txt_StokKod.ReadOnly = true;
            this.txt_StokKod.Size = new System.Drawing.Size(174, 20);
            this.txt_StokKod.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.txt_StokKod.TabIndex = 6;
            this.txt_StokKod.Text = "";
            this.txt_StokKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_StokKod.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            // 
            // lbl_Adet
            // 
            this.lbl_Adet.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_Adet.BackgroundStyle.Class = "";
            this.lbl_Adet.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_Adet.Location = new System.Drawing.Point(406, 44);
            this.lbl_Adet.Name = "lbl_Adet";
            this.lbl_Adet.Size = new System.Drawing.Size(75, 23);
            this.lbl_Adet.TabIndex = 0;
            this.lbl_Adet.Text = "Adet  * : ";
            // 
            // txt_adet
            // 
            // 
            // 
            // 
            this.txt_adet.Border.Class = "TextBoxBorder";
            this.txt_adet.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_adet.Location = new System.Drawing.Point(487, 47);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(173, 20);
            this.txt_adet.TabIndex = 2;
            this.txt_adet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_adet_KeyPress);
            // 
            // gP_Ara
            // 
            this.gP_Ara.CanvasColor = System.Drawing.SystemColors.Control;
            this.gP_Ara.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.gP_Ara.Controls.Add(this.txt_AraSA);
            this.gP_Ara.Controls.Add(this.lbl_araStokGrup);
            this.gP_Ara.Controls.Add(this.cmBox_AraSGrup);
            this.gP_Ara.Controls.Add(this.lbl_araStokAdi);
            this.gP_Ara.Controls.Add(this.lbl_araAltGrup);
            this.gP_Ara.Controls.Add(this.cmBox_AraAGrup);
            this.gP_Ara.Location = new System.Drawing.Point(12, 181);
            this.gP_Ara.Name = "gP_Ara";
            this.gP_Ara.Size = new System.Drawing.Size(1050, 76);
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
            this.gP_Ara.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
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
            this.gP_Ara.TabIndex = 5;
            this.gP_Ara.Text = "Gelişmiş Arama Paneli";
            // 
            // txt_AraSA
            // 
            // 
            // 
            // 
            this.txt_AraSA.Border.Class = "TextBoxBorder";
            this.txt_AraSA.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txt_AraSA.Location = new System.Drawing.Point(96, 18);
            this.txt_AraSA.Name = "txt_AraSA";
            this.txt_AraSA.Size = new System.Drawing.Size(173, 20);
            this.txt_AraSA.TabIndex = 2;
            this.txt_AraSA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AraSA_KeyPress);
            this.txt_AraSA.TextChanged += new System.EventHandler(this.txt_AraSA_TextChanged);
            // 
            // lbl_araStokGrup
            // 
            this.lbl_araStokGrup.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_araStokGrup.BackgroundStyle.Class = "";
            this.lbl_araStokGrup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_araStokGrup.Location = new System.Drawing.Point(406, 15);
            this.lbl_araStokGrup.Name = "lbl_araStokGrup";
            this.lbl_araStokGrup.Size = new System.Drawing.Size(54, 23);
            this.lbl_araStokGrup.TabIndex = 0;
            this.lbl_araStokGrup.Text = "Stok Grup:";
            // 
            // cmBox_AraSGrup
            // 
            this.cmBox_AraSGrup.DisplayMember = "Text";
            this.cmBox_AraSGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_AraSGrup.FormattingEnabled = true;
            this.cmBox_AraSGrup.ItemHeight = 14;
            this.cmBox_AraSGrup.Location = new System.Drawing.Point(487, 18);
            this.cmBox_AraSGrup.Name = "cmBox_AraSGrup";
            this.cmBox_AraSGrup.Size = new System.Drawing.Size(173, 20);
            this.cmBox_AraSGrup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_AraSGrup.TabIndex = 1;
            this.cmBox_AraSGrup.SelectedIndexChanged += new System.EventHandler(this.cmBox_AraSGrup_SelectedIndexChanged);
            // 
            // lbl_araStokAdi
            // 
            this.lbl_araStokAdi.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_araStokAdi.BackgroundStyle.Class = "";
            this.lbl_araStokAdi.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_araStokAdi.Location = new System.Drawing.Point(15, 15);
            this.lbl_araStokAdi.Name = "lbl_araStokAdi";
            this.lbl_araStokAdi.Size = new System.Drawing.Size(48, 23);
            this.lbl_araStokAdi.TabIndex = 0;
            this.lbl_araStokAdi.Text = "Stok Adı:";
            // 
            // lbl_araAltGrup
            // 
            this.lbl_araAltGrup.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lbl_araAltGrup.BackgroundStyle.Class = "";
            this.lbl_araAltGrup.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbl_araAltGrup.Location = new System.Drawing.Point(766, 15);
            this.lbl_araAltGrup.Name = "lbl_araAltGrup";
            this.lbl_araAltGrup.Size = new System.Drawing.Size(44, 23);
            this.lbl_araAltGrup.TabIndex = 0;
            this.lbl_araAltGrup.Text = "Alt Grup:";
            // 
            // cmBox_AraAGrup
            // 
            this.cmBox_AraAGrup.DisplayMember = "Text";
            this.cmBox_AraAGrup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmBox_AraAGrup.FormattingEnabled = true;
            this.cmBox_AraAGrup.ItemHeight = 14;
            this.cmBox_AraAGrup.Location = new System.Drawing.Point(855, 18);
            this.cmBox_AraAGrup.Name = "cmBox_AraAGrup";
            this.cmBox_AraAGrup.Size = new System.Drawing.Size(173, 20);
            this.cmBox_AraAGrup.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmBox_AraAGrup.TabIndex = 1;
            this.cmBox_AraAGrup.SelectedIndexChanged += new System.EventHandler(this.cmBox_AraAGrup_SelectedIndexChanged);
            // 
            // StokID
            // 
            this.StokID.DataPropertyName = "StokID";
            this.StokID.HeaderText = "Stok Kod";
            this.StokID.Name = "StokID";
            // 
            // StokAdi
            // 
            this.StokAdi.DataPropertyName = "StokAdi";
            this.StokAdi.HeaderText = "Stok Adı";
            this.StokAdi.Name = "StokAdi";
            // 
            // StokGrup
            // 
            this.StokGrup.DataPropertyName = "StokGrup";
            this.StokGrup.HeaderText = "Stok Grup";
            this.StokGrup.Name = "StokGrup";
            // 
            // AltGrup
            // 
            this.AltGrup.DataPropertyName = "AltGrup";
            this.AltGrup.HeaderText = "Alt Grup";
            this.AltGrup.Name = "AltGrup";
            // 
            // AlisFiyati
            // 
            this.AlisFiyati.DataPropertyName = "AlisFiyati";
            this.AlisFiyati.HeaderText = "Alış Fiyatı";
            this.AlisFiyati.Name = "AlisFiyati";
            // 
            // Adet
            // 
            this.Adet.DataPropertyName = "Adet";
            this.Adet.HeaderText = "Adet";
            this.Adet.Name = "Adet";
            // 
            // SatisFiyati
            // 
            this.SatisFiyati.DataPropertyName = "SatisFiyati";
            this.SatisFiyati.HeaderText = "Satış Fiyatı";
            this.SatisFiyati.Name = "SatisFiyati";
            // 
            // KDVli_Fiyat
            // 
            this.KDVli_Fiyat.DataPropertyName = "KDVli_Fiyat";
            this.KDVli_Fiyat.HeaderText = "KDV\'li Fiyat";
            this.KDVli_Fiyat.Name = "KDVli_Fiyat";
            // 
            // dGView_Stok
            // 
            this.dGView_Stok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView_Stok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Stokkod,
            this.Stokadı,
            this.StokG,
            this.AltG,
            this.AlisF,
            this.adet0,
            this.SatisF,
            this.Kdvlif,
            this.kdv0,
            this.OzelK,
            this.ORJkod,
            this.Barkod});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGView_Stok.DefaultCellStyle = dataGridViewCellStyle1;
            this.dGView_Stok.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dGView_Stok.Location = new System.Drawing.Point(12, 263);
            this.dGView_Stok.Name = "dGView_Stok";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dGView_Stok.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGView_Stok.Size = new System.Drawing.Size(1050, 380);
            this.dGView_Stok.TabIndex = 0;
            this.dGView_Stok.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Stok_CellDoubleClick);
            this.dGView_Stok.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_Stok_CellClick);
            // 
            // Stokkod
            // 
            this.Stokkod.DataPropertyName = "StokID";
            this.Stokkod.HeaderText = "Stok Kod";
            this.Stokkod.Name = "Stokkod";
            this.Stokkod.Visible = false;
            // 
            // Stokadı
            // 
            this.Stokadı.DataPropertyName = "StokAdi";
            this.Stokadı.HeaderText = "Stok Adı";
            this.Stokadı.Name = "Stokadı";
            // 
            // StokG
            // 
            this.StokG.DataPropertyName = "StokGrup";
            this.StokG.HeaderText = "Stok Grup";
            this.StokG.Name = "StokG";
            // 
            // AltG
            // 
            this.AltG.DataPropertyName = "AltGrup";
            this.AltG.HeaderText = "AltGrup";
            this.AltG.Name = "AltG";
            // 
            // AlisF
            // 
            this.AlisF.DataPropertyName = "AlisFiyati";
            this.AlisF.HeaderText = "Alış Fiyatı";
            this.AlisF.Name = "AlisF";
            // 
            // adet0
            // 
            this.adet0.DataPropertyName = "Adet";
            this.adet0.HeaderText = "Adet";
            this.adet0.Name = "adet0";
            // 
            // SatisF
            // 
            this.SatisF.DataPropertyName = "SatisFiyati";
            this.SatisF.HeaderText = "Satış Fiyatı";
            this.SatisF.Name = "SatisF";
            // 
            // Kdvlif
            // 
            this.Kdvlif.DataPropertyName = "KDVli_Fiyat";
            this.Kdvlif.HeaderText = "KDV\'li Fiyat";
            this.Kdvlif.Name = "Kdvlif";
            // 
            // kdv0
            // 
            this.kdv0.DataPropertyName = "KDV";
            this.kdv0.HeaderText = "KDV";
            this.kdv0.Name = "kdv0";
            // 
            // OzelK
            // 
            this.OzelK.DataPropertyName = "OzelKod";
            this.OzelK.HeaderText = "Özel Kod";
            this.OzelK.Name = "OzelK";
            // 
            // ORJkod
            // 
            this.ORJkod.DataPropertyName = "Orjkod";
            this.ORJkod.HeaderText = "Orj Kod";
            this.ORJkod.Name = "ORJkod";
            // 
            // Barkod
            // 
            this.Barkod.DataPropertyName = "Barkod";
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.Name = "Barkod";
            // 
            // btn_guncel
            // 
            this.btn_guncel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_guncel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_guncel.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Güncelle;
            this.btn_guncel.Location = new System.Drawing.Point(1068, 84);
            this.btn_guncel.Name = "btn_guncel";
            this.btn_guncel.Size = new System.Drawing.Size(102, 49);
            this.btn_guncel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_guncel.TabIndex = 0;
            this.btn_guncel.Text = "Güncelle";
            this.btn_guncel.Click += new System.EventHandler(this.btn_guncel_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sil.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sil.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Sil;
            this.btn_Sil.Location = new System.Drawing.Point(1068, 139);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(102, 49);
            this.btn_Sil.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sil.TabIndex = 3;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Kaydet.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Kaydet.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.kaydet;
            this.btn_Kaydet.Location = new System.Drawing.Point(1068, 29);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(102, 49);
            this.btn_Kaydet.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Kaydet.TabIndex = 3;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_excel
            // 
            this.btn_excel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_excel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_excel.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.Exel;
            this.btn_excel.Location = new System.Drawing.Point(1068, 194);
            this.btn_excel.Name = "btn_excel";
            this.btn_excel.Size = new System.Drawing.Size(102, 49);
            this.btn_excel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_excel.TabIndex = 3;
            this.btn_excel.Text = "Excel";
            this.btn_excel.Click += new System.EventHandler(this.btn_excel_Click);
            // 
            // btn_Vazgeç
            // 
            this.btn_Vazgeç.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Vazgeç.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Vazgeç.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.vazgeç;
            this.btn_Vazgeç.Location = new System.Drawing.Point(1068, 249);
            this.btn_Vazgeç.Name = "btn_Vazgeç";
            this.btn_Vazgeç.Size = new System.Drawing.Size(102, 49);
            this.btn_Vazgeç.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Vazgeç.TabIndex = 3;
            this.btn_Vazgeç.Text = "Vazgeç";
            this.btn_Vazgeç.Click += new System.EventHandler(this.btn_Vazgeç_Click);
            // 
            // btn_raporla
            // 
            this.btn_raporla.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_raporla.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_raporla.Image = global::Formel_Ön_Muhasebe_Programı.Properties.Resources.raporlama;
            this.btn_raporla.Location = new System.Drawing.Point(1070, 304);
            this.btn_raporla.Name = "btn_raporla";
            this.btn_raporla.Size = new System.Drawing.Size(100, 49);
            this.btn_raporla.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_raporla.TabIndex = 8;
            this.btn_raporla.Text = "Raporla";
            this.btn_raporla.Click += new System.EventHandler(this.btn_raporla_Click);
            // 
            // Form_Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 655);
            this.Controls.Add(this.btn_raporla);
            this.Controls.Add(this.dGView_Stok);
            this.Controls.Add(this.btn_guncel);
            this.Controls.Add(this.gP_Ara);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.btn_excel);
            this.Controls.Add(this.gPanel_Stokgiris);
            this.Controls.Add(this.btn_Vazgeç);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Stok";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Form_Stok_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Stok_FormClosing);
            this.gPanel_Stokgiris.ResumeLayout(false);
            this.gP_Ara.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGView_Stok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager StilYonetici;
        private DevComponents.DotNetBar.LabelX lbl_Stokkod;
        private DevComponents.DotNetBar.LabelX lbl_Stokadi;
        private DevComponents.DotNetBar.LabelX lbl_stokgrup;
        private DevComponents.DotNetBar.LabelX lbl_altgrup;
        private DevComponents.DotNetBar.LabelX lbl_alisFiyati;
        private DevComponents.DotNetBar.LabelX lbl_SatisFiyati;
        private DevComponents.DotNetBar.LabelX lbl_KDVdahil;
        private DevComponents.DotNetBar.LabelX lbl_Kdv;
        private DevComponents.DotNetBar.LabelX lbl_OzelKod;
        private DevComponents.DotNetBar.LabelX lbl_OrjKod;
        private DevComponents.DotNetBar.LabelX lbl_Barkod;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_StokGrup;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AltGrup;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_KDV;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_stokadi;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_AlisF;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_SatisF;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_KDVdahil;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_OzelKod;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_OrjKod;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_Barkod;
        private DevComponents.DotNetBar.Controls.GroupPanel gPanel_Stokgiris;
        private DevComponents.DotNetBar.ButtonX btn_Vazgeç;
        private DevComponents.DotNetBar.ButtonX btn_Kaydet;
        private DevComponents.DotNetBar.ButtonX btn_excel;
        private DevComponents.DotNetBar.ButtonX btn_Sil;
        private DevComponents.DotNetBar.LabelX lbl_Adet;
        private DevComponents.DotNetBar.Controls.GroupPanel gP_Ara;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_AraSA;
        private DevComponents.DotNetBar.LabelX lbl_araStokGrup;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AraSGrup;
        private DevComponents.DotNetBar.LabelX lbl_araStokAdi;
        private DevComponents.DotNetBar.LabelX lbl_araAltGrup;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AraAGrup;
        private DevComponents.DotNetBar.ButtonX btn_guncel;
        private DevComponents.DotNetBar.Controls.TextBoxX txt_adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn KDVli_Fiyat;
        private DevComponents.DotNetBar.Controls.DataGridViewX dGView_Stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stokkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stokadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokG;
        private System.Windows.Forms.DataGridViewTextBoxColumn AltG;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlisF;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet0;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatisF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kdvlif;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdv0;
        private System.Windows.Forms.DataGridViewTextBoxColumn OzelK;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORJkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_StokKod;
        private DevComponents.DotNetBar.ButtonX btn_raporla;
    }
}