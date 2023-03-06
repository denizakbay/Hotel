using Otel.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.UI
{
    public partial class FrmOtelGiris : Form
    {
        public FrmOtelGiris()
        {
            InitializeComponent();
        }
        List<Musteri> musteriler = new List<Musteri>();
      
        private void Form1_Load(object sender, EventArgs e)
        {
            #region fllp
            //int count = 99;
            //for (int i = 0; i < 10; i++)
            //{
            //    flKat1.Controls.Add(new Button()
            //    {
            //        Text = (++count).ToString(),
            //        BackColor = Color.Yellow,
            //        Tag = null,

            //    });

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    flKat2.Controls.Add(new Button()
            //    {
            //        Text = (++count).ToString(),
            //        BackColor = Color.Yellow,
            //        Tag = null
            //    });

            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    flKat3.Controls.Add(new Button()
            //    {
            //        Text = (++count).ToString(),
            //        BackColor = Color.Yellow,
            //        Tag = null
            //    });

            //}
            //flKat4.Controls.Add(new Button()
            //{
            //    Text = "Kral Dairesi",
            //    BackColor = Color.Yellow,
            //    Tag = null,
            //    Width = 400,
            //    Height = 60

            //});
            #endregion

            #region Not
            /*
             
            i.ToString() ifadesi, Find yöntemi için aranan denetim adını oluşturmak için kullanılır.Bu ifade, i değişkeninin değerini bir dizeye dönüştürür. 
            Daha sonra, "flKat" dize ifadesi ile birleştirilerek, formda "flKat1", "flKat2", "flKat3" ve "flKat4" olarak adlandırılmış dört FlowLayoutPanel denetiminden birinin adını oluşturur.
            Örneğin, i 2 ise, "flKat" ve "2" dize ifadeleri birleştirilerek, "flKat2" adı oluşturulur ve bu adla eşleşen FlowLayoutPanel denetimi aranır. Bu şekilde, döngü her bir FlowLayoutPanel 
            için doğru denetim adını oluşturarak, her katın butonlarının eklenmesini sağlar. */
            #endregion


            flKat4.Controls.Add(new Button()
            {
                Text = "Kral Dairesi",
                BackColor = Color.Green,
                Tag = new OdaRezervasyon()
                {

                    Oda = new Oda()
                    {
                        OdaFiyat = 300,
                        OdaDurumu = OdaDurumu.Bos,
                        OdaNumarasi = 130
                    },
                },
                Width = 400,
                Height = 60


            });
            foreach (Button button in flKat4.Controls)
            {
                button.Click += KralDairesi_Click;
            }

            int count = 99;
            for (int i = 1; i <= 3; i++)
            {
                FlowLayoutPanel currentFlKat = (FlowLayoutPanel)this.Controls.Find("flKat" + i.ToString(), true)[0];
                for (int j = 1; j <= 10; j++)
                {

                    Button btn = new Button()
                    {
                        Text = (++count).ToString(),
                        BackColor = Color.Green,
                        Tag = new OdaRezervasyon()
                        {
                            Oda = new Oda()
                            {
                                OdaFiyat = 100,
                                OdaDurumu = OdaDurumu.Bos,
                                OdaNumarasi = count
                            }
                            
                        }
                    };

                    //olay yakalayıcı event prodesürü oluşturur.
                    btn.Click += Oda_Click; 
                    currentFlKat.Controls.Add(btn);
                }

            }

        }

        Button clickButton = null;
        private void KralDairesi_Click(object sender, EventArgs e)
        {
            clickButton = sender as Button;
            OdaRezervasyon rezervasyon = clickButton.Tag as OdaRezervasyon;
            MessageBox.Show(clickButton.Text + " Seçildi ");

        }
        /// <summary>
        /// sender tıkladıgın buton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Oda_Click(object sender, EventArgs e) 
        {
            //Tagında rezervasyonun odasının odadurumuna göre datayı söylesin demek oluyor.

            clickButton = sender as Button;
            OdaRezervasyon rezervasyon = clickButton.Tag as OdaRezervasyon;        

            MessageBox.Show(clickButton.Text + " Seçildi ");

        }


        private void btnEkle_Click(object sender, EventArgs e)
        {
            //TODO: Dolu ise yeni ekleme yapılmamalı

            // tıklanılan butonun odarezindeki özellikleri al.
            OdaRezervasyon odarezervasyon = clickButton.Tag as OdaRezervasyon;

            if (odarezervasyon.Oda.OdaDurumu == OdaDurumu.Bos)
            {
                odarezervasyon.Musteri = new Musteri()
                {
                    NameSurname = txtAdSoyad.Text,
                    TC = txtTc.Text,
                    DateOfBirth = txtDgmtrh.Text,
                    PhoneNumber = txtTel.Text,
                    KalacakGunSayisi = Convert.ToInt32(nmrcKalacakGun.Value)
                };

                odarezervasyon.Oda.OdaDurumu = OdaDurumu.Dolu;
                odarezervasyon.Oda.OdaFiyat.ToString();              
                odarezervasyon.Musteri.OdaBilgisi = odarezervasyon.Oda;
               // odarezervasyon.Musteri.MinibarBilgisi = odarezervasyon.Minibar;

                musteriler.Add(odarezervasyon.Musteri);
                labelToplam.Text = Convert.ToString(odarezervasyon.Oda.OdaFiyat * odarezervasyon.Musteri.KalacakGunSayisi);

                // tıklandıgında müşteri girilip eklendiğinde tıklanılan buton kırmızıya dönecek.
                clickButton.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Seçilen Oda Dolu");
            }
        }

        private void btnGec_Click_1(object sender, EventArgs e)
        {



            if (musteriler.Count == 0)
            {
                MessageBox.Show("data girmeden diğer forma geçiş yapamazsınız.. ");
            }
            else
            {
                FrmMinibar frmminibar = new FrmMinibar(musteriler);
                frmminibar.Show();
            }
        }
    }
}

