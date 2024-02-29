using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Uygulama_1
{
    public partial class randevuTakip : Form
    {
        public randevuTakip()
        {
            InitializeComponent();
        }
        Randevu randevu;
        BindingList<Randevu> list = new BindingList<Randevu>();

        private async void randevuTakip_Load(object sender, EventArgs e)
        {
          
            //Poliklinikleri ComboBox'a...

            String[] Poliklinikler = {"Cildiye","Dahiliye","Endokrinoloji","Enfeksiyon Hastalıkları","Fizik Tedavi",
                "Gastroenteroloji","Genel Cerrahi","Göz Hastalıkları","Hematoloji","Kadın Hastalıkları ve Doğum",
                "Kardiyoloji","Kulak Burun Boğaz","Nöroloji","Onkoloji","Ortopedi","Plastik Cerrahi","Psikiyatri",
                "Radyoloji","Üroloji"};
                  
                 polikliniklerTxt.Items.AddRange(Poliklinikler);

            list.Add(new Randevu(23425467, "Ahmet Aydın", "52154521", new DateTime(2023, 11, 23), true, "Göz"));
            list.Add(new Randevu(54648573, "Ayşe Uysal", "54511555", new DateTime(2023, 11, 24), true, "Kulak-Burun-Boğaz"));
            list.Add(new Randevu(34375634, "Hakan Demir", "52154521", new DateTime(2023, 11, 25), true, "Cilt"));
            list.Add(new Randevu(44356122, "Kemal Saygın", "52154521", new DateTime(2023, 11, 27), false, "Göz"));
            list.Add(new Randevu(54563534, "Mehmet Yılmaz", "55443322", new DateTime(2023, 11, 28), true, "Ortopedi"));
            list.Add(new Randevu(66787876, "Fatma Kaya", "52111223", new DateTime(2023, 11, 29), true, "Dahiliye"));
            list.Add(new Randevu(73485645, "Mustafa Arı", "53322114", new DateTime(2023, 11, 30), true, "Nöroloji"));
            list.Add(new Randevu(85464562, "Zeynep Yıldız", "52199887", new DateTime(2023, 12, 1), true, "Kardiyoloji"));
            list.Add(new Randevu(94569056, "Emre Çelik", "54321098", new DateTime(2023, 12, 2), false, "Gastroenteroloji"));
            list.Add(new Randevu(14354535, "Sevil Yılmaz", "55556789", new DateTime(2023, 12, 3), true, "Göğüs Hastalıkları"));
            list.Add(new Randevu(70345374, "Seda Akgün", "52223344", new DateTime(2023, 12, 4), true, "Dermatoloji"));
            list.Add(new Randevu(42345436, "Kadir Toprak", "53334455", new DateTime(2023, 12, 5), false, "Üroloji"));
            list.Add(new Randevu(64385834, "Şeyma Karadeniz", "54445566", new DateTime(2023, 12, 6), true, "Psikiyatri"));
            list.Add(new Randevu(94368345, "Cemal Yıldırım", "55556677", new DateTime(2023, 12, 7), true, "Plastik Cerrahi"));

            
            // DataGridView için otomatik boyutlandırma modunu ayarla
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
            // Sütunları yeniden boyutlandırılabilir yap
           
            dataGridView.DataSource = list.ToList();
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Resizable = DataGridViewTriState.True;
            }
            
            temizle();

        }
        
        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                protokolNoTxt.Text = dataGridView.CurrentRow.Cells["id"].Value.ToString();
                adSoyadTxt.Text = dataGridView.CurrentRow.Cells["ad"].Value.ToString();
                telefonTxt.Text = dataGridView.CurrentRow.Cells["telefon"].Value.ToString();
                polikliniklerTxt.Text = dataGridView.CurrentRow.Cells["poliklinik"].Value.ToString();
                sigortaCheck.Checked = (Boolean)dataGridView.CurrentRow.Cells["sigorta"].Value;
                tarihDt.Value = (DateTime)dataGridView.CurrentRow.Cells["tarih"].Value;
            }
            catch (Exception)
            {

                throw;
            }

        }

       
        private void ekleBtn_Click(object sender, EventArgs e)
        {
            string ad = adSoyadTxt.Text;
            string telefon = telefonTxt.Text;
            bool sigorta = sigortaCheck.Checked;
            DateTime tarih = tarihDt.Value;
            string poliklinik = polikliniklerTxt.Text;

            // Rastgele 8 haneli bir ID oluştur
            Random random = new Random();
            int id = random.Next(10000000, 99999999);

             // Yeni randevu oluştur
             Randevu yeniRandevu = new Randevu(id, ad, telefon, tarih, sigorta, poliklinik);

             // Ekleme öncesinde mevcut veri kümesinde aynı id'ye sahip bir randevu var mı kontrol et
            if (list.Any(r =>r.Telefon == telefon && r.Ad == ad && r.Poliklinik == poliklinik))
            {
              MessageBox.Show("Bu ID'ye sahip bir randevu zaten mevcut!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              // Veri kümesine ekle
              list.Add(yeniRandevu);
              dataGridView.DataSource = list.ToList();
              temizle();
    }
}


        private void silBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Seçili satır varsa, bu satırdan ilgili veriyi alabiliriz
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // DataGridView'de sakladığınız nesne türüne (Randevu) dönüştürme işlemi yapabiliriz
                Randevu secilenRandevu = selectedRow.DataBoundItem as Randevu;

                if (secilenRandevu != null)
                {
                    // Seçilen satırın Randevu türünde bir öğe olduğundan emin olduk
                    // Şimdi secilenRandevu değişkeni, seçilen Randevu öğesini temsil ediyor
                    // Bu öğeyi kullanabilirsiniz
                    if (list.Contains(secilenRandevu))
                    {
                        list.Remove(secilenRandevu);
                        // Secilen öğe listeden silindi.
                    }
                }
            }


            dataGridView.DataSource = list.ToList();

        }

        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Seçili satır varsa, bu satırdan ilgili veriyi alabiliriz
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // DataGridView'de sakladığınız nesne türüne (Randevu) dönüştürme işlemi yapabiliriz
                Randevu secilenRandevu = selectedRow.DataBoundItem as Randevu;

                if (secilenRandevu != null)
                {
                    // Yeni değerleri kullanarak seçilen öğenin özelliklerini güncelleme
                    int id = Convert.ToInt32(protokolNoTxt.Text);
                    string ad = adSoyadTxt.Text;
                    string telefon = telefonTxt.Text;
                    bool sigorta = sigortaCheck.Checked;
                    DateTime tarih = tarihDt.Value;
                    string poliklinik = polikliniklerTxt.Text;

                    secilenRandevu.Ad = ad;
                    secilenRandevu.Telefon = telefon;
                    secilenRandevu.Sigorta = sigorta;
                    secilenRandevu.Tarih = tarih;
                    secilenRandevu.Poliklinik = poliklinik;

                    // DataGridView'i güncelleme
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = list;
                }
            }
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            temizle();
        }
        private void temizle()
        {
            protokolNoTxt.Text = null;
            adSoyadTxt.Text = null;
            telefonTxt.Text = null;
            polikliniklerTxt.Text = null;
            sigortaCheck.Checked = false;
            tarihDt.Value = DateTime.Today;
        }

        private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Tıklanan sütunu al
            DataGridViewColumn clickedColumn = dataGridView.Columns[e.ColumnIndex];

            // Tıklanan sütunun adını al
            string columnName = clickedColumn.DataPropertyName;

            // Veri kümesini tıklanan sütuna göre sırala
            if (columnName != null)
            {
                
                dataGridView.DataSource = list.OrderBy(x => x.GetType().GetProperty(columnName).GetValue(x, null)).ToList();
            }
        }

        private void araBtn_Click(object sender, EventArgs e)
        {
            // Arama metnini al
                string aramaMetni = aramaTxtBox.Text;

                // Arama metninin boş olup olmadığını kontrol et
                if (!string.IsNullOrWhiteSpace(aramaMetni))
                {
                    // Protokol numarasına göre veri ara
                    var arananRandevular = list.Where(r => r.Id.ToString().Contains(aramaMetni)).ToList();

                    // Bulunan verileri DataGridView'e yükle
                    dataGridView.DataSource = arananRandevular;
                }
                else
                {
                    // Arama metni boş ise, tüm verileri göster
                    dataGridView.DataSource = list.ToList();
                }
        }

        private void tümVeriBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = list.ToList();
            aramaTxtBox.Clear();
            temizle();
        }
    }
}
