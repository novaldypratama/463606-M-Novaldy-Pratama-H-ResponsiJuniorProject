using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi_Novaldy
{
    internal class Karyawan
    {
        private char _idKar
            { get; set; }
        public string _nama 
            { get; set; }

        public void GetKaryawan(char idKar, string nama)
        {
            _idKar = idKar;
            _nama = nama;
        }

    }
}
