namespace TrenBiletUygulamasi
{
    public partial class Form1 : Form
    {
        List<Rota> rotalar = new List<Rota>()
            {
                new Rota(100, "Istanbul",55),
                new Rota(150, "Ankara", 55),
                new Rota(200, "Izmir", 55)
            };
        private decimal ciro = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            foreach (var item in rotalar)
            {
                comboBoxGuzergah.Items.Add(item.Guzergah);
            }
            comboBoxGuzergah.SelectedItem = rotalar[0].Guzergah;
        }

        public void BiletSat(Bilet bilet, bool indirim, int koltukSayisi)
        {
            bilet.ToplamUcret =
                indirim
                ? bilet.Guzergah.Ucret * 0.5m * koltukSayisi
                : bilet.Guzergah.Ucret * koltukSayisi;



            var rota = rotalar.FirstOrDefault(x => x.Guzergah == bilet.Guzergah.Guzergah);
            rota.Koltuksayisi -= koltukSayisi;


        }

        public void BiletIptal(string isim)
        {
            foreach (var item in Satilan_Biletler.Items)
            {
                if (item.ToString().Contains(isim))
                {
                    Satilan_Biletler.Items.Remove(item);
                    break;
                }
            }
        }



        private void btnIade_Click(object sender, EventArgs e)
        {
            string isim = txtIade.Text;
            BiletIptal(isim);
        }

        private void btnSat_Click_1(object sender, EventArgs e)
        {
            int koltukSayisi = int.Parse(txtKoltukSayisi.Text);
            string rota = comboBoxGuzergah.Text;
            string isim = txtIsim.Text;
            bool indirim = chkIndirim.Checked;

            var guzergah = rotalar.FirstOrDefault(x => x.Guzergah == rota);
            Bilet bilet = new Bilet(koltukSayisi, isim, guzergah);
            BiletSat(bilet, indirim, koltukSayisi);

            string biletSatisi = $"Isim: {bilet.YolcuAdi} \nGuzergah: {bilet.Guzergah.Guzergah} \nToplam Ucret: {bilet.ToplamUcret}";
            ciro += bilet.ToplamUcret;
            Satilan_Biletler.Items.Add(biletSatisi);
        }

        private void btnBosKoltuk_Click(object sender, EventArgs e)
        {
            int bosKoltukSayisi = 0;

            foreach (var rota in rotalar)
            {
                bosKoltukSayisi += rota.Koltuksayisi;
            }

            MessageBox.Show($"Toplam Boþ Koltuk Sayýsý: {bosKoltukSayisi}");
        }

        private void btnToplamCiro_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show($"Toplam Ciro: {ciro} TL");
        }
    }
}

    public class Bilet
    {
        public Bilet(int koltukSayisi, string yolcuAdi, Rota guzergah)
        {
            KoltukSayisi = koltukSayisi;
            YolcuAdi = yolcuAdi;
            Guzergah= guzergah;           
        }

        public int KoltukSayisi { get; set; }
        public string YolcuAdi { get; set; }
        public Rota Guzergah { get; set; }
        public decimal ToplamUcret { get; set; }



    }

    public class Rota
    {
        public Rota(decimal ucret, string guzergah, int koltuksayisi)
        {
            Ucret = ucret;
            Guzergah = guzergah;
            Koltuksayisi = koltuksayisi;
        }

        public decimal Ucret { get; set; }
        public string Guzergah { get; set; }
        public int Koltuksayisi{ get; set; }
    }
