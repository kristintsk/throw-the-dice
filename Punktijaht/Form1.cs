using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punktijaht
{
    public partial class Form1 : Form
    {
        int juhuarv1, juhuarv2, juhuarv3, juhuarv4, tulemus1, tulemus2;
        int mitu = 2, minArv = 1, maxArv = 6;        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KT_btn_Uusmäng.Enabled = true;
            KT_btn_Viskab_1.Enabled = false;
            KT_btn_Viskab_2.Enabled = false;
        }

        private void KT_btn_Uusmäng_Click(object sender, EventArgs e)
        {
            KT_txt_Vise_1_1.Text = "";
            KT_txt_Vise_1_2.Text = "";
            KT_txt_Vise_2_1.Text = "";
            KT_txt_Vise_2_2.Text = "";
            KT_txt_Summa1.Text = "";
            KT_txt_Summa2.Text = "";
            KT_txt_Tulemus.Text = "";
            KT_pic_Voitja.Image = null;
            KT_btn_Viskab_1.Enabled = true;
        }

        private void KT_btn_Viskab_1_Click(object sender, EventArgs e)
        {
            Random punktid = new Random();

            for (int i = 1; i < mitu; i++)
            {
                juhuarv1 = punktid.Next(minArv, maxArv + 1);
                KT_txt_Vise_1_1.Text = juhuarv1.ToString();
                KT_txt_Vise_1_1.TabStop = false;
            }

            for (int i = 1; i < mitu; i++)
            {
                juhuarv2 = punktid.Next(minArv, maxArv + 1);
                KT_txt_Vise_1_2.Text = juhuarv2.ToString();
                KT_txt_Vise_1_2.TabStop = false;
            }

            tulemus1 = juhuarv1 + juhuarv2;
            KT_txt_Summa1.Text = (tulemus1).ToString();
            KT_txt_Summa1.TabStop = false;
            KT_btn_Uusmäng.Enabled = false;
            KT_btn_Viskab_1.Enabled = false;
            KT_btn_Viskab_2.Enabled = true;
        }

        private void KT_btn_Viskab_2_Click(object sender, EventArgs e)
        {
            Random punktid = new Random();

            int mitu = 2, minArv = 1, maxArv = 6;
            for (int i = 1; i < mitu; i++)
            {
                juhuarv3 = punktid.Next(minArv, maxArv + 1);
                KT_txt_Vise_2_1.Text = juhuarv3.ToString();
                KT_txt_Vise_2_1.TabStop = false;
            }
            for (int i = 1; i < mitu; i++)
            {
                juhuarv4 = punktid.Next(minArv, maxArv + 1);
                KT_txt_Vise_2_2.Text = juhuarv4.ToString();
                KT_txt_Vise_2_2.TabStop = false;
            }
            tulemus2 = juhuarv3 + juhuarv4;
            KT_txt_Summa2.Text = (tulemus2).ToString();
            KT_txt_Summa2.TabStop = false;

            if (tulemus1 > tulemus2)
            {
                KT_txt_Tulemus.Text = "Võitis Juku!";
                KT_txt_Tulemus.TabStop = false;
                KT_pic_Voitja.Image = global::Punktijaht.Properties.Resources.Juku;
            }
            else if (tulemus1 < tulemus2)
            {
                KT_txt_Tulemus.Text = "Võitis Juula!";
                KT_txt_Tulemus.TabStop = false;
                KT_pic_Voitja.Image = global::Punktijaht.Properties.Resources.Juula;
            }
            else
            {
                KT_txt_Tulemus.Text = "Mäng jäi viiki!";
                KT_txt_Tulemus.TabStop = false;
                KT_pic_Voitja.Image = global::Punktijaht.Properties.Resources.Viik;
            }

            KT_btn_Viskab_2.Enabled = false;
            KT_btn_Uusmäng.Enabled = true;
        }

        private void KT_btn_Lopeta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kas oled kindel, et soovid lõpetada?", "Lõpeta mäng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) ==
                DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
