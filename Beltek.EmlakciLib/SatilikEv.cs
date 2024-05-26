using System;
using System.Collections.Generic;
using System.Text;

namespace Beltek.EmlakciLib
{
    public class SatilikEv : Ev
    {
        public double Satisfiyat { get; set; }

        public new string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nSatış Fiyatı:{this.Satisfiyat}";
        }
    }
}
