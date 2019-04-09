using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nk
{
    public partial class Form1 : Form
    {
        List<KategorizacijaTroska> listaTroskova = new List<KategorizacijaTroska>();
        KategorizacijaTroska troskovi;
        public Form1()
        {
            InitializeComponent();
          
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            troskovi = new KategorizacijaTroska(listBoxKategorija.SelectedItem.ToString(), double.Parse(textBoxTrosak.Text));
            listaTroskova.Add(troskovi);

            textBoxIspis.Clear();

            foreach (KategorizacijaTroska item in listaTroskova)
            {
                textBoxIspis.Text += item.Ispis() + Environment.NewLine;
            }


        }

        private void buttonFiltriraj_Click(object sender, EventArgs e)
        {
            textBoxFiltrirani.Clear();


            foreach (KategorizacijaTroska item in listaTroskova)
            {
                if (listBoxFilter.SelectedItem.ToString()== item.Kategorija)
                {
                    textBoxFiltrirani.Text += item.Ispis() + Environment.NewLine;
                }
                          



            }
        }
    }
}
