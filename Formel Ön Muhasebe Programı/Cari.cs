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
    public partial class Form_Cari : Office2007Form
    {
        public Form_Cari()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Form_CariEkle frm = new Form_CariEkle();
            frm.ShowDialog();
        }
        
        private void buttonX2_Click(object sender, EventArgs e)
        {
            try
            {
                Aktar();
            }
            catch
            {
                ;
            }
        }

        public void Form_Cari_Load(object sender, EventArgs e)
        {
            Func.IlDoldur();
            for (int i = 0; i < Func.CMBOX.Items.Count; i++)
            {
                cmBox_İl.Items.Add(Func.CMBOX.Items[i]);
            }
            Func.CMBOX.Items.Clear();
            Func.CariGoster(dGView_Cari);
        }

        private void Form_Cari_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Ana frm1 = new Form_Ana();
            frm1.Show();
        }

        private void txt_carikod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dGView_Cari_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                x = Convert.ToInt32(e.RowIndex.ToString());
                Aktar();
            }
            catch
            {
                ;
            }
        }
        int x;
        private void Aktar()
        {
            CariGuncelle frmCG = new CariGuncelle();
            Func.IlDoldur();
            Func.Birimdoldur(frmCG.cmBox_Parabirimi);
            for (int i = 0; i < Func.CMBOX.Items.Count; i++)
            {
                frmCG.cmBox_İl.Items.Add(Func.CMBOX.Items[i]);
            }
            Func.CMBOX.Items.Clear();
            frmCG.lbl_id.Text = dGView_Cari.Rows[x].Cells[0].Value.ToString().TrimEnd();
            frmCG.txt_cariadi.Text = dGView_Cari.Rows[x].Cells[1].Value.ToString().TrimEnd();
            frmCG.txt_ilgikisi.Text = dGView_Cari.Rows[x].Cells[2].Value.ToString().TrimEnd();
            frmCG.txt_TCno.Text = dGView_Cari.Rows[x].Cells[3].Value.ToString().TrimEnd();
            frmCG.cmBox_İl.SelectedItem = dGView_Cari.Rows[x].Cells[4].Value;
            frmCG.txt_iskonto.Text = dGView_Cari.Rows[x].Cells[5].Value.ToString().TrimEnd();
            frmCG.txt_alacak.Text = dGView_Cari.Rows[x].Cells[6].Value.ToString().TrimEnd();
            frmCG.txt_verecek.Text = dGView_Cari.Rows[x].Cells[7].Value.ToString().TrimEnd();
            frmCG.txt_risk.Text = dGView_Cari.Rows[x].Cells[8].Value.ToString().TrimEnd();
            frmCG.txt_email.Text = dGView_Cari.Rows[x].Cells[9].Value.ToString().TrimEnd();
            frmCG.txt_fax.Text = dGView_Cari.Rows[x].Cells[10].Value.ToString().TrimEnd();
            frmCG.txt_tel.Text = dGView_Cari.Rows[x].Cells[11].Value.ToString().TrimEnd();
            frmCG.txt_vdairesi.Text = dGView_Cari.Rows[x].Cells[12].Value.ToString().TrimEnd();
            frmCG.txt_vergino.Text = dGView_Cari.Rows[x].Cells[13].Value.ToString().TrimEnd();
            frmCG.cmBox_Parabirimi.SelectedItem = dGView_Cari.Rows[x].Cells[14].Value;
            frmCG.txt_adres.Text = dGView_Cari.Rows[x].Cells[15].Value.ToString().TrimEnd();
            frmCG.ShowDialog();
        }

        private void btn_carisil_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = Color.Black;
            if (MessageBoxEx.Show("   Silmek istediğinizden emin misiniz?   ", "Dikkat",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Func.CariSil(index);
                Func.CariGoster(dGView_Cari);
            }
        }

        int index;

        private void dGView_Cari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = Convert.ToInt32(dGView_Cari.CurrentRow.Cells[0].Value.ToString());
                x = Convert.ToInt32(e.RowIndex.ToString());
            }
            catch
            {
                ;
            }
        }

        private void btn_Goster_Click(object sender, EventArgs e)
        {
            Func.CariGoster(dGView_Cari);
        }

        private void txt_carikod_TextChanged(object sender, EventArgs e)
        {
            txt_carikod.MaxLength = 10;
            Func.CariLikeID(txt_carikod, dGView_Cari);
            if (txt_carikod.Text == "")
                Func.CariGoster(dGView_Cari);
        }

        private void txt_cariadi_TextChanged(object sender, EventArgs e)
        {
            txt_cariadi.MaxLength = 25;
            Func.CariLikeAdi(txt_cariadi, dGView_Cari);
            if (txt_cariadi.Text == "")
                Func.CariGoster(dGView_Cari);
        }

        private void cmBox_İl_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.CariLikeIL(cmBox_İl, dGView_Cari);
        }

        public void Carigoster()
        {
            Func.CariGoster(dGView_Cari);
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Func.ExceleAktar(dGView_Cari);
        }

        private void btn_raporla_Click(object sender, EventArgs e)
        {
            CariRapor frmCR = new CariRapor();
            frmCR.ShowDialog();
        }
    }
}
