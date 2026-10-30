using System;

class Pracownik
{
    private decimal wynagrodzenie;
    protected string imie;
    internal string dzial;

    public Pracownik(string imie, string dzial, decimal wynagrodzenie)
    {
        this.imie = imie;
        this.dzial = dzial;
        this.wynagrodzenie = wynagrodzenie;
    }

    public void PokazDane()
    {
        Console.WriteLine("Imię: " + imie);
        Console.WriteLine("Dział: " + dzial);
        Console.WriteLine("Wynagrodzenie: " + wynagrodzenie + " zł");
    }

    public void ZmienWynagrodzenie(decimal kwota)
    {
        if (kwota > 0)
        {
            wynagrodzenie = kwota;
            Console.WriteLine("Zmieniono wynagrodzenie.");
        }
        else
        {
            Console.WriteLine("Wynagrodzenie musi być większe od zera.");
        }
    }
}

class Kierownik : Pracownik
{
    public Kierownik(string imie, string dzial, decimal wynagrodzenie)
        : base(imie, dzial, wynagrodzenie)
    {
    }

    public void PrzedstawSie()
    {
        Console.WriteLine("Jestem kierownikiem. Mam na imie " + imie + ".");
    }
}

class Program
{
    static void Main()
    {
        Pracownik pracownik1 = new Pracownik("Jan", "IT", 4500);
        Kierownik kierownik1 = new Kierownik("Anna", "Adminstracja", 7000);

        Console.WriteLine("-----PRACOWNIK-----");
        pracownik1.PokazDane();

        Console.WriteLine("\n-----KIEROWNIK-----");
        kierownik1.PokazDane();
        kierownik1.PrzedstawSie();

        Console.WriteLine("\n--ZMIANA WYNAGRODZENIA--");
        pracownik1.ZmienWynagrodzenie(5000);
        pracownik1.PokazDane();

        Console.WriteLine("\n--DOSTĘP DO POLA DZIAL--");
        Console.WriteLine("Dzial pracownika: " + pracownik1.dzial);
    }
}