using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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

            String[] Poliklinikler = {"Cildiye","Dahiliye","Endokrinoloji","Enfeksiyon Hastalıkları","Fizik Tedavi",
                "Gastroenteroloji","Genel Cerrahi","Göz Hastalıkları","Hematoloji","Kadın Hastalıkları ve Doğum",
                "Kardiyoloji","Kulak Burun Boğaz","Nöroloji","Onkoloji","Ortopedi","Plastik Cerrahi","Psikiyatri",
                "Radyoloji","Üroloji"};


            //Poliklinikleri ComboBox'a ekle.
            polikliniklerTxt.Items.AddRange(Poliklinikler);

            // Örnek randevuları listeye ekle
            list.Add(new Randevu(23425467, "Berat Yeşil", "55485465", new DateTime(2024, 3, 1), true, "Ortopedi"));
            list.Add(new Randevu(54648573, "Murat Akyurt", "54895654", new DateTime(2023, 11, 30), true, "Kulak-Burun-Boğaz"));
            list.Add(new Randevu(34375634, "Bekir Yaman", "54654859", new DateTime(2023, 2, 16), true, "Cilt"));
            list.Add(new Randevu(44356122, "Burak Sakman", "55569586", new DateTime(2024, 1, 18), false, "Göz"));
            list.Add(new Randevu(54563534, "Büsra Yurt", "50565849", new DateTime(2024, 4, 15), true, "Cilt"));
            list.Add(new Randevu(66787876, "Betül Karlı", "55487525", new DateTime(2021, 5, 19), true, "Dahiliye"));
            list.Add(new Randevu(73485645, "Mehmet Akif", "55265585", new DateTime(2023, 6, 27), true, "Kulak-Burun-Boğaz"));
            list.Add(new Randevu(85464562, "Hasan Uzun", "53165885", new DateTime(2023, 9, 7), true, "Cilt"));
            list.Add(new Randevu(94569056, "Diyar Tekin", "53695575", new DateTime(2023, 11, 5), false, "Gastroenteroloji"));
            list.Add(new Randevu(14354535, "Ömer Fasıl", "55113551", new DateTime(2023, 8, 30), true, "Kulak-Burun-Boğaz"));
            list.Add(new Randevu(70345374, "Mehmet Uzun", "53666695", new DateTime(2023, 5, 18), true, "Dermatoloji"));
            list.Add(new Randevu(42345436, "Lale Tokatlı", "53105699", new DateTime(2023, 7, 3), false, "Üroloji"));
            list.Add(new Randevu(64385834, "Melek Akdeniz", "54189854", new DateTime(2023, 2,21), true, "Dahiliye"));
            list.Add(new Randevu(94368345, "Erdem Yatkın", "54298859", new DateTime(2023, 2, 23), true, "Gastroenteroloji"));
    
            // DataGridView için otomatik boyutlandırma modunu ayarlama vs.
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView.DataSource = list.ToList();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.Resizable = DataGridViewTriState.True;
            }
            temizle();
            MessageBox.Show("Randevu Kayıt Sistemine Hoşgeldiniz.");
        }

        // DataGridView'de hücre seçildiğinde çalışacak
        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Seçilen satırdaki verileri ilgili alanlara yerleştir
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

            // Rastgele 8 haneli bir Protokol oluştur
            Random random = new Random();
            int id = random.Next(10000000, 99999999);

            // Yeni randevu oluştur
            Randevu yeniRandevu = new Randevu(id, ad, telefon, tarih, sigorta, poliklinik);

            // Ekleme öncesinde mevcut veri kümesinde aynı protokole sahip bir randevu var mı kontrol et
            if (list.Any(r => r.Telefon == telefon && r.Ad == ad && r.Poliklinik == poliklinik))
            {
                MessageBox.Show("Bu protokol numarasına sahip bir kayıt zaten mevcut!", "İstenilen Kayıt Eklenmedi !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (list.Any(r =>r.Telefon == null || r.Ad == ad || r.Poliklinik == null))
                {
                    MessageBox.Show("Lütfen boş alan bırakmayınız.");
                }
                else
                {
                    // Veri kümesine ekle en üste gelmesi için insert
                    list.Insert(0, yeniRandevu); 

                    dataGridView.DataSource = list.ToList();

                    // Eklenen veriyi seçili yap
                    dataGridView.Rows[0].Selected = true;

                    MessageBox.Show(ad + " isimli kişinin kaydı eklenmiştir!");

                    temizle();
                }
               
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
                    // Bu öğeyi kullanabiliriz
                    if (list.Contains(secilenRandevu))
                    {
                        // Secilen öğeyi listeden sil
                        list.Remove(secilenRandevu);
                        
                    }
                }
            }
            dataGridView.DataSource = list.ToList();
            temizle();
        }
        private void güncelleBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Aynı Şekilde Sil'deki gibi
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                Randevu secilenRandevu = selectedRow.DataBoundItem as Randevu;

                if (secilenRandevu != null)
                {
                    // Yeni değerleri kullanarak seçilen öğenin özelliklerini güncelle
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
            temizle();
        }

        // TextBox'ları Temizle
        private void temizleBtn_Click(object sender, EventArgs e)
        {
            temizle();
        }

        // Textbox'ları temizleme metodu
        private void temizle()
        {
            //Text'boxları ve diğerlerini temizle
            protokolNoTxt.Text = null;
            adSoyadTxt.Text = null;
            telefonTxt.Text = null;
            polikliniklerTxt.Text = null;
            sigortaCheck.Checked = false;
            tarihDt.Value = DateTime.Today;
        }

        //DataGridViewin üstüne tıklandığında yapılacaklar
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

        //  Randevu ara
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
                    // Arama metni boş ise tüm verileri göster
                    dataGridView.DataSource = list.ToList();
                    temizle();
                    MessageBox.Show("Bu Protokol nuumarasına ait bir kayıt bulunamadı!");
            }
        }

        //Tüm veriyi göster
        private void tümVeriBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = list.ToList();
            aramaTxtBox.Clear();
            temizle();
        }

        //Github Profil Linki :)
        private void githubProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kadircangeyik/");
            
        }

        //Linkedin Profil Linki :)
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/kadir-can-geyik-a149861a2/");
        }
    }
}
