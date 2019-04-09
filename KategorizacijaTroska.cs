using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nk
{
    class KategorizacijaTroska
    {
        public string Kategorija;
        public double Trosak;

        public KategorizacijaTroska(string kat, double trosak)
        {
            Kategorija = kat;
            Trosak = trosak;
        }
        public string Ispis()
        {
            string ispis = "";
           
                ispis = Trosak + "kn - " + Kategorija;
            
            return ispis;
        }


    }
}
