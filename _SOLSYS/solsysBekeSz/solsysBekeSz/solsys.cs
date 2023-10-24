using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solsysBekeSz
{
    class solsys
    {
        public string bneve { get; set; }
        public int holdszam { get; set; }
        public double bterfogat { get; set; }
        public solsys(string s) 
        {
        string[] v = s.Split(';');
            bneve = v[0];
            holdszam = int.Parse(v[1]);
            bterfogat = Double.Parse(v[2]);
        }
    }
}
