using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> ogrenciListe = new List<string>(); //string türü liste oluştur
        private void Form1_Load(object sender, EventArgs e)
        {
           

            ogrenciListe.Add("Medine"); //Listeye eleman ekleme
            ogrenciListe.Add("Kevser");
            ogrenciListe.Add("Göknur");
            ogrenciListe.Add("Rukiye");
            ogrenciListe.Add("Elif");
            ogrenciListe.Add("Sedef");
            ogrenciListe.Add("Hiranur");
            ogrenciListe.Add("Dilan");
            ogrenciListe.Add("Merve");
            ogrenciListe.Add("Beyza");


            // listbox datasource kullanarak listeyi bağlama
            listBox1.DataSource = ogrenciListe.ToList();



            //For döngüsü ile liste elemanlarını listbox' a ekleme

            //for (int i = 0; i < ogrenciListe.Count; i++)
            //{
            //    listBox1.Items.Add(ogrenciListe[i]);
            //}




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ilk elemanı Sil
            ogrenciListe.RemoveAt(0); //İlk eleman indeks numarası 0 olduğu için

            listBox1.DataSource = ogrenciListe.ToList();

        }

        private void button2_Click(object sender, EventArgs e) 
        {
            //Son elemanı sil
            int elemanSayisi=ogrenciListe.Count; //Toplam eleman sayısını verir

            ogrenciListe.RemoveAt(elemanSayisi-1); //son eleman index no elde ettik 

            listBox1.DataSource = ogrenciListe.ToList();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ogrenciListe.Sort(); 
            listBox1.DataSource = ogrenciListe.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrenciListe.Reverse();//Listeyi Ters Çevirir.
            listBox1.DataSource = ogrenciListe.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ogrenciListe.Sort();
            ogrenciListe.Reverse();

            listBox1.DataSource = ogrenciListe.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string aranan = textBox1.Text;
            bool kontrol=ogrenciListe.Contains(aranan);

            if (kontrol == true)
            {
                MessageBox.Show("Öğrenci bulundu.");
            }
            else
            {
                MessageBox.Show("Öğrenci bulunamadı.");
            }
        }
    }
}
