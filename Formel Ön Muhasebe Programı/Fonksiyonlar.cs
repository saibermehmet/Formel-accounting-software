using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace Formel_Ön_Muhasebe_Programı
{
    class Fonksiyonlar
    {
        //SqlConnection baglanti = new SqlConnection("Data Source=" + Environment.MachineName.ToUpper() + "\\SQLEXPRESS; Initial Catalog=Muhasebe; Integrated Security=True;");
        SqlConnection baglanti = new SqlConnection("Data Source=localhost;Initial Catalog=Muhasebe;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adap;
        public ComboBox CMBOX = new ComboBox();

        public void BaglantiKontrol()
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            try
            {
                baglanti.Open();
                MessageBoxEx.Show("   Veritabanı bağlantısı kuruldu.   ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBoxEx.Show("   Veritabanı bağlantısı kurulamadı.   ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            baglanti.Close();
        }
        public void IlDoldur()
        {
            CMBOX.Items.Clear();
            baglanti.Open();
            cmd = new SqlCommand("SELECT IlAdi FROM Iller", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                CMBOX.Items.Add(oku["IlAdi"]);
            }
            oku.Close();
            cmd.Dispose();
            baglanti.Close();
        }

        public bool KullaniciKontrol(string UserName, string Pass)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT * FROM Kullanici WHERE KullaniciAdi=@ad AND Sifre=@pl", baglanti);
            cmd.Parameters.Add("ad", UserName);
            cmd.Parameters.Add("pl", Pass);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.HasRows)
            {
                baglanti.Close();
                return true;
            }
            else
            {
                baglanti.Close();
                return false;
            }
        }

        public void KAdiSifreGoster(DevComponents.DotNetBar.Controls.TextBoxX txt_KulAdi, DevComponents.DotNetBar.Controls.TextBoxX txt_Sifre, DevComponents.DotNetBar.Controls.TextBoxX txt_SifreT)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT KullaniciAdi,Sifre FROM Kullanici", baglanti);
            SqlDataReader ds = cmd.ExecuteReader();
            while (ds.Read())
            {
                txt_KulAdi.Text = ds["KullaniciAdi"].ToString().TrimEnd();
                txt_Sifre.Text = ds["Sifre"].ToString().TrimEnd();
            }
            ds.Close();
            cmd.Dispose();
            baglanti.Close();
        }

        public void SifreAdDegistir(DevComponents.DotNetBar.Controls.TextBoxX txt_KulAdi, DevComponents.DotNetBar.Controls.TextBoxX txt_Sifre, DevComponents.DotNetBar.Controls.TextBoxX txt_SifreT)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (txt_KulAdi.Text != "" && txt_Sifre.Text != "" && txt_SifreT.Text != "")
            {
                if (txt_Sifre.Text != txt_SifreT.Text)
                {
                    MessageBoxEx.Show("   Girdiğiniz şifreler birbiriyle uyuşmamakta!   ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    baglanti.Open();
                    cmd = new SqlCommand("UPDATE Kullanici SET KullaniciAdi=@uname,Sifre=@pass WHERE UserID=1", baglanti);
                    cmd.Parameters.Add("uname", txt_KulAdi.Text);
                    cmd.Parameters.Add("pass", txt_Sifre.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    baglanti.Close();
                    MessageBoxEx.Show("   İşlem başarıyla gerçekleşti.   ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBoxEx.Show("   Lütfen bilgileri eksiksiz girin!  ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CariGoster(DevComponents.DotNetBar.Controls.DataGridViewX dGView_Cari)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM CariList", baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "CariBilgileri");
            dGView_Cari.DataSource = ds.Tables["CariBilgileri"];
            adap.Dispose();
            baglanti.Close();

        }

        public void RehberGoster(DevComponents.DotNetBar.Controls.DataGridViewX dGView_Kisiler)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM RehberList", baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "RehberBilgileri");
            dGView_Kisiler.DataSource = ds.Tables["RehberBilgileri"];
            adap.Dispose();
            baglanti.Close();
        }

        public void CariKaydet(DevComponents.DotNetBar.Controls.TextBoxX txt_cariadi, DevComponents.DotNetBar.Controls.TextBoxX txt_ilgikisi, DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_TCno, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_İl, DevComponents.DotNetBar.Controls.TextBoxX txt_iskonto, DevComponents.DotNetBar.Controls.TextBoxX txt_alacak, DevComponents.DotNetBar.Controls.TextBoxX txt_verecek, DevComponents.DotNetBar.Controls.TextBoxX txt_risk, DevComponents.DotNetBar.Controls.TextBoxX txt_email, DevComponents.DotNetBar.Controls.TextBoxX txt_fax, DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_tel, DevComponents.DotNetBar.Controls.TextBoxX txt_vdairesi, DevComponents.DotNetBar.Controls.TextBoxX txt_vergino, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_Parabirimi, RichTextBox txt_adres)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (txt_cariadi.Text != "" && txt_ilgikisi.Text != "" && txt_TCno.Text.Length == 11 && cmBox_İl.SelectedItem != null && txt_alacak.Text != "" && txt_verecek.Text != "" && txt_risk.Text != "" && txt_email.Text != "" && txt_tel.Text.Length == 14 && txt_vdairesi.Text != "" && txt_vergino.Text != "" && cmBox_Parabirimi.SelectedItem != null)
            {
                baglanti.Open();
                cmd = new SqlCommand("INSERT INTO CariList(CariAdi,IlgiliKisi,TCno,Il,Iskonto,Tahsilat,Borc,Risk,Email,Fax,Telefon,VergiDa,VergiNo,ParaB,Adres) VALUES(@ad,@kisi,@tc,@il,@is,@alac,@verec,@r,@em,@fax,@tel,@vda,@vno,@pb,@adres)", baglanti);
                cmd.Parameters.Add("ad", txt_cariadi.Text);
                cmd.Parameters.Add("kisi", txt_ilgikisi.Text);
                cmd.Parameters.Add("tc", txt_TCno.Text);
                cmd.Parameters.Add("il", cmBox_İl.SelectedItem.ToString());
                cmd.Parameters.Add("is", Convert.ToDecimal(txt_iskonto.Text));
                cmd.Parameters.Add("alac", Convert.ToDecimal(txt_alacak.Text));
                cmd.Parameters.Add("verec", Convert.ToDecimal(txt_verecek.Text));
                cmd.Parameters.Add("r", Convert.ToDecimal(txt_risk.Text));
                cmd.Parameters.Add("em", txt_email.Text);
                cmd.Parameters.Add("fax", txt_fax.Text);
                cmd.Parameters.Add("tel", txt_tel.Text);
                cmd.Parameters.Add("vda", txt_vdairesi.Text);
                cmd.Parameters.Add("vno", txt_vergino.Text);
                cmd.Parameters.Add("pb", cmBox_Parabirimi.SelectedItem.ToString());
                cmd.Parameters.Add("adres", txt_adres.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cmd = new SqlCommand("INSERT INTO RehberList(KisiAdi,Telefon,Fax,Email,Adres) VALUES(@ka,@t,@f,@e,@a)", baglanti);
                cmd.Parameters.Add("ka", txt_ilgikisi.Text);
                cmd.Parameters.Add("t", txt_tel.Text);
                cmd.Parameters.Add("f", txt_fax.Text);
                cmd.Parameters.Add("e", txt_email.Text);
                cmd.Parameters.Add("a", txt_adres.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBoxEx.Show("     İşlem başarılı.     ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("    Eksik  veya  hatalı  veri  girişi!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CariSil(int index)
        {
            baglanti.Open();
            cmd = new SqlCommand("DELETE FROM CariList WHERE CariID=@i", baglanti);
            cmd.Parameters.Add("i", index);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglanti.Close();
        }

        public void RehberKaydet(DevComponents.DotNetBar.Controls.TextBoxX txt_Ad, DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_Tel, DevComponents.DotNetBar.Controls.TextBoxX txt_fax, DevComponents.DotNetBar.Controls.TextBoxX txt_email, DevComponents.DotNetBar.Controls.TextBoxX txt_web, RichTextBox txt_adres)
        {
            if (txt_Ad.Text != "" && txt_Tel.Text != "" && txt_email.Text != "")
            {
                baglanti.Open();
                cmd = new SqlCommand("INSERT INTO RehberList(KisiAdi,Telefon,Fax,Email,Web,Adres) VALUES(@KA,@Tel,@Fax,@mail,@Web,@Adres)", baglanti);
                cmd.Parameters.Add("KA", txt_Ad.Text);
                cmd.Parameters.Add("Tel", txt_Tel.Text);
                cmd.Parameters.Add("Fax", txt_fax.Text);
                cmd.Parameters.Add("mail", txt_email.Text);
                cmd.Parameters.Add("Web", txt_web.Text);
                cmd.Parameters.Add("Adres", txt_adres.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            else
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
                MessageBoxEx.Show("    Eksik  veya  hatalı  veri  girişi!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RehberSil(int secilen)
        {
            baglanti.Open();
            cmd = new SqlCommand("DELETE FROM RehberList WHERE KisiID=@id", baglanti);
            cmd.Parameters.Add("id", secilen);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            baglanti.Close();
        }

        public void RehberGuncelle(DevComponents.DotNetBar.Controls.TextBoxX txt_Ad, DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_Tel, DevComponents.DotNetBar.Controls.TextBoxX txt_fax, DevComponents.DotNetBar.Controls.TextBoxX txt_email, DevComponents.DotNetBar.Controls.TextBoxX txt_web, RichTextBox txt_adres, int id)
        {
            if (txt_Ad.Text != "" && txt_Tel.Text != "" && txt_email.Text != "")
            {
                baglanti.Open();
                cmd = new SqlCommand("UPDATE RehberList SET KisiAdi=@KA, Telefon=@Tel, Fax=@Fax, Email=@mail, Web=@Web, Adres=@Adres WHERE KisiID=@id", baglanti);
                cmd.Parameters.Add("KA", txt_Ad.Text);
                cmd.Parameters.Add("Tel", txt_Tel.Text);
                cmd.Parameters.Add("Fax", txt_fax.Text);
                cmd.Parameters.Add("mail", txt_email.Text);
                cmd.Parameters.Add("Web", txt_web.Text);
                cmd.Parameters.Add("Adres", txt_adres.Text);
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
            else
            {
                MessageBoxEx.EnableGlass = false;
                MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
                MessageBoxEx.Show("    Eksik  veya  hatalı  veri  girişi!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void CariLikeID(DevComponents.DotNetBar.Controls.TextBoxX txt_carikod, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Cari)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM CariList WHERE CariID=@id;", baglanti);
            adap.SelectCommand.Parameters.Add("id", txt_carikod.Text);
            DataSet ds = new DataSet();
            adap.Fill(ds, "CariSuzme");
            dGView_Cari.DataSource = ds.Tables["CariSuzme"];
            adap.Dispose();
            baglanti.Close();
        }

        public void CariLikeAdi(DevComponents.DotNetBar.Controls.TextBoxX txt_cariadi, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Cari)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM CariList WHERE CariAdi LIKE '" + txt_cariadi.Text +"%'", baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "CariSuzme");
            dGView_Cari.DataSource = ds.Tables["CariSuzme"];
            adap.Dispose();
            baglanti.Close();
        }

        public void CariLikeIL(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_İl, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Cari)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM CariList WHERE Il=@il;", baglanti);
            adap.SelectCommand.Parameters.Add("il", cmBox_İl.SelectedItem.ToString());
            DataSet ds = new DataSet();
            adap.Fill(ds, "CariSuzme");
            dGView_Cari.DataSource = ds.Tables["CariSuzme"];
            adap.Dispose();
            baglanti.Close();
        }

        public void CariGuncelle(DevComponents.DotNetBar.Controls.TextBoxX txt_cariadi, DevComponents.DotNetBar.Controls.TextBoxX txt_ilgikisi, DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_TCno, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_İl, DevComponents.DotNetBar.Controls.TextBoxX txt_iskonto, DevComponents.DotNetBar.Controls.TextBoxX txt_alacak, DevComponents.DotNetBar.Controls.TextBoxX txt_verecek, DevComponents.DotNetBar.Controls.TextBoxX txt_risk, DevComponents.DotNetBar.Controls.TextBoxX txt_email, DevComponents.DotNetBar.Controls.TextBoxX txt_fax, DevComponents.DotNetBar.Controls.MaskedTextBoxAdv txt_tel, DevComponents.DotNetBar.Controls.TextBoxX txt_vdairesi, DevComponents.DotNetBar.Controls.TextBoxX txt_vergino, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_Parabirimi, RichTextBox txt_adres, DevComponents.DotNetBar.LabelX lbl_id)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (txt_cariadi.Text != "" && txt_ilgikisi.Text != "" && txt_TCno.Text.Length == 11 && cmBox_İl.SelectedItem != null && txt_alacak.Text != "" && txt_verecek.Text != "" && txt_risk.Text != "" && txt_email.Text != "" && txt_tel.Text.Length == 14 && txt_vdairesi.Text != "" && txt_vergino.Text != "" && cmBox_Parabirimi.SelectedItem != null)
            {
                baglanti.Open();
                cmd = new SqlCommand("UPDATE CariList SET CariAdi=@ad, IlgiliKisi=@kisi, TCno=@tc, Il=@il, Iskonto=@is, Tahsilat=@alac, Borc=@verec, Risk=@r, Email=@em, Fax=@fax, Telefon=@tel, VergiDa=@vda, VergiNo=@vno, ParaB=@pb, Adres=@adres WHERE CariID=@id", baglanti);
                cmd.Parameters.Add("id", lbl_id.Text);
                cmd.Parameters.Add("ad", txt_cariadi.Text);
                cmd.Parameters.Add("kisi", txt_ilgikisi.Text);
                cmd.Parameters.Add("tc", txt_TCno.Text);
                cmd.Parameters.Add("il", cmBox_İl.SelectedItem.ToString());
                cmd.Parameters.Add("is", Convert.ToDecimal(txt_iskonto.Text));
                cmd.Parameters.Add("alac", Convert.ToDecimal(txt_alacak.Text));
                cmd.Parameters.Add("verec", Convert.ToDecimal(txt_verecek.Text));
                cmd.Parameters.Add("r", Convert.ToDecimal(txt_risk.Text));
                cmd.Parameters.Add("em", txt_email.Text);
                cmd.Parameters.Add("fax", txt_fax.Text);
                cmd.Parameters.Add("tel", txt_tel.Text);
                cmd.Parameters.Add("vda", txt_vdairesi.Text);
                cmd.Parameters.Add("vno", Convert.ToInt32(txt_vergino.Text));
                cmd.Parameters.Add("pb", cmBox_Parabirimi.SelectedItem.ToString());
                cmd.Parameters.Add("adres", txt_adres.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBoxEx.Show("     İşlem başarılı.     ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("    Eksik  veya  hatalı  veri  girişi!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Birimdoldur(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_Parabirimi)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT Paraadi FROM ParaTipi", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmBox_Parabirimi.Items.Add(oku["Paraadi"]);
            }
            oku.Close();
            cmd.Dispose();
            baglanti.Close();
        }


        public void ExceleAktar(DevComponents.DotNetBar.Controls.DataGridViewX dGView_Info)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;

            for (int j = 0; j < dGView_Info.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dGView_Info.Columns[j].HeaderText;
            }

            StartRow++;

            for (int i = 0; i < dGView_Info.Rows.Count; i++)
            {
                for (int j = 0; j < dGView_Info.Columns.Count; j++)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dGView_Info[j, i].Value == null ? "" : dGView_Info[j, i].Value;
                    }
                    catch
                    {
                        ;
                    }
                }
            }
        }

        public void StokBoxDoldur(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_StokGrup, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AraSGrup)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT StokAdi FROM StokGrup", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmBox_StokGrup.Items.Add(oku["StokAdi"]);
                cmBox_AraSGrup.Items.Add(oku["StokAdi"]);
            }
            oku.Close();
            cmd.Dispose();
            baglanti.Close();
        }

        public void AltBoxDoldur(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AltGrup, int index)
        {
            cmBox_AltGrup.SelectedItem = null;
            cmBox_AltGrup.Items.Clear();
            baglanti.Open();
            cmd = new SqlCommand("SELECT Urungrubu FROM AltGrup WHERE UstID=@id", baglanti);
            cmd.Parameters.Add("id", index + 1);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmBox_AltGrup.Items.Add(oku["Urungrubu"]);
            }
            oku.Close();
            cmd.Dispose();
            baglanti.Close();
        }

        public void StokKaydet(DevComponents.DotNetBar.Controls.TextBoxX txt_stokadi, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_StokGrup, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AltGrup, DevComponents.DotNetBar.Controls.TextBoxX txt_AlisF, DevComponents.DotNetBar.Controls.TextBoxX txt_adet, DevComponents.DotNetBar.Controls.TextBoxX txt_SatisF, DevComponents.DotNetBar.Controls.TextBoxX txt_KDVdahil, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_KDV, DevComponents.DotNetBar.Controls.TextBoxX txt_OzelKod, DevComponents.DotNetBar.Controls.TextBoxX txt_OrjKod, DevComponents.DotNetBar.Controls.TextBoxX txt_Barkod)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (txt_stokadi.Text != "" && cmBox_StokGrup.SelectedItem != null && cmBox_AltGrup.SelectedItem != null && txt_AlisF.Text != "" && txt_adet.Text != "" && txt_SatisF.Text != "" && txt_KDVdahil.Text != "" && cmBox_KDV.SelectedItem != null && txt_OrjKod.Text.Length == 13 && txt_Barkod.Text.Length == 13)
            {
                baglanti.Open();
                cmd = new SqlCommand("INSERT INTO StokList(StokAdi, StokGrup, AltGrup, AlisFiyati, Adet, SatisFiyati, KDVli_Fiyat, KDV, OzelKod, OrjKod, Barkod) VALUES(@ad, @ugrup, @agrup, @afiyat, @adet, @sfiyat, @kdvliF, @kdv, @ozel, @orj, @bar)", baglanti);
                cmd.Parameters.Add("ad", txt_stokadi.Text);
                cmd.Parameters.Add("ugrup",cmBox_StokGrup.SelectedItem.ToString());
                cmd.Parameters.Add("agrup",cmBox_AltGrup.SelectedItem.ToString());
                cmd.Parameters.Add("afiyat",Convert.ToDecimal(txt_AlisF.Text));
                cmd.Parameters.Add("adet",Convert.ToInt32(txt_adet.Text));
                cmd.Parameters.Add("sfiyat",Convert.ToDecimal(txt_SatisF.Text));
                cmd.Parameters.Add("kdvliF",Convert.ToDecimal(txt_KDVdahil.Text));
                cmd.Parameters.Add("kdv",cmBox_KDV.SelectedItem.ToString());
                cmd.Parameters.Add("ozel",txt_OzelKod.Text);
                cmd.Parameters.Add("orj",txt_OrjKod.Text);
                cmd.Parameters.Add("bar",txt_Barkod.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBoxEx.Show("    Kayıt işlemi başarılı.    ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("   Eksik veya boş değer girdiniz!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        public void KDVgoster(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_KDV)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT Deger FROM KDV", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmBox_KDV.Items.Add(oku["Deger"]);
            }
            oku.Close();
            cmd.Dispose();
            baglanti.Close();
        }

        public void StokGoster(DevComponents.DotNetBar.Controls.DataGridViewX dGView_Stok)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM StokList", baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Bilgiler");
            dGView_Stok.DataSource = ds.Tables["Bilgiler"];
            adap.Dispose();
            baglanti.Close();
        }

        public void StokSil(int id)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (MessageBoxEx.Show("   Silmek istediğinizden emin misiniz?   ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                baglanti.Open();
                cmd = new SqlCommand("DELETE FROM StokList Where StokID=@id", baglanti);
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
        }

        public void StokGuncelle(DevComponents.DotNetBar.Controls.TextBoxX txt_stokadi, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_StokGrup, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AltGrup, DevComponents.DotNetBar.Controls.TextBoxX txt_AlisF, DevComponents.DotNetBar.Controls.TextBoxX txt_adet, DevComponents.DotNetBar.Controls.TextBoxX txt_SatisF, DevComponents.DotNetBar.Controls.TextBoxX txt_KDVdahil, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_KDV, DevComponents.DotNetBar.Controls.TextBoxX txt_OzelKod, DevComponents.DotNetBar.Controls.TextBoxX txt_OrjKod, DevComponents.DotNetBar.Controls.TextBoxX txt_Barkod, int x)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (txt_stokadi.Text != "" && cmBox_StokGrup.SelectedItem != null && cmBox_AltGrup.SelectedItem != null && txt_AlisF.Text != "" && txt_adet.Text != "" && txt_SatisF.Text != "" && txt_KDVdahil.Text != "" && cmBox_KDV.SelectedItem != null && txt_OrjKod.Text.Length == 13 && txt_Barkod.Text.Length == 13)
            {
                baglanti.Open();
                cmd = new SqlCommand("UPDATE StokList SET StokAdi=@ad, StokGrup=@ugrup, AltGrup=@agrup, AlisFiyati=@afiyat, Adet=@adet, SatisFiyati=@sfiyat, KDVli_Fiyat=@kdvliF, KDV=@kdv, OzelKod=@ozel, OrjKod=@orj, Barkod=@bar WHERE StokID=@id", baglanti);
                cmd.Parameters.Add("ad", txt_stokadi.Text);
                cmd.Parameters.Add("ugrup", cmBox_StokGrup.SelectedItem.ToString());
                cmd.Parameters.Add("agrup", cmBox_AltGrup.SelectedItem.ToString());
                cmd.Parameters.Add("afiyat", Convert.ToDecimal(txt_AlisF.Text));
                cmd.Parameters.Add("adet", Convert.ToInt32(txt_adet.Text));
                cmd.Parameters.Add("sfiyat", Convert.ToDecimal(txt_SatisF.Text));
                cmd.Parameters.Add("kdvliF", Convert.ToDecimal(txt_KDVdahil.Text));
                cmd.Parameters.Add("kdv", cmBox_KDV.SelectedItem.ToString());
                cmd.Parameters.Add("ozel", txt_OzelKod.Text);
                cmd.Parameters.Add("orj", txt_OrjKod.Text);
                cmd.Parameters.Add("bar", txt_Barkod.Text);
                cmd.Parameters.Add("id", x);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBoxEx.Show("    Güncelleme işlemi başarılı.    ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("   Eksik veya boş değer girdiniz!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void StokAdiGetir(DevComponents.DotNetBar.Controls.TextBoxX txt_AraSA, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Stok)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM Stoklist WHERE StokAdi LIKE '" + txt_AraSA.Text + "%'", baglanti);
            DataTable dt = new DataTable("Bilgiler");
            adap.Fill(dt);
            dGView_Stok.DataSource = dt;
            adap.Dispose();
            baglanti.Close();
        }



        public void StokGrupGoster(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AraSGrup, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Stok)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM StokList WHERE StokGrup=@SG;", baglanti);
            adap.SelectCommand.Parameters.Add("SG", cmBox_AraSGrup.SelectedItem.ToString());
            DataSet ds = new DataSet();
            adap.Fill(ds, "CariSuzme");
            dGView_Stok.DataSource = ds.Tables["CariSuzme"];
            adap.Dispose();
            baglanti.Close();
        }

        public void StokAltGoster(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AraAGrup, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Stok)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM StokList WHERE AltGrup=@AG;", baglanti);
            adap.SelectCommand.Parameters.Add("AG", cmBox_AraAGrup.SelectedItem.ToString());
            DataSet ds = new DataSet();
            adap.Fill(ds, "CariSuzme");
            dGView_Stok.DataSource = ds.Tables["CariSuzme"];
            adap.Dispose();
            baglanti.Close();
        }

        public void StokAltDoldur(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_AraAGrup)
        {
            baglanti.Open();
            cmd = new SqlCommand("SELECT Urungrubu FROM AltGrup", baglanti);
            SqlDataReader oku = cmd.ExecuteReader();
            while (oku.Read())
            {
                cmBox_AraAGrup.Items.Add(oku["Urungrubu"]);
            }
            oku.Close();
            cmd.Dispose();
            baglanti.Close();
        }

        public void KasaGoster(DevComponents.DotNetBar.Controls.DataGridViewX dGView_Kasa)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM KasaList", baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Veriler");
            dGView_Kasa.DataSource = ds.Tables["Veriler"];
            adap.Dispose();
            baglanti.Close();
        }

        public void KasaKaydet(DevComponents.DotNetBar.Controls.TextBoxX txt_KasaAdi, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_ParaBirim, DevComponents.DotNetBar.Controls.TextBoxX txt_Tbakiye, RichTextBox txt_Notlar, DateTimePicker dTP_gTarihi)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (txt_KasaAdi.Text != "" && cmBox_ParaBirim.SelectedItem != null && dTP_gTarihi.Value != null && txt_Tbakiye.Text != "")
            {
                baglanti.Open();
                cmd = new SqlCommand("INSERT INTO KasaList(KasaAdi, ParaBirimi, GirisTarihi, TBakiye, Notlar) VALUES(@ad, @PB, @GT, @TopB, @Not)", baglanti);
                cmd.Parameters.Add("ad",txt_KasaAdi.Text);
                cmd.Parameters.Add("PB",cmBox_ParaBirim.SelectedItem.ToString());
                cmd.Parameters.Add("GT", dTP_gTarihi.Value.Date.ToLongDateString());
                cmd.Parameters.Add("TopB",Convert.ToDecimal(txt_Tbakiye.Text));
                cmd.Parameters.Add("Not",txt_Notlar.Text);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBoxEx.Show("    Kayıt Başarılı.    ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("    Eksik veya hatalı veri girişi!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void KasaSil(int id, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Kasa)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (MessageBoxEx.Show("   Silmek istediğinizden emin misiniz?   ", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                baglanti.Open();
                cmd = new SqlCommand("DELETE FROM KasaList WHERE KasaID=@id", baglanti);
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
            }
        }

        public void KasaGuncelle(DevComponents.DotNetBar.Controls.TextBoxX txt_KasaAdi, DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_ParaBirim, DevComponents.DotNetBar.Controls.TextBoxX txt_Tbakiye, RichTextBox txt_Notlar, DateTimePicker dTP_gTarihi, int id)
        {
            MessageBoxEx.EnableGlass = false;
            MessageBoxEx.MessageBoxTextColor = System.Drawing.Color.Black;
            if (txt_KasaAdi.Text != "" && cmBox_ParaBirim.SelectedItem != null && dTP_gTarihi.Value != null && txt_Tbakiye.Text != "")
            {
                baglanti.Open();
                cmd = new SqlCommand("UPDATE KasaList SET KasaAdi=@ad, ParaBirimi=@PB, GirisTarihi=@GT, TBakiye=@TopB, Notlar=@Not WHERE KasaID=@id", baglanti);
                cmd.Parameters.Add("ad", txt_KasaAdi.Text);
                cmd.Parameters.Add("PB", cmBox_ParaBirim.SelectedItem.ToString());
                cmd.Parameters.Add("GT", dTP_gTarihi.Value.Date.ToLongDateString());
                cmd.Parameters.Add("TopB", Convert.ToDecimal(txt_Tbakiye.Text));
                cmd.Parameters.Add("Not", txt_Notlar.Text);
                cmd.Parameters.Add("id", id);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                baglanti.Close();
                MessageBoxEx.Show("    Güncelleme başarılı.    ", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBoxEx.Show("    Eksik veya hatalı veri girişi!    ", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void KasaAdiAra(DevComponents.DotNetBar.Controls.TextBoxX txt_araKadi, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Kasa)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM KasaList WHERE KasaAdi LIKE '" + txt_araKadi.Text + "%'", baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Veriler");
            dGView_Kasa.DataSource = ds.Tables["Veriler"];
            adap.Dispose();
            baglanti.Close();
        }

        public void KasaParaGoster(DevComponents.DotNetBar.Controls.ComboBoxEx cmBox_araPbirim, DevComponents.DotNetBar.Controls.DataGridViewX dGView_Kasa)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM KasaList WHERE ParaBirimi=@PB", baglanti);
            adap.SelectCommand.Parameters.Add("PB", cmBox_araPbirim.SelectedItem.ToString());
            DataSet ds = new DataSet();
            adap.Fill(ds, "Veriler2");
            dGView_Kasa.DataSource = ds.Tables["Veriler2"];
            adap.Dispose();
            baglanti.Close();
        }

        public void FaturaGoster(DevComponents.DotNetBar.Controls.DataGridViewX dGView_Fatura)
        {
            baglanti.Open();
            adap = new SqlDataAdapter("SELECT * FROM FaturaList", baglanti);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Veriler");
            dGView_Fatura.DataSource = ds.Tables["Veriler"];
            adap.Dispose();
            baglanti.Close();
        }
    }
}
