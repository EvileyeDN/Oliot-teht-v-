using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elaimet;


namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cat kissa = new Cat();
            kissa.AsetaElaimenika(10);
            kissa.AsetaElaimennimi("Kissa");
            kissa.Lihansyoja(true);
            Console.WriteLine(kissa.NIMIEilain+" "+kissa.IKAEilain+" ");
            Koira koira = new Koira();
            koira.AsetaElaimenika(10);
            koira.AsetaElaimennimi("Koira");
            koira.Lihansyoja(true);
            Console.WriteLine(koira.NIMIEilain + " " + koira.IKAEilain + " ");



        }
    }
}
