using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
        int[] girdiler = new int[6];
        double[] agırlıklar = new double[4];
        private void button1_Click(object sender, EventArgs e)
        {
            girdiler[0] = Convert.ToInt16(textBox1.Text);
            girdiler[1] = Convert.ToInt16(textBox2.Text);
            girdiler[2] = Convert.ToInt16(textBox3.Text);
            girdiler[3] = Convert.ToInt16(textBox4.Text);
            dugum.agırlıklars(girdiler[0], girdiler[1], girdiler[2], girdiler[3]);
            agırlıklar[0] = Convert.ToDouble(textBox5.Text);
            agırlıklar[1] = Convert.ToDouble(textBox6.Text);
            agırlıklar[2] = Convert.ToDouble(textBox7.Text);
            agırlıklar[3] = Convert.ToDouble(textBox8.Text); 
            dugum.agırlıklars(agırlıklar[0], agırlıklar[1], agırlıklar[2], agırlıklar[3]);
           double sonuc= dugum.fonksiyon(girdiler, agırlıklar);
           if (sonuc >= 10.25 & sonuc <= 20.75)
           {
               label11.Text = "Sağlıklı";
           }
           else label11.Text = "Sağlıksız";
           textBox9.Text = Convert.ToString(sonuc);
            net();
        }
        double deger;
        void net()
        {
            for (int i = 0; i < 4; i++)
            {
                deger = girdiler[i] * agırlıklar[i];
            }
            textBox9.Text = Convert.ToString(deger);
        }

    }

    class dugum : Form
    {
        int[] agırlıklar = new int[4];
        public static void agırlıklars(double x, double y, double z, double w)
        {
            
        }
      

      
        public static void girdiler(int a, int b, int c, int d)
        {

        }


        internal static double fonksiyon(int[] girdiler, double[] agırlıklar)
        {
            double sonuc=0;
            if (girdiler.Length == agırlıklar.Length)
            {
                for (int i = 0; i < girdiler.Length; i++)
                {
                    sonuc+=girdiler[i]*agırlıklar[i];
                }
                    
            }
            return sonuc;
        }
    }
}