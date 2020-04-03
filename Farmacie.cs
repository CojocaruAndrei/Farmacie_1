using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmacie_1
{
    class Farmacie
    {
        public const int LESS = -1;
        public const int MORE = 1;
        public const int EQUAL = 0;
        private int medID;
        private string medNume;
        private int medPret;
        private int medNr;
        private int x;

        public int MedID { get => medID; set => medID = value; }
        public string MedNume { get => medNume; set => medNume = value; }
        public int MedPret { get => medPret; set => medPret = value; }
        public int MedNr { get => medNr; set => medNr = value; }
        public int X { get => x; set => x = value; }

        public Farmacie()
        {
            MedID = 0;
            MedNume = null;
            MedPret = 0;
            MedNr = 0;

        }
        public Farmacie(int id, string nume, int pret, int numar)
        {
            MedID = id;
            MedNume = nume;
            MedPret = pret;
            MedNr = numar;
        }
        public Farmacie(string linie)
        {
            string[] componente = linie.Split(',');
            MedID = int.Parse(componente[0]);
            MedNume = componente[1];
            MedPret = int.Parse(componente[2]);
            MedNr = int.Parse(componente[3]);
        }
        public override string ToString()
        {
           return string.Format("Medicament ID :{0}\n" +
                "Medicamentul :{1}\n" +
                "Pretul :{2}\n" +
                "Numarul :{3}\n " 
                , MedID, MedNume,MedPret,MedNr);
        }
        public static int Compara(Farmacie f1,Farmacie f2)
        {
            return string.Compare(f1.medNume, f2.medNume);
        }
    }
}
