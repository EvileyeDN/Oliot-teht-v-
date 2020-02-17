using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{

    class Program
    {
        static void Main(string[] args)
        {
            
            //Tässä luot luokasta olion
            Hevonen Ruuna = new Hevonen();
            Hevonen Ruuna2 = new Hevonen();
            //Tulosta olion nimi ja paino
            Ruuna.Nimi = "Ruuna";
            Ruuna.Paino = 90;
            Console.WriteLine(Ruuna.Nimi);
            Console.WriteLine(Ruuna.Paino);
            //Muuta olion nimeä ja painoa
            Ruuna2.Nimi = "Ruuna2";
            Ruuna2.Paino = 120;

            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
          

        }
 
    }
   
}
