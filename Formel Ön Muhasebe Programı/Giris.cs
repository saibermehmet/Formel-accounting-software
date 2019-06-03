using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Formel_Ön_Muhasebe_Programı
{
    public partial class Giris : Office2007Form
    {
        //SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Muhasebe;Integrated Security=True");

        public Giris()
        {
            InitializeComponent();
        }

        Fonksiyonlar Func = new Fonksiyonlar();

        private void btn_vazgeç_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = Color.Black;
            if (Func.KullaniciKontrol(txt_KAdi.Text,txt_Sifre.Text))
            {
                ActiveForm.Hide();
                Form_Ana frm = new Form_Ana();
                frm.Show();
            }
            else
            {
                MessageBoxEx.Show("   Kullanıcı adı ve şifreyi hatalı veya eksik girdiniz!!!   ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);  
            }
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            Func.BaglantiKontrol();
            //con.Open();
            //if (con.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("opened");
            //}
        }
    }
}
