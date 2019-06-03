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
    public partial class Form_Ana : Office2007Form
    {
        public Form_Ana()
        {
            InitializeComponent();
        }

        private void Form_Ana_Load(object sender, EventArgs e)
        {
            tmr_saat.Start();
        }

        private void Form_Ana_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form_Stok frms = new Form_Stok();
            frms.Show();
        }

        private void btn_Kasa_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            KasaForm frmk = new KasaForm();
            frmk.Show();
        }

        private void btn_Fatura_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            FaturaForm frmF = new FaturaForm();
            frmF.Show();
        }

        

        private void btn_hakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda about = new Hakkinda();
            about.Show();
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = Color.Black;
            if (MessageBoxEx.Show("   Çıkmak istediğinizden eminmisiniz?   ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Cari_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            Form_Cari frm = new Form_Cari();
            frm.Show();
        }

        private void altntn_rehber_Click(object sender, EventArgs e)
        {
            RehberForm frmR = new RehberForm();
            frmR.ShowDialog();
        }

        private void btn_Kulislem_Click(object sender, EventArgs e)
        {
            UserForm frmU = new UserForm();
            frmU.ShowDialog();
        }

        private void btn_hesapM_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void tmr_saat_Tick(object sender, EventArgs e)
        {
            lbl_Saat.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();
        }

        private void btn_tanitim_Click(object sender, EventArgs e)
        {
            FormTanitim frmT = new FormTanitim();
            frmT.ShowDialog();
        }
    }
}
