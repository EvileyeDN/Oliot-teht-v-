using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elaimet;

namespace ika
{
    class Program
    {
        static void Main(string[] args)
        {
            int ikakoira, ikakissa;
            Random rand = new Random();
            Koira dog = new Koira();
            Cat kissa = new Cat();
            for (int i = 0; i<=9; i++)
            {
                //kissa.KissanIka(rand.Next(1, 11));
                dog.KoiraIka(rand.Next(1, 16));
                Console.WriteLine("Koiran ika: "+dog.Ika+" "+ "Kissan ika: "+kissa.Ika);
                if (dog.Ika > kissa.Ika)
                {
                    Console.WriteLine("Koira on vanhempi");
                }
                else
                {
                    Console.WriteLine("Kissa on vanhempi");
                }
            }

        }
    }
}
