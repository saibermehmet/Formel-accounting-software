using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Formel_Ön_Muhasebe_Programı
{
    public partial class FaturaForm : Office2007Form
    {
        public FaturaForm()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();

        private void FaturaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Ana frm1 = new Form_Ana();
            frm1.Show();
        }

        private void FaturaForm_Load(object sender, EventArgs e)
        {
            Func.Birimdoldur(cmBox_Birim);
            Func.KDVgoster(cmb_KDV);
            Func.FaturaGoster(dGView_Fatura);
        }

        private void txt_masraf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Bfiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_tutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_iskonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Func.ExceleAktar(dGView_Fatura);
        }

        private void btn_Vazgeç_Click(object sender, EventArgs e)
        {
            txt_BelNo.Text = ""; txt_Cari.Text = ""; dT_Tarih.Value = DateTime.Today.Date; dT_Vade.Value = DateTime.Today.Date; txt_masraf.Text = ""; txt_Stokkod.Text = ""; txt_stokadi.Text = ""; txt_miktar.Value = 0;
            cmBox_Birim.SelectedItem = null; cmb_KDV.SelectedItem = null; txt_Bfiyat.Text = ""; txt_tutar.Text = ""; txt_iskonto.Text = ""; txt_aciklama.Text = "";
        }

        private void txt_masraf_TextChanged(object sender, EventArgs e)
        {
            txt_masraf.MaxLength = 15;
        }

        private void txt_Bfiyat_TextChanged(object sender, EventArgs e)
        {
            txt_Bfiyat.MaxLength = 15;
        }

        private void txt_tutar_TextChanged(object sender, EventArgs e)
        {
            txt_tutar.MaxLength = 15;
        }

        private void txt_iskonto_TextChanged(object sender, EventArgs e)
        {
            txt_iskonto.MaxLength = 15;
        }

        private void txt_aciklama_TextChanged(object sender, EventArgs e)
        {
            txt_aciklama.MaxLength = 75;
        }

        private void btn_raporla_Click(object sender, EventArgs e)
        {
            FaturaRapor frmFR = new FaturaRapor();
            frmFR.ShowDialog();
        }
    }
}
