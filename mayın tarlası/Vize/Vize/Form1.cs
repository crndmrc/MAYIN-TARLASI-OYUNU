using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows.Forms;

namespace Vize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tlp_butonlar.Visible = false;
            tmr_sure.Enabled = false;
            tmr_sure.Stop();
            nmrc_mayin_sayisi.Hexadecimal = false;
            nmrc_sure.Hexadecimal = false;
        }

        int sayac = 0;
        int acilis = 0;
        int basarilisayac = 0;
        int mayinsayisi = 0;
        ArrayList mayinlar = new ArrayList();
        Random rastgele = new Random();
        Onizleme onizleme = new Onizleme();


        int[] TumButonlar = new int[25];
        int[] TumButonlarOnizleme = new int[25];

        private void btn_basla_Click(object sender, EventArgs e)
        {
            if (acilis != 0)
            {
                DialogResult cikis = new DialogResult();
                cikis = MessageBox.Show("Yeni Oyun Başlatmak İstediğinizden Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (cikis == DialogResult.Yes)
                {
                  
                    YeniOyunBaslat();
                }
                if (cikis == DialogResult.No)
                {
                    MessageBox.Show("Mevcut Oyun Devam Ediyor.");
                }
            }
            else
            {
                YeniOyunBaslat();
            }

        }




        private void komsumayinhesapla(int index)
        {

            int solust, ust, sagust, sol, sag, solalt, alt, sagalt;

            solust = index - 6;
            ust = index - 1;
            sagust = index + 4;
            sol = index - 5;
            sag = index + 5;
            solalt = index - 4;
            alt = index + 1;
            sagalt = index + 6;


            ArrayList komsular = new ArrayList();
            komsular.Clear();
            if (index == 0)
            {
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sagalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 1)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sagalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 2)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sagalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 3)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sagalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 4)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[sag]);
            }
            if (index == 5)
            {
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[sagalt]);
                komsular.Add(TumButonlar[sag]);
            }
            if (index == 6)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 7)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 8)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 9)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
            }
            if (index == 10)
            {
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[sagalt]);
                komsular.Add(TumButonlar[sag]);
            }
            if (index == 11)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 12)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 13)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 14)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
            }
            if (index == 15)
            {
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[sagalt]);
                komsular.Add(TumButonlar[sag]);
            }
            if (index == 16)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 17)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 18)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[alt]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[sagalt]);
            }
            if (index == 19)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[sagust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sag]);
                komsular.Add(TumButonlar[sol]);
            }
            if (index == 20)
            {
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 21)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 22)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 23)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sol]);
                komsular.Add(TumButonlar[solalt]);
                komsular.Add(TumButonlar[alt]);
            }
            if (index == 24)
            {
                komsular.Add(TumButonlar[ust]);
                komsular.Add(TumButonlar[solust]);
                komsular.Add(TumButonlar[sol]);
            }

            int sayac = 0;

     
            foreach (int i in komsular)
            {
                if ( ( i) < 0 )
                {
                    sayac += 1;
                }

            }

            mayinsayisi = sayac;          
 


        }




        private void button_Click(object sender, EventArgs e)
        {
 
            Button tiklanan = (Button)sender;

            if (tiklanan.Text == "")
            {
                sayac = 0;
                int tiklananbutonindex;
                tiklananbutonindex = Array.IndexOf(TumButonlar, tiklanan.Tag);
                komsumayinhesapla(tiklananbutonindex);
                tiklanan.Text = mayinsayisi.ToString();
                if (int.Parse(tiklanan.Tag.ToString()) <0 )
                {
                    tmr_sure.Enabled = false;
                    tmr_sure.Stop();
                    sayac = 0;
                    tiklanan.BackColor = Color.Red;
                    for (int i = 0; i < tlp_butonlar.Controls.Count; i++)
                    {
                        if (int.Parse(tlp_butonlar.Controls[i].Tag.ToString()) <0 )
                        {
                            tlp_butonlar.Controls[i].Enabled = false;
                            tlp_butonlar.Controls[i].BackColor = Color.Red;

                        }
                        else
                        {
                            tlp_butonlar.Controls[i].BackColor = Color.Green;
                        }

                    }
                    MessageBox.Show("Oyun Bitti.");

                }
                else
                {
                    tiklanan.BackColor = Color.Green;
                    basarilisayac++;

                    if (25 - (Math.Round(double.Parse(nmrc_mayin_sayisi.Value.ToString()), MidpointRounding.AwayFromZero)) == basarilisayac)
                    {
                        tmr_sure.Enabled = false;
                        tmr_sure.Stop();
                        sayac = 0;
                        MessageBox.Show("Tebrikler Kazandınız.");
                    }
                }
            }
        }

        private void OnizlemeDoldur()
        {


            for (int i = 0; i < onizleme.tlp_onizleme_butonlar.Controls.Count; i++)
            {
                if (int.Parse(onizleme.tlp_onizleme_butonlar.Controls[i].Tag.ToString()) < 0 )
                {
                    onizleme.tlp_onizleme_butonlar.Controls[i].Enabled = false;
                    onizleme.tlp_onizleme_butonlar.Controls[i].BackColor = Color.Red;
                }
                else
                {
                    onizleme.tlp_onizleme_butonlar.Controls[i].BackColor = Color.Green;
                }

            }
 
        }






        private void YeniOyunBaslat()
        {
            
            

            Array.Clear(TumButonlar, 24, 1);
            basarilisayac = 0;
            Double mayinsayisi = Math.Round(double.Parse(nmrc_mayin_sayisi.Value.ToString()));
            Double sure = Math.Round(double.Parse(nmrc_sure.Value.ToString()));

            if (sure < 1)
            {
                MessageBox.Show("Seçilen Süre Minumum 1sn Ve Üstü Olmalıdır.");
            }
            else
            {

                if (mayinsayisi > 24 || mayinsayisi < 1)
                {
                    MessageBox.Show("Seçilen Mayın Sayısı [1-24] Aralığında Olmalıdır.");
                }
                else
                {
                    onizleme.tlp_onizleme_butonlar.Controls.Clear();
                    tlp_butonlar.Controls.Clear();
                    tmr_sure.Enabled = true;
                    tmr_sure.Start();
                    grp_butunlar.Visible = false;
                    tlp_butonlar.Visible = true;
                    mayinlar.Clear();
                    int oMayin;
                    oMayin = int.Parse(mayinsayisi.ToString());

                    Random rast = new Random();
                    int sayi = 0;
                    for (int i = 0; i < oMayin; i++)
                    {
                    uret:
                        sayi = rast.Next(0, 25);
                        if (mayinlar.Contains(sayi))
                        {
                            goto uret;
                        }
                        else
                        {
                            mayinlar.Add(sayi);
                        }
                    }
                    for (int i = 0; i < 25; i++)
                    {
                        Button button = new Button();
                        button.Size = new Size(50, 50);
                        button.BackColor = Color.Gray;
                        if (mayinlar.Contains(i))
                        {
                            button.Tag =  -1 ;
                        }
                        else
                        {
                            button.Tag = rast.Next(1, 20);
                        }
                        button.Click += button_Click;
                        tlp_butonlar.Controls.Add(button);

                    }
                    for (int i = 0; i < 25; i++)
                    {
                        Button button = new Button();
                        button.Size = new Size(50, 50);
                        if (mayinlar.Contains(i))
                        {
                            button.Tag =  -1 ;
                        }
                        else
                        {
                            button.Tag = rast.Next(1, 20);
                        }
                        button.Click += button_Click;
                        onizleme.tlp_onizleme_butonlar.Controls.Add(button);

                    }
                    OnizlemeDoldur();
                    onizleme.Show();
                    acilis = 1;

                    for (int i = 0; i < 25;)
                    {
                        for (int a = 0; a < 5; a++)
                        {

                            for (int b = 0; b < 5; b++)
                            {
                                if (int.Parse(tlp_butonlar.GetControlFromPosition(a, b).Tag.ToString()) < 0)
                                {
                                    tlp_butonlar.GetControlFromPosition(a, b).Tag = rast.Next(25, 50) * -1;
                                }
                                i++;
                            }


                        }

                    }

                    for (int i = 0; i < 25;)
                    {
                        for (int a = 0; a < 5; a++)
                        {

                            for (int b = 0; b < 5; b++)
                            {
                                if (int.Parse(tlp_butonlar.GetControlFromPosition(a, b).Tag.ToString()) >= 0)
                                {
                                    tlp_butonlar.GetControlFromPosition(a, b).Tag = rast.Next(25, 100) ;
                                }
                                i++;
                            }


                        }

                    }

                    for (int i = 0; i < 25;)
                    {
                        for (int a = 0; a < 5; a++)
                        {

                            for (int b = 0; b < 5; b++)
                            {
                                TumButonlar[i] = int.Parse(tlp_butonlar.GetControlFromPosition(a, b).Tag.ToString());
                                i++;
                            }
                        

                        }

                    }
                    for (int i = 0; i < 25;)
                    {
                        for (int a = 0; a < 5; a++)
                        {

                            for (int b = 0; b < 5; b++)
                            {
                                TumButonlarOnizleme [i] = int.Parse(onizleme.tlp_onizleme_butonlar.GetControlFromPosition(a, b).Tag.ToString());
                                i++;
                            }


                        }

                    }
                }
            }
           
        }





        private void tmr_sure_Tick(object sender, EventArgs e)
        {
            sayac++;

            if (sayac == Math.Round(double.Parse(nmrc_sure.Value.ToString()), MidpointRounding.AwayFromZero))
            {
                tmr_sure.Enabled = false;
                tmr_sure.Stop();
                sayac = 0;
                lbl_kalan_sure.Text = "Kalan Süre = 0 ";
                MessageBox.Show("Süre Bitti.");
            }
            else
            {

                lbl_kalan_sure.Text = "Kalan Süre = " + (Math.Round(double.Parse(nmrc_sure.Value.ToString()), MidpointRounding.AwayFromZero) - int.Parse(sayac.ToString()));
            }

        }



        private void btn_bul_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_alt_sinir.Text) || String.IsNullOrEmpty(txt_ust_sinir.Text))
            {
                 MessageBox.Show("Lütfen Alt ve Üst Sınır Değerleri Giriniz");
            }
            else
            {
                if (int.Parse(txt_alt_sinir.Text) > int.Parse(txt_ust_sinir.Text) || int.Parse(txt_alt_sinir.Text) == int.Parse(txt_ust_sinir.Text))
                {
                    MessageBox.Show("Üst Sınır Alt Sınırdan Küçük Yada Eşit Değer Olamaz");
                }
                else
                {
                    list_sayilar.Items.Clear();
                    for (int i = int.Parse(txt_alt_sinir.Text); i < int.Parse(txt_ust_sinir.Text); i++)
                    {
                        if (armstronghesapla(i))
                            list_sayilar.Items.Add(i.ToString());

                    }

                    
                }
            }
        }


        static bool armstronghesapla(int x)
        {
            int parametre1 = 0;
            int parametre2 = x;
            int parametre3 = 0;
            int parametre4 = x.ToString().Length;

            while (x != 0)
            {
                parametre3 = x % 10;
                x = x / 10;
                parametre1 += (int)Math.Pow(parametre3, parametre4);
            }

            if (parametre1 == parametre2)
                return true;
            else
                return false;
        }

        private void txt_alt_sinir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_ust_sinir_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

    }

}






