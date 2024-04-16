namespace WinFormsApp2
{
    public partial class FormAlanCevreHesaplama : Form
    {
        public FormAlanCevreHesaplama()
        {
            InitializeComponent();
        }

        private void BtnAlanHesapla_Click(object sender, EventArgs e)
        {
            //Kare Alan Hesaplama
            int kareKenarUzunluk = Convert.ToInt32(textBoxKenar.Text);
            int alanKare = kareKenarUzunluk * kareKenarUzunluk;
            LblKareAlan.Text = alanKare.ToString();

            //Dikdörtgen Alan Hesaplama
            int kisaKenarUzunluk = Convert.ToInt16(textBoxKisaKenar.Text);
            int uzunKenarUzunluk = Convert.ToInt16(textBoxUzunKenar.Text);
            int alanDikdörtgen = kisaKenarUzunluk * uzunKenarUzunluk;
            LblDikdortgenAlan.Text = alanDikdörtgen.ToString();

            //Daire Alan Hesaplama
            int yaricap = Convert.ToInt32(textBoxYaricap.Text);
            int alanDaire = (int)Math.PI * (yaricap * yaricap);
            LblDaireAlan.Text = alanDaire.ToString();
        }

        private void BtnCevreHesapla_Click(object sender, EventArgs e)
        {
            //Kare Çevre Hesaplama
            int kareKenarUzunluk = Convert.ToInt32(textBoxKenar.Text);
            int cevreKare = kareKenarUzunluk * 4;
            LblKareCevre.Text = cevreKare.ToString();

            //Dikdörtgen Çevre Hesaplama
            int kisaKenarUzunluk = Convert.ToInt16(textBoxKisaKenar.Text);
            int uzunKenarUzunluk = Convert.ToInt16(textBoxUzunKenar.Text);
            int cevreDikdörtgen = 2 * (kisaKenarUzunluk + uzunKenarUzunluk);
            LblDikdortgenCevre.Text = cevreDikdörtgen.ToString();

            //Daire Çevre Hesaplama
            int yaricap = Convert.ToInt32(textBoxYaricap.Text);
            int cevreDaire = 2 * (int)Math.PI * yaricap;
            LblDaireCevre.Text = cevreDaire.ToString();
        }
    }
}