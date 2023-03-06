using Otel.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel.UI
{
    public partial class FrmOtelRapor : Form
    {
        private List<Minibar> minibars;
        private List<Musteri> musteriler = new List<Musteri>();

        public FrmOtelRapor()
        {
            InitializeComponent();
        }

        public FrmOtelRapor(List<Minibar> minibars, List<Musteri> musteriler) : this()
        {
            this.minibars = minibars;
            this.musteriler = musteriler;

        }


        private void RefreshListView(List<Musteri> musteriler)
        {
            listViewRapor.Items.Clear();
            int count = 1;
            foreach (Musteri item in musteriler)
            {
                ListViewItem l = new ListViewItem();
                l.Text = (count++).ToString(); 
                l.SubItems.Add(item.NameSurname); 
                l.SubItems.Add((item.KalacakGunSayisi).ToString()); 
                l.SubItems.Add(item.OdaBilgisi?.OdaNumarasi.ToString() ?? ""); 
                l.SubItems.Add(item.OdaBilgisi?.OdaFiyat.ToString() ?? ""); // ListView'daki beşinci sütun, müşterinin oda fiyatını gösterir (oda bilgisi varsa).
                l.Tag = item;
                listViewRapor.Items.Add(l);
            }
        }

        private void FrmOtelRapor_Load(object sender, EventArgs e)
        {
            cmbBul.DataSource = musteriler; // ComboBox, müşteri listesini görüntülemek için veri kaynağı olarak kullanılır.
            RefreshListView(musteriler); 
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Musteri secilenMusteri = cmbBul.SelectedItem as Musteri;

            if (secilenMusteri != null)
            {
                // ComboBox'ta seçilen müşterinin adı ve soyadıyla eşleşen müşterilerin listesi oluşturulur.
                List<Musteri> filteredMusteriler = musteriler.Where(m => m.NameSurname == secilenMusteri.NameSurname).ToList();
                RefreshListView(filteredMusteriler); 
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranilanIsim = txtMusteriAra.Text;

         
            List<Musteri> filteredMusteriler = musteriler.Where(m => m.NameSurname == aranilanIsim).ToList();
            RefreshListView(filteredMusteriler); 
        }


    }
}
