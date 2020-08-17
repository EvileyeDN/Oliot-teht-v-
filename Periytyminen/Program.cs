using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elaimet;
using ElainLuokat;


namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat kissa = new Cat();
            //kissa.AsetaElaimenika(10);
            //kissa.AsetaElaimennimi("Kissa55");
            //kissa.Lihansyoja(true);
            //Console.WriteLine(kissa.NIMIEilain+" "+kissa.IKAEilain+" ");
            Koira koira = new Koira();
            //koira.AsetaElaimenika(12);
            //koira.AsetaElaimennimi("Koira32");
            //koira.Lihansyoja(true);
            //Console.WriteLine(koira.NIMIEilain + " " + koira.IKAEilain + " ");
            //kissa.Ääntele();
            //koira.Ääntele();
            Linnut lintu = new Linnut();
            Papukaija papukaja = new Papukaija();
            //papukaja.EilainNimi("Papukaja");
            //papukaja.Eilainika(5);
            //papukaja.AsetaLinnunKärkiväli(5);
            //Console.WriteLine(papukaja.NimiEilain+papukaja.IKAEilain+papukaja.Kärkiväli1);
            //koira.AsetaElaimenika(14);
            //koira.AsetaElaimennimi("Koira");
            //kissa.AsetaElaimenika(3);
            //kissa.AsetaElaimennimi("Tigra");
            //koira.AsetaNisakkatKäsissä(4);
            //Console.WriteLine(koira.NIMIEilain + " " + koira.IKAEilain + " ");
            //Console.ReadLine();
            //kissa.eläintenmäärää();
            //kissa.Vaihe2();
            //koira.ListNimiTulosta();
            //kissa.ListNimiTulosta();
            //kissa.AddKissaÄiti();
            //kissa.ListNimiTulosta();
            //kissa.ListCount();
            //koira.ListCount();
            kissa.AddKissaÄiti();
            kissa.AddKissaÄiti();
            kissa.ListEmoTulosta();
            kissa.AddKissanPentu();
            kissa.AddKissanPentu();
            kissa.AddKissanPentu();
            kissa.AddKissaÄiti();
            kissa.PentuWhoEuarAiti();

        }
    }
}
