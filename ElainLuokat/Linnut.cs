using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
   public class Linnut : Elain
    {
        private int Kärkiväli;

        public int Kärkiväli1 { get => Kärkiväli; set => Kärkiväli = value; }

        public void AsetaLinnunKärkiväli(int Kärkiväli)
        {
            this.Kärkiväli1 = Kärkiväli;
           
        }
        public void KärkiväliAtribuutti()
        {
            Random rand = new Random();

            int Kärkiväli;
            Kärkiväli = rand.Next(1, 30);
            Console.Write("Linnun Kärkiväli on: "+Kärkiväli);
        }
    }
}
