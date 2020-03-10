using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Share
    {
        public abstract int GetArea();
    }
    public abstract class Elain
    {  
        

        private int ikaEilain;
        private string nimiEilain;
        private bool onLihanSyoja;
        private string Lihasyo;
        private string Nimi;
        List<int> EilainTestIka = new List<int>();
        List<string> EilainNimiTest = new List<string>();

        public int IkaEilain { get => ikaEilain; set => ikaEilain = value; }
        public string NimiEilain { get => nimiEilain; set => nimiEilain = value; }
        public bool OnLihanSyoja { get => onLihanSyoja; set => onLihanSyoja = value; }
        public Elain()
        {
         
            
        }
        public Elain(string nimi, int ika)
        {
            NimiEilain=nimi;
            IkaEilain=ika;
            

        }
        public void ListNimiTulosta()
        {
            foreach(string C in this.EilainNimiTest)
            {
                Console.WriteLine(C);
            }
        }
        public void Lihansyoja(bool Liha)
        {
            if (Liha == true)
            {
                this.Lihasyo = "On lihasyo";
            }
            else
            {
                this.Lihasyo = "ei ole lihasyo";
            }
        }
        public void eläintenmäärää()
        {
            int eeläintenmäärää = 0;
            int ika = 0;
            string nimi = "";
            Console.WriteLine("eläinten määrää?");
            eeläintenmäärää = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i<eeläintenmäärää; i++)
            {
                Console.WriteLine("Aseta Elaimen ika");
                AsetaElaimenika(ika = Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine("Aseta Elaimen nimi");
                AsetaElaimennimi(nimi = Console.ReadLine());
               
            }
            
        }
        public void AsetaNimi()
        {
            Random rand = new Random();
            int AsetaKirja;
            AsetaKirja = 1;
            string nimi = "";
            if (AsetaKirja == 1)
            {
                AsetaKirja = rand.Next(0, 26);
                char Kirja = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"[AsetaKirja];
                nimi = nimi + Kirja;
                AsetaKirja = 2;
            }
            if (AsetaKirja == 2)
            {
                AsetaKirja = rand.Next(0, 26);
                char Kirja = "abcdefghijklmnopqrstuvwxyz"[AsetaKirja];
                nimi = nimi + Kirja;
                AsetaKirja = 3;
            }
            if (AsetaKirja == 3)
            {
                AsetaKirja = rand.Next(0, 26);
                char Kirja = "abcdefghijklmnopqrstuvwxyz"[AsetaKirja];
                nimi = nimi + Kirja;
                AsetaKirja = 4;
            }
            if (AsetaKirja == 4)
            {
                AsetaKirja = rand.Next(0, 26);
                char Kirja = "abcdefghijklmnopqrstuvwxyz"[AsetaKirja];
                nimi = nimi + Kirja;
                AsetaKirja = 5;
            }
            if (AsetaKirja == 5)
            {
                AsetaKirja = rand.Next(0, 26);
                char Kirja = "abcdefghijklmnopqrstuvwxyz"[AsetaKirja];
                nimi = nimi + Kirja;
                AsetaKirja = 6;
            }
            if (AsetaKirja == 6)
            {
                AsetaKirja = rand.Next(0, 26);
                char Kirja = "abcdefghijklmnopqrstuvwxyz"[AsetaKirja];
                nimi = nimi + Kirja;
                AsetaKirja = 7;
            }
            Console.Write(nimi);
        }
        public void AsetaElaimenika(int ika)
        {
            this.ikaEilain = ika;
            EilainTestIka.Add(ika);
        }
        public void AsetaElaimennimi(string nimi)
        {
            this.NimiEilain = nimi;
            EilainNimiTest.Add(nimi);
        }
        public void EilainNimi(string nimiEilain)
        {
            this.nimiEilain = nimiEilain;
            EilainNimiTest.Add(nimiEilain);
            
            
        }

        public void Eilainika(int ikaEilain)
        {

            this.ikaEilain = ikaEilain;
            EilainTestIka.Add(ikaEilain);
        }
        public string NIMIEilain
        {
            get
            {
                return nimiEilain;
            }

            set
            {
                nimiEilain = value;
            }
        }
        public int IKAEilain
        {
            get
            {
                return ikaEilain;
            }
            set
            {
                ikaEilain = value;
            }
        }
        public bool ONLihanSyoja
        {
            get
            {
                return onLihanSyoja;
            }
            set
            {
                onLihanSyoja = value;
            }
        }

        public string Nimi1 { get => Nimi; set => Nimi = value; }

        public virtual void Ääntele()
        {
            Console.WriteLine("umph");
        }
        public void Vaihe2()
        {
            int check;
            int ikä;
            check = 1;
            Random rand = new Random();
            
        for (int i=0; i < 22; i++)
            {
                if (check==1)
                {
                    Console.Write("Kissa"+" ikä: ");

                    ikä=rand.Next(1, 13);
                    
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    
                    Lihansyoja(true);
                    Console.WriteLine();
                    Console.Write("Koira" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(true);
                    Console.WriteLine();
                    Console.Write("Papukaija" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(false);
                    Console.WriteLine();
                    Console.Write("Hevonen" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(false);
                    Console.WriteLine();
                    check++;
                }
                else if (check == 2)
                {
                    Console.Write("Koira" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(true);
                    Console.WriteLine();
                    Console.Write("Papukaija" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(false);
                    Console.WriteLine();
                    Console.Write("Kissa" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(true);
                    Console.WriteLine();
                    Console.Write("Hevonen" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(false);
                    Console.WriteLine();
                    check++;
                }
                else if (check == 3)
                {

                    Console.Write("Papukaija" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(false);
                    Console.WriteLine();
                    Console.Write("Kissa" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(true);
                    Console.WriteLine();
                    Console.Write("Koira" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(true);
                    Console.WriteLine();
                    Console.Write("Hevonen" + " ikä: ");
                    ikä = rand.Next(1, 13);
                    Console.Write(ikä);
                    Console.Write(" Nimi: ");
                    AsetaNimi();
                    Lihansyoja(false);
                    Console.WriteLine();
                    check = 1;
                }

            }
        }
    }
}
