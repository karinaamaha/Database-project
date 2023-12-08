using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataKos.model
{
    internal class Penghuni_m
    {
        string nama, nokos, alamat, nohp;

        public Penghuni_m()
        {
        }

        public Penghuni_m(string nama, string nokos, string alamat, string nohp) {
            this.Nama = nama;
            this.Nokos = nokos;
            this.Alamat = alamat;
            this.Nohp = nohp;
                
        }

        // untuk membuat get dan set, tekan ctrl+r+e
        public string Nama { get => nama; set => nama = value; }
        public string Nokos { get => nokos; set => nokos = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Nohp { get => nohp; set => nohp = value; }
    }
}
