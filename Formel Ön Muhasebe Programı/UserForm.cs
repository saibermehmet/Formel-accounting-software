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
    public partial class UserForm : Office2007Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();

        private void UserForm_Load(object sender, EventArgs e)
        {
            Func.KAdiSifreGoster(txt_KulAdi,txt_Sifre,txt_SifreT);
        }

        private void btn_SifreDegistir_Click(object sender, EventArgs e)
        {
            Func.SifreAdDegistir(txt_KulAdi, txt_Sifre, txt_SifreT);
        }

        private void btn_Restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void txt_KulAdi_TextChanged(object sender, EventArgs e)
        {
            txt_KulAdi.MaxLength = 25;
        }

        private void txt_Sifre_TextChanged(object sender, EventArgs e)
        {
            txt_Sifre.MaxLength = 25;
        }

        private void txt_SifreT_TextChanged(object sender, EventArgs e)
        {
            txt_SifreT.MaxLength = 25;
        }
    }
}
