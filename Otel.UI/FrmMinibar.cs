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
    public partial class FrmMinibar : Form
    {
        private List<Musteri> musteriler;

        public FrmMinibar(List<Common.Musteri> tumMusteriler)
        {
            InitializeComponent();
            this.musteriler = tumMusteriler;
        }

        List<Minibar> minibars = new List<Minibar>();

        private void FrmMinibar_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Enabled = false;
            foreach (Musteri item in this.musteriler)
            {
                cmbAdSoyad.Items.Add(item);
            }

            string[] malzemeAdlari = { "ayran", "cips", " su", "kola", "soda", "kek", "meyve" };
            int[] malzemeFiyatlari = { 8, 25, 3, 10, 8, 30, 25 };

            for (int i = 0; i < malzemeAdlari.Length; i++)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = malzemeAdlari[i];
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBox.Tag = new Minibar()
                {
                    MalzemeAdi = malzemeAdlari[i],
                    MalzemeFiyati = malzemeFiyatlari[i],
                };
                flowLayoutPanel1.Controls.Add(checkBox);
            }




        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Seçilen CheckBox kontrolü alınır
            CheckBox selectedCheckBox = (CheckBox)sender;

            // CheckBox'a bağlı Minibar nesnesi alınır
            Minibar minibar = (Minibar)selectedCheckBox.Tag;

            // Seçim değiştiği için daha önce eklenmişse listeden kaldırılır, eklenmemişse listede kalır
            if (selectedCheckBox.Checked)
            {
                // Seçili CheckBox işaretlendi, toplam fiyata ekle
                selectedCheckBox.Text = minibar.MalzemeAdi + " - " + minibar.MalzemeFiyati + " TL";
                minibars.Add(minibar);
            }
            else
            {
                // Seçili CheckBox işareti kaldırıldı, toplam fiyattan çıkar
                selectedCheckBox.Text = minibar.MalzemeAdi;
                minibars.Remove(minibar);
            }

        }


        private void radioButtonEvet_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEvet.Checked)
            {
                flowLayoutPanel1.Enabled = true;
            }
        }

        int toplam = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            // Toplam fiyat hesaplanır
            int adet = (int)nmrCount.Value;
            toplam = 0;
            foreach (Minibar item in minibars)
            {
                toplam += item.MalzemeFiyati * adet;
            }
            lblToplam.Text = toplam.ToString();

        }

        private void btnCikisaGec_Click(object sender, EventArgs e)
        {
            FrmOtelRapor frmOtelRapor = new FrmOtelRapor(minibars, musteriler);
            frmOtelRapor.Show();
        }
    }
}
