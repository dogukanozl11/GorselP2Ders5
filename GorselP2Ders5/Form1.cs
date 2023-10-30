using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselP2Ders5
{ // txtboxlara girilen değerlerden oluşan  diziyi tanımlayınız ve dizinin elemanlarını küçükten büyüğe  doğru  sıralayınız.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //nt[] dizim1 = new int[3];
            //int gelen = dizim[1];
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(textBox1.Text);
            int s2 = Convert.ToInt32(textBox2.Text);
            int s3 = Convert.ToInt32(textBox3.Text);
            //Dizi Tanımlama
            int[] dizim1 = new int[3] {s1,s2,s3};
            //sıralama
            int geçici = 0;
            for (int i = 0; i < dizim1.Length; i++)
            {
                for (int j = 0; j < dizim1.Length; j++)
                {
                    if (dizim1[i] < dizim1[j]) //Küçükten Büyüğe sıralaması için.
                    {
                        geçici = dizim1[j];
                        dizim1[j] = dizim1[i];
                        dizim1[i] = geçici;
                    }
                }
            }
            //Dizinin Sıralanmış halini txtbox a yazdırma
            foreach (int item in dizim1) 
            {
                textBox4.Text += item + "<";
            }
        }
    }
}
