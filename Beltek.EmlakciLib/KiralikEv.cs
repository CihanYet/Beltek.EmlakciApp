using System;
using System.Collections.Generic;
using System.Text;

namespace Beltek.EmlakciLib
{
    public class KiralikEv : Ev
    {
        public KiralikEv()
        {

        }

        public KiralikEv(int odasayisi, int katno, double alan, string semt, double kira, double depozito):base(odasayisi,katno,alan,semt)
        {
            //base.Odasayisi = odasayisi;
            //base.Katno = katno;
            //base.Alan = alan;
            //base.Semt = semt;
            this.Kira = kira;
            this.Depozito = depozito;
        }
        public double Kira { get; set; }
        public double Depozito { get; set; }

        public new string EvBilgileri()
        {
            return $"{base.EvBilgileri()}\nKira:{this.Kira}\nDepozito:{this.Depozito}";
        }
    }
}

//Name Hiding
