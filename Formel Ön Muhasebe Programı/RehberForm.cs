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
    public partial class RehberForm : Office2007Form
    {
        public RehberForm()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();

        private void txt_Ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_fax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void RehberForm_Load(object sender, EventArgs e)
        {
            Func.RehberGoster(dGView_Kisiler);
        }

        int secilen;

        private void dGView_Kisiler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = Convert.ToInt32(dGView_Kisiler.CurrentRow.Cells[0].Value.ToString());
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            Func.RehberKaydet(txt_Ad,txt_Tel,txt_fax,txt_email,txt_web,txt_adres);
            Func.RehberGoster(dGView_Kisiler);
            Sıfırla();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = Color.Black;
            if (MessageBoxEx.Show("   Silmek istediğinizden emin misiniz?   ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Func.RehberSil(secilen);
                Func.RehberGoster(dGView_Kisiler);
            }
            
        }

        private void txt_Ad_TextChanged(object sender, EventArgs e)
        {
            txt_Ad.MaxLength = 25;
        }

        private void txt_fax_TextChanged(object sender, EventArgs e)
        {
            txt_fax.MaxLength = 11;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 25;
        }

        private void txt_web_TextChanged(object sender, EventArgs e)
        {
            txt_web.MaxLength = 25;
        }

        private void txt_adres_TextChanged(object sender, EventArgs e)
        {
            txt_adres.MaxLength = 75;
        }

        private void dGView_Kisiler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = Convert.ToInt32(e.RowIndex.ToString());
            txt_Ad.Text = dGView_Kisiler.Rows[x].Cells[1].Value.ToString().TrimEnd();
            txt_Tel.Text = dGView_Kisiler.Rows[x].Cells[2].Value.ToString().TrimEnd();
            txt_fax.Text = dGView_Kisiler.Rows[x].Cells[3].Value.ToString().TrimEnd();
            txt_email.Text = dGView_Kisiler.Rows[x].Cells[4].Value.ToString().TrimEnd();
            txt_web.Text = dGView_Kisiler.Rows[x].Cells[5].Value.ToString().TrimEnd();
            txt_adres.Text = dGView_Kisiler.Rows[x].Cells[6].Value.ToString().TrimEnd();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            Func.RehberGuncelle(txt_Ad, txt_Tel, txt_fax, txt_email, txt_web, txt_adres, secilen);
            Func.RehberGoster(dGView_Kisiler);
            Sıfırla();
        }

        private void btn_vazgec_Click(object sender, EventArgs e)
        {
            Sıfırla();
        }

        void Sıfırla()
        {
            txt_Ad.Text = ""; txt_Tel.Text = ""; txt_fax.Text = ""; txt_email.Text = ""; txt_web.Text = ""; txt_adres.Text = "";
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            Func.ExceleAktar(dGView_Kisiler);
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_raporla_Click(object sender, EventArgs e)
        {
            RehberRapor frmRR = new RehberRapor();
            frmRR.ShowDialog();
        }
    }
}
