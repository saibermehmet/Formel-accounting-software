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
    public partial class KasaForm : Office2007Form
    {
        public KasaForm()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();

        private void KasaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Ana frm1 = new Form_Ana();
            frm1.Show();
        }

        private void KasaForm_Load(object sender, EventArgs e)
        {
            Func.Birimdoldur(cmBox_ParaBirim);
            Func.Birimdoldur(cmBox_araPbirim);
            Func.KasaGoster(dGView_Kasa);
        }

        private void txt_Tbakiye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            txt_KasaKod.Text = ""; txt_KasaAdi.Text = ""; cmBox_ParaBirim.SelectedItem = null; txt_Tbakiye.Text = "";
            txt_Notlar.Text = ""; txt_araKadi.Text = ""; cmBox_araPbirim.SelectedItem = null; dTP_gTarihi.Value = DateTime.Today;
        }

        private void txt_KasaAdi_TextChanged(object sender, EventArgs e)
        {
            txt_KasaAdi.MaxLength = 25;
        }

        private void txt_Tbakiye_TextChanged(object sender, EventArgs e)
        {
            txt_Tbakiye.MaxLength = 25;
        }

        private void txt_Notlar_TextChanged(object sender, EventArgs e)
        {
            txt_Notlar.MaxLength = 75;
        }

        private void txt_araKadi_TextChanged(object sender, EventArgs e)
        {
            txt_araKadi.MaxLength = 25;
            Func.KasaAdiAra(txt_araKadi, dGView_Kasa);
            if (txt_araKadi.Text == "")
                Func.KasaGoster(dGView_Kasa);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Func.KasaKaydet(txt_KasaAdi, cmBox_ParaBirim, txt_Tbakiye, txt_Notlar, dTP_gTarihi);
            Func.KasaGoster(dGView_Kasa);
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Func.ExceleAktar(dGView_Kasa);
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            Func.KasaSil(id, dGView_Kasa);
            Func.KasaGoster(dGView_Kasa);
        }

        int id;

        private void dGView_Kasa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dGView_Kasa.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_Degistir_Click(object sender, EventArgs e)
        {
            Func.KasaGuncelle(txt_KasaAdi, cmBox_ParaBirim, txt_Tbakiye, txt_Notlar, dTP_gTarihi, id);
            Func.KasaGoster(dGView_Kasa);
        }

        private void dGView_Kasa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dGView_Kasa.CurrentRow.Cells[0].Value.ToString());
            int x = Convert.ToInt32(e.RowIndex.ToString());
            txt_KasaKod.Text = dGView_Kasa.Rows[x].Cells[0].Value.ToString();
            txt_KasaAdi.Text = dGView_Kasa.Rows[x].Cells[1].Value.ToString();
            cmBox_ParaBirim.SelectedItem = dGView_Kasa.Rows[x].Cells[2].Value;
            dTP_gTarihi.Value = Convert.ToDateTime(dGView_Kasa.Rows[x].Cells[3].Value);
            txt_Tbakiye.Text = dGView_Kasa.Rows[x].Cells[4].Value.ToString();
            txt_Notlar.Text = dGView_Kasa.Rows[x].Cells[5].Value.ToString();
        }

        private void cmBox_araPbirim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBox_araPbirim.SelectedItem == null)
                Func.KasaGoster(dGView_Kasa);
            else
                Func.KasaParaGoster(cmBox_araPbirim, dGView_Kasa);
        }

        private void btn_raporla_Click(object sender, EventArgs e)
        {
            KasaRapor frmKR = new KasaRapor();
            frmKR.ShowDialog();
        }
    }
}
