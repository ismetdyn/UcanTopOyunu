using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje5._37UcanTopOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int yerX = 5, yerY = 5, sure = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                    btnKontrolCubugu.Left = e.X;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            lSure.Text = Convert.ToString(sure / 100);
            carpmaKontrolu();
            yanmaKontrolu();
            btnTop.Location = new Point(btnTop.Location.X + yerX, btnTop.Location.Y + yerY);
        }

        private void btnBaslaDevamEt_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; 
            btnTop.Location = new Point(415, 107); // ilk başlanan nokta.
        }

        private void yanmaKontrolu()
        {
            int kalanHak = Convert.ToInt32(lKalanHak.Text);
            if(btnTop.Top >= lSag.Bottom) // yataydaki hizayı geçme.
            {
                if(kalanHak > 0)
                {
                    kalanHak--;
                    lKalanHak.Text =kalanHak.ToString();
                    timer1.Enabled = false;
                    btnTop.Location = new Point(415, 107); //ilk başlanan nokta.
                }
                else
                {
                    timer1.Enabled = false;
                    lKalanHak.Text = "Oyun Bitti...";
                    Application.Exit();
                }
            }
        }

        private void carpmaKontrolu()
        {
            //üst kenara çarpma.
            if (btnTop.Top <= lUst.Bottom)
                yerY = yerY * -1;
            else if (btnTop.Bottom >= btnKontrolCubugu.Top && btnTop.Left >= btnKontrolCubugu.Left 
                && btnTop.Right <= btnKontrolCubugu.Right) //kontrol çubuğuna çarpma.
            {
                yerY = yerY * -1;
                int kurtarmaSayisi = Convert.ToInt32(lKurtarmaSayisi.Text);
                lKurtarmaSayisi.Text = Convert.ToString(kurtarmaSayisi + 1);
            }
            //sol ve sağ kenarlara çarpma.
            else if (btnTop.Right >= lSag.Left)
                yerX = yerX * -1;
            else if (btnTop.Left <= lSol.Right)
                yerX = yerX * -1;
        }
    }
}
