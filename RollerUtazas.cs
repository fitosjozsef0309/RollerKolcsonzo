using System;
using System.Collections.Generic;
using System.Text;

namespace RollerKolcsonzo
{
    public class RollerUtazas
    {
        public string FelhasznaloNev { get; set; }

        public int UtazasiIdoPerc { get; set; }

        public double MegtettKm { get; set; }

        public RollerUtazas(string sor)
        {
            string[] darabol = sor.Split(';');
            FelhasznaloNev = darabol[0];
            UtazasiIdoPerc = int.Parse(darabol[1]);
            MegtettKm=double.Parse(darabol[2]);
        }
    public int FizetendoDij()
        {
            int alapdij = 300;
            return alapdij+UtazasiIdoPerc*60;


        }
        public override string ToString()
        {
            return $"{FelhasznaloNev} :{UtazasiIdoPerc} perc, {MegtettKm} Km - Fizetendő: {FizetendoDij} Ft";
        }
    }
}
