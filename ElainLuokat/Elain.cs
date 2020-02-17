using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
   public class Elain
    {
        private int ikaEilain;
        private string nimiEilain;
        private bool onLihanSyoja;
        private string Lihasyo;

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

    }
}
