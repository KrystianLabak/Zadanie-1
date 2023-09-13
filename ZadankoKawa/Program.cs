//Zadanko na ogarniecie klas i obiektowości: Stwórz klasę o nazwie Kawa, napisz w niej właściwości klasy opisujące Kawę (np. ilość espresso, ilość mleka), napisz konstruktor bezparametrowy, konstruktor z parametrami, konstruktor kopiujący, napisz metody które pozwolą na wybranie użytkownikowi kawy z  wybraną przez nich ilością espresso oraz mleka, uwzględnij wartości domyślne (1 espresso na np. 150 ml mleka) oraz dodatków w postaci (bita śmietana, syrop smakowy itp.) 

// 1) Wyjaśnij po co są konstruktory
// 2) Wywołaj klasę Kawa i wykorzystaj stworzone metody
// 3) Zadbaj o prawidłową widoczność elementów klasy 
// 4) Dodaj enuma np. Dodatki - pozwalający na wybór ograniczonych dodatków 
//Potem: Zbadaj czym jest dziedziczenie i polimorfizm -> YT + przedstawienie zrealizowanego zadania ---- cel następnego spotkania 

using ZadankoKawa;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Podaj ilosc espresso: ");
            int iloscEspresso = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Podaj ilość mleka (ml): ");
            int iloscMleka = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chcesz dodatki? 1 = Brak, 2 = Bita Smietana, 3 = Syrop Smakowy");
            Dodatki dodatek = (Dodatki)Enum.Parse(typeof(Dodatki),Console.ReadLine());

            Kawa kawa = new Kawa(iloscEspresso, iloscMleka, dodatek);
            kawa.PrzygotujKawe();

            Kawa kawa2 = new Kawa();
            kawa2.PrzygotujKawe();

            Kawa kawa3 = new Kawa(kawa);
            kawa3.PrzygotujKawe();

        }
    }
}