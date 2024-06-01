using System;

namespace Beltek.EmlakciLib
{
    public class Ev
    {
        private static int sayac = 0;
        public Ev()
        {
            sayac++;
        }
        //Constructor-Yapıcı metod
        public Ev(int odasayisi, int katno, double alan, string semt)
        {
            this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
            this.Semt = semt;
            sayac++;
        }

        private int odasayisi;//field
        private string semt;
        private int katno;
        private string buyukluk;
        private double alan;//field


        public double Alan//Property
        {
            get
            {
                return alan;
            }
            set
            {
                this.alan = value;
                if (alan < 80)
                {
                    this.buyukluk = "Küçük Ev";
                }
                else if (alan >= 80 && alan < 150)
                {
                    this.buyukluk = "Orta Ev";
                }
                else
                {
                    this.buyukluk = "Büyük Ev";
                }
            }
        }

        public int Odasayisi { get => this.odasayisi; set => this.odasayisi = Math.Abs(value); }//Property
        public string Semt { get => semt; set => semt = value.ToUpper(); }

        public int Katno { get => katno; set => katno = value; }
        public string Buyukluk { get => buyukluk; }
        public static int Sayac { get => sayac; }

        // public void SetOdaSayisi(int odasayisi) => this.odasayisi = Math.Abs(odasayisi);
        ////odasayisi fieldına değer atayan metod(set)
        //public int GetOdaSayisi() => this.odasayisi;
        ////odasayisi fieldının değerini okuyan metod(get)

        public string EvBilgileri()
        {
            return $"Katno:{this.Katno}\nAlan:{this.Alan}\nSemt:{this.Semt}\nOda sayısı:{this.Odasayisi}\nBüyüklük:{this.Buyukluk}";
        }

        
        ~Ev()//Destructor
        {
            sayac--;
        }
    }
}

//Garbage Collector (GC)
