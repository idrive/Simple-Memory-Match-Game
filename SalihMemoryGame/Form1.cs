namespace SalihMemoryGame
{
    public partial class Form1 : Form
    {
        int ilkKart = -1,ikinciKart = -1,bulunanResimler=0,tiklamaSayaci=1;
        bool yanlisAcik=false;
        int[] Karakterler = { 0, 1, 2, 3, 4, 5, 0, 1, 2, 3, 4, 5 };
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            karakter_Karistir(Karakterler);
            // 0-Walter
            // 1-Jesse
            // 2-Hank
            // 3-Gustavo
            // 4-Mike
            // 5-Skyler
        }

        void karakter_Karistir(int[] Karakterler)
        {
            for (int i = 0; i < Karakterler.Length; i++)
            {
                int k = rnd.Next(Karakterler.Length);
                int gecici = Karakterler[i];
                Karakterler[i] = Karakterler[k];
                Karakterler[k] = gecici;
            }
        }
        void tiklaSayaci()
        {
            if (tiklamaSayaci == 1)
            {
                tiklamaSayaci = 2;
            }
            else
            {
                tiklamaSayaci = 1;
            }
        }
        Image resimGetir(int no)
        {
            switch (no)
            {
                case 0:
                    return Properties.Resources.Walter;
                case 1:
                    return Properties.Resources.Jesse;
                case 2:
                    return Properties.Resources.Hank;
                case 3:
                    return Properties.Resources.Gustavo;
                case 4:
                    return Properties.Resources.Mike;
                case 5:
                    return Properties.Resources.Skyler;
                default: return null;
            }
        }
        void kartCevir(int idx)
        {
            switch (idx)
            {
                case 0:
                    btn0.BackgroundImage = resimGetir(Karakterler[0]);
                    break;
                case 1:
                    btn1.BackgroundImage = resimGetir(Karakterler[1]);
                    break;
                case 2:
                    btn2.BackgroundImage = resimGetir(Karakterler[2]);
                    break;
                case 3:
                    btn3.BackgroundImage = resimGetir(Karakterler[3]);
                    break;
                case 4:
                    btn4.BackgroundImage = resimGetir(Karakterler[4]);
                    break;
                case 5:
                    btn5.BackgroundImage = resimGetir(Karakterler[5]);
                    break;
                case 6:
                    btn6.BackgroundImage = resimGetir(Karakterler[6]);
                    break;
                case 7:
                    btn7.BackgroundImage = resimGetir(Karakterler[7]);
                    break;
                case 8:
                    btn8.BackgroundImage = resimGetir(Karakterler[8]);
                    break;
                case 9:
                    btn9.BackgroundImage = resimGetir(Karakterler[9]);
                    break;
                case 10:
                    btn10.BackgroundImage = resimGetir(Karakterler[10]);
                    break;
                case 11:
                    btn11.BackgroundImage = resimGetir(Karakterler[11]);
                    break;
            }
        }
        void kartKapat(int idx)
        {
            switch (idx)
            {
                case 0:
                    btn0.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 1:
                    btn1.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 2:
                    btn2.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 3:
                    btn3.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 4:
                    btn4.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 5:
                    btn5.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 6:
                    btn6.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 7:
                    btn7.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 8:
                    btn8.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 9:
                    btn9.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 10:
                    btn10.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
                case 11:
                    btn11.BackgroundImage = Properties.Resources.kapali_Kart;
                    break;
            }
        }
        void kartKilitle(int idx)
        {
            switch (idx)
            {
                case 0:
                    btn0.Enabled = false;
                    break;
                case 1:
                    btn1.Enabled = false;
                    break;
                case 2:
                    btn2.Enabled = false;
                    break;
                case 3:
                    btn3.Enabled = false;
                    break;
                case 4:
                    btn4.Enabled = false;
                    break;
                case 5:
                    btn5.Enabled = false;
                    break;
                case 6:
                    btn6.Enabled = false;
                    break;
                case 7:
                    btn7.Enabled = false;
                    break;
                case 8:
                    btn8.Enabled = false;
                    break;
                case 9:
                    btn9.Enabled = false;
                    break;
                case 10:
                    btn10.Enabled = false;
                    break;
                case 11:
                    btn11.Enabled = false;
                    break;
            }
        }
        void tikla(int idx)
        {
            if (yanlisAcik)
            {
                kartKapat(ilkKart);
                kartKapat(ikinciKart); 
                yanlisAcik = false;
            }
            else
            {
                if (tiklamaSayaci == 1)
                {
                    ilkKart = idx;
                    kartCevir(idx);
                    tiklaSayaci();
                }
                else
                {
                    ikinciKart= idx;
                    kartCevir(idx);
                    tiklaSayaci();
                    if (Karakterler[ilkKart]== Karakterler[ikinciKart])
                    {
                        kartKilitle(ilkKart);
                        kartKilitle(ikinciKart);
                        bulunanResimler++;
                    }
                    else
                    {
                        yanlisAcik= true;
                    }
                }
                if (bulunanResimler== 6)
                {
                    MessageBox.Show("Basardin:)");
                }
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tikla(0);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tikla(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tikla(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tikla(3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tikla(4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tikla(5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tikla(6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tikla(7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tikla(8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tikla(9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            tikla(10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            tikla(11);
        }
    }
}
