using System;
using System.Collections;
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
    // txtboxtaki değeri butona basınca listboxa ekleyiniz.Sonra Sırala butonuna basınca Comboboxtan seçilen değere göre listboxın
    // elemanlarını ya a-z ye doğru ya da z den a  ya doğru sıralayan form
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox5.Text);
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            ArrayList listem = new ArrayList(); //Arraylist oluştur
            foreach (var item in listBox1.Items) //listbox ı Arraylist e aktar
            {
                listem.Add(item);
            }
            listBox1.Items.Clear();
            //Comboboxta hangisi seçili ise Arraylisti ona göre sırala
            if (comboBox1.SelectedIndex==0)
            {
                listem.Sort();
            }
            else
            {
                listem.Sort();
                listem.Reverse();
            }
            //Arraylist i ComboBox a Aktar
            foreach (var item in listem)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}
