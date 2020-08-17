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
                kissa.Eilainika(rand.Next(1, 11));
                dog.Eilainika(rand.Next(1, 16));
                Console.WriteLine("Koiran ika: "+dog.IkaEilain+" "+ "Kissan ika: "+kissa.IkaEilain);
                if (dog.IkaEilain > kissa.IkaEilain)
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
