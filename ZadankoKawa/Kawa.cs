using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZadankoKawa
{
    enum Dodatki
    {
        Brak = 1, // default id 0
        BitaSmietana, // default id 1
        SyropSmakowy // default id 2
    }

    class Kawa
    {   
        private int IloscEsspresso { get; set; }
        private int IloscMleka { get; set; }
        private Dodatki Dodatek  { get; set; }


        public Kawa(int iloscEsspresso, int iloscMleka, Dodatki dodatek)
        {
            IloscEsspresso = iloscEsspresso;
            IloscMleka = iloscMleka;
            Dodatek = dodatek;
        }
        public Kawa()
        {
            IloscEsspresso = 1;
            IloscMleka = 150;
            Dodatek = Dodatki.Brak;
        }

        public Kawa(Kawa innaKawa)
        {
            IloscEsspresso = innaKawa.IloscEsspresso;
            IloscMleka = innaKawa.IloscMleka;
            Dodatek = innaKawa.Dodatek;
        }

        public void PrzygotujKawe()
        {
            Console.WriteLine("Robie kawe");
            Console.WriteLine("Ilość esspresso:" + IloscEsspresso);
            Console.WriteLine("Ilosc mleka" + IloscMleka);
            Console.WriteLine("Dodatki: " + Dodatek);
            Console.WriteLine("Gotowe");
        }
    }
}
