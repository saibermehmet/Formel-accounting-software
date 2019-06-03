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
    public partial class Form_Stok : Office2007Form
    {
        public Form_Stok()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();
        double kdv = 0;
        int id;

        private void Form_Stok_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form_Ana frma = new Form_Ana();
            frma.Show();
        }

        private void Form_Stok_Load(object sender, EventArgs e)
        {
            Func.StokGoster(dGView_Stok);
            Func.StokBoxDoldur(cmBox_StokGrup, cmBox_AraSGrup);
            Func.StokAltDoldur(cmBox_AraAGrup);
            Func.KDVgoster(cmBox_KDV);
        }

        private void cmBox_StokGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func.AltBoxDoldur(cmBox_AltGrup,cmBox_StokGrup.SelectedIndex);
        }

        private void cmBox_AraSGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBox_AraSGrup.SelectedItem == null)
                Func.StokGoster(dGView_Stok);
            else
                Func.StokGrupGoster(cmBox_AraSGrup, dGView_Stok);
        }

        private void txt_StokKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_adet_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_KDVdahil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_OzelKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_OrjKod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_Barkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_AraSA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = Color.Black;
            try
            {
                double z = Convert.ToDouble(txt_AlisF.Text);
                double y = Convert.ToDouble(txt_SatisF.Text);
                if (txt_SatisF.Text == "")
                {
                    MessageBoxEx.Show("    Lütfen satış fiyatını giriniz!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double satiş = Convert.ToDouble(txt_SatisF.Text);
                    txt_KDVdahil.Text = (satiş + satiş * kdv).ToString();
                    Func.StokKaydet(txt_stokadi, cmBox_StokGrup, cmBox_AltGrup, txt_AlisF, txt_adet, txt_SatisF, txt_KDVdahil, cmBox_KDV, txt_OzelKod, txt_OrjKod, txt_Barkod);
                    Func.StokGoster(dGView_Stok);
                }
            }
            catch
            {
                MessageBoxEx.Show("   Eksik veya yanlış veri girişi   ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_OzelKod_TextChanged(object sender, EventArgs e)
        {
            txt_OzelKod.MaxLength = 13;
        }

        private void txt_OrjKod_TextChanged(object sender, EventArgs e)
        {
            txt_OrjKod.MaxLength = 13;
        }

        private void txt_Barkod_TextChanged(object sender, EventArgs e)
        {
            txt_Barkod.MaxLength = 13;
        }

        private void txt_stokadi_TextChanged(object sender, EventArgs e)
        {
            txt_stokadi.MaxLength = 25;
        }

        private void btn_Vazgeç_Click(object sender, EventArgs e)
        {
            Sıfırla();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Func.ExceleAktar(dGView_Stok);
        }
        int x;
        private void dGView_Stok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(e.RowIndex.ToString());
            x = Convert.ToInt32(dGView_Stok.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dGView_Stok.CurrentRow.Cells[0].Value.ToString());
            Func.StokSil(id);
            Func.StokGoster(dGView_Stok);
        }

        private void Sıfırla()
        {
            txt_StokKod.Text = ""; txt_stokadi.Text = ""; cmBox_StokGrup.SelectedItem = null; cmBox_AltGrup.SelectedItem = null; cmBox_AltGrup.Items.Clear();
            txt_AlisF.Text = ""; txt_adet.Text = ""; txt_SatisF.Text = ""; txt_KDVdahil.Text = ""; cmBox_KDV.SelectedItem = null; txt_OzelKod.Text = "";
            txt_OrjKod.Text = ""; txt_Barkod.Text = ""; cmBox_AraSGrup.SelectedItem = null; cmBox_AraAGrup.SelectedItem = null; txt_AraSA.Text = "";
        }

        private void cmBox_KDV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBox_KDV.SelectedIndex == 8)
            {
                kdv = 0;
            }
            else if (cmBox_KDV.SelectedIndex == -1)
            {

            }
            else
            {
                kdv = Convert.ToDouble(cmBox_KDV.SelectedItem.ToString().TrimEnd()) / 100;
            }
        }

        private void dGView_Stok_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = Convert.ToInt32(e.RowIndex.ToString());
            txt_StokKod.Text = dGView_Stok.Rows[x].Cells[0].Value.ToString();
            txt_stokadi.Text = dGView_Stok.Rows[x].Cells[1].Value.ToString();
            cmBox_StokGrup.SelectedItem = dGView_Stok.Rows[x].Cells[2].Value;
            cmBox_AltGrup.SelectedItem = dGView_Stok.Rows[x].Cells[3].Value;
            txt_AlisF.Text = dGView_Stok.Rows[x].Cells[4].Value.ToString();
            txt_adet.Text = dGView_Stok.Rows[x].Cells[5].Value.ToString();
            txt_SatisF.Text = dGView_Stok.Rows[x].Cells[6].Value.ToString();
            txt_KDVdahil.Text = dGView_Stok.Rows[x].Cells[7].Value.ToString();
            cmBox_KDV.SelectedItem = dGView_Stok.Rows[x].Cells[8].Value;
            txt_OzelKod.Text = dGView_Stok.Rows[x].Cells[9].Value.ToString(); ;
            txt_OrjKod.Text = dGView_Stok.Rows[x].Cells[10].Value.ToString(); ;
            txt_Barkod.Text = dGView_Stok.Rows[x].Cells[11].Value.ToString();
        }

        private void btn_guncel_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = Color.Black;
            try
            {
                double z = Convert.ToDouble(txt_AlisF.Text);
                double y = Convert.ToDouble(txt_SatisF.Text);
                if (txt_SatisF.Text == "")
                {
                    MessageBoxEx.Show("    Lütfen satış fiyatını giriniz!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    double satiş = Convert.ToDouble(txt_SatisF.Text);
                    txt_KDVdahil.Text = (satiş + satiş * kdv).ToString();
                    Func.StokGuncelle(txt_stokadi, cmBox_StokGrup, cmBox_AltGrup, txt_AlisF, txt_adet, txt_SatisF, txt_KDVdahil, cmBox_KDV, txt_OzelKod, txt_OrjKod, txt_Barkod, x);
                    Func.StokGoster(dGView_Stok);
                }
            }
            catch
            {
                MessageBoxEx.Show("   Eksik veya yanlış veri girişi   ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
       
        private void txt_AraSA_TextChanged(object sender, EventArgs e)
        {
            Func.StokAdiGetir(txt_AraSA, dGView_Stok);
            if (txt_AraSA.Text == "")
            {
                Func.StokGoster(dGView_Stok);
                cmBox_AraAGrup_SelectedIndexChanged(sender, e);
                cmBox_AraSGrup_SelectedIndexChanged(sender, e);
            }
        }

        private void cmBox_AraAGrup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmBox_AraAGrup.SelectedItem == null)
                Func.StokGoster(dGView_Stok);
            else
                Func.StokAltGoster(cmBox_AraAGrup, dGView_Stok);
        }

        private void btn_raporla_Click(object sender, EventArgs e)
        {
            StokRapor frmSR = new StokRapor();
            frmSR.ShowDialog();
        }
    }
}
