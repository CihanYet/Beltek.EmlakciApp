using Beltek.EmlakciLib;
using TestLib;

namespace Beltek.EmlakciApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var evim = new Ev();
            //evim.odasayisi = 2;
            //evim.katno = 1;
            //evim.semt = "Gazi";
            //evim.alan = 100;
            //Console.WriteLine(evim.EvBilgileri());
            //var evim2 = new Ev { alan = 120, katno = 2, odasayisi = 3, semt = "Yenimahalle" };
            //Console.WriteLine(evim2.EvBilgileri());



            var ke = new KiralikEv();
            ke.Kira = 500;
            ke.Depozito = 600;
            ke.Odasayisi = 2;
            ke.Katno = 1;
            ke.Semt = "Kiralik Ev";
            ke.Alan = 100;
            var ke1 = new KiralikEv(2, 3, 120, "Kiralik Ev", 500, 600);
            var se = new SatilikEv(2, 4, 100, "Satılık Ev", 800);
            var se1 = new SatilikEv(4, 8, 200, "Satılık Ev", 10000);

            Ev[] evler = new Ev[4];
            evler[0] = se;
            evler[1] = se1;
            evler[2] = ke;
            evler[3] = ke1;

            for (int i = 0; i < evler.Length; i++)
            {
                //if (evler[i] is SatilikEv)
                //{
                //    SatilikEv sev = (SatilikEv)evler[i];
                //    Console.WriteLine(sev.EvBilgileri());
                //}
                //else
                //{
                //    KiralikEv kev = (KiralikEv)evler[i];
                //    Console.WriteLine(kev.EvBilgileri());
                //}
                Console.WriteLine(evler[i].EvBilgileri());
                Console.WriteLine("----------------------");
            }

            //Console.WriteLine("Oda sayısı giriniz:");
            //evim.Odasayisi = int.Parse(Console.ReadLine());
            //Console.WriteLine("Alan giriniz:");
            //evim.Alan = double.Parse(Console.ReadLine());
            //Console.WriteLine("Kat no giriniz:");
            //evim.Katno = int.Parse(Console.ReadLine());
            //Console.WriteLine("Semt giriniz:");
            //evim.Semt = Console.ReadLine();           

            // Console.WriteLine($"Girilen ev bilgileri:\n{evim.EvBilgileri()}");

        }
    }
}

//Nesne referansları STACK bölgesinde, nesneler HEAP bölgesinde
//Referanslar, HEAP bögesinde bulunan nesnelerin adreslerini tutan yapılardır.
//Nesneler, classlardan üretilir
//Classlar aynı zamanda bir veri tipidir
//Bir classtan birden fazla nesne üretilebilir.
//private: Sadece içinde bulunduğu class tarafından erişilebilir
//public: Class içinde tanımlanan üyeleri, class dışından erişime açmak için kullanılır. 

//class: Bir nesnenin hangi özellikleri içermesi gerektiğini belirler
//nesne: Class'lardan üretilen somut örneklerdir.
//static: Bir üyenin class'a ait olması isteniyorsa static tanımlanır.Nesneye ait olması isteniyorsa static tanımlanmaz.

//Kapsülleme(Encapsulation)

//Write Once, Use Everywhere
