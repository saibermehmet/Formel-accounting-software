﻿using System;
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
    public partial class Form_CariEkle : Office2007Form
    {
        public Form_CariEkle()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();
        Form_Cari frmC = new Form_Cari();

        private void Form_CariEkle_Load(object sender, EventArgs e)
        {
            Func.IlDoldur();
            Func.Birimdoldur(cmBox_Parabirimi);
            for (int i = 0; i < Func.CMBOX.Items.Count; i++)
            {
                cmBox_İl.Items.Add(Func.CMBOX.Items[i]);
            }
            Func.CMBOX.Items.Clear();
        }

        private void txt_iskonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_alacak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_verecek_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_risk_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_vergino_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_cariadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_ilgikisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txt_fax_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            Func.CariKaydet(txt_cariadi, txt_ilgikisi, txt_TCno, cmBox_İl, txt_iskonto, txt_alacak, txt_verecek, txt_risk, txt_email, txt_fax, txt_tel, txt_vdairesi, txt_vergino, cmBox_Parabirimi, txt_adres);
            frmC.Carigoster();
        }

        private void btn_Vazgec_Click(object sender, EventArgs e)
        {
            txt_cariadi.Text = ""; txt_ilgikisi.Text = ""; txt_TCno.Text = ""; cmBox_İl.SelectedItem = null; txt_iskonto.Text = "";
            txt_alacak.Text = ""; txt_verecek.Text = ""; txt_risk.Text = ""; txt_email.Text = ""; txt_fax.Text = ""; txt_tel.Text = "";
            txt_vergino.Text = ""; txt_vdairesi.Text = ""; cmBox_Parabirimi.SelectedItem = null; txt_adres.Text = "";
        }

        private void txt_cariadi_TextChanged(object sender, EventArgs e)
        {
            txt_cariadi.MaxLength = 25;
        }

        private void txt_ilgikisi_TextChanged(object sender, EventArgs e)
        {
            txt_ilgikisi.MaxLength = 25;
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 25;
        }

        private void txt_fax_TextChanged(object sender, EventArgs e)
        {
            txt_fax.MaxLength = 11;
        }

        private void txt_vdairesi_TextChanged(object sender, EventArgs e)
        {
            txt_vdairesi.MaxLength = 25;
        }

        private void txt_vergino_TextChanged(object sender, EventArgs e)
        {
            txt_vergino.MaxLength = 20;
        }

        private void txt_adres_TextChanged(object sender, EventArgs e)
        {
            txt_email.MaxLength = 75;
        }
    }
}
