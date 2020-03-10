using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
   public class Nisakkaat : Elain
    {
        private int käsissä;

        public int Käsissä { get => käsissä; set => käsissä = value; }
        public void AsetaNisakkatKäsissä(int Kasissa)
        {
            this.käsissä = Kasissa;

        }
        public void NisakkaatAtribuutti()
        {
            käsissä = 2;
            Console.Write("On " + käsissä + " käsissä");
        }
    }
}
