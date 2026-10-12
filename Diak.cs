using System;
using System.Collections.Generic;
using System.Text;

namespace DiakApp
{
    internal class Diak
    {
        public string Nev { get; set; }
        public string Osztaly { get; set; }
        private int pontszam;

        public int Pontszam
        {
            get
            {
                return pontszam;
            }
            set
            {
                if (value < 0)
                {
                    pontszam = 0;
                }
                else if(value > 100)
                {
                    pontszam = 100;
                }
                else
                {
                    pontszam = value;
                }
            }
        }

        public Diak(string nev, string osztaly, int pontszam)
        {
            this.Nev = nev;
            this.Osztaly = osztaly;
            this.Pontszam = pontszam;
        }


        public string toString()
        {
            return $"{Nev} ({Osztaly}) - {Pontszam} pont";
        }
    }
}
