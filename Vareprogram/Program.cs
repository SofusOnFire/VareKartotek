namespace Vareprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vare> vareListe = new List<Vare>();
            VareKartotek vareKartotek = new VareKartotek(vareListe);

            Vare vare1 = new Vare(1, "Lampe", 24.99, 3);
            Vare vare2 = new Vare(2, "Dyr pizza", 49.20, 56);
            Vare vare3 = new Vare(3, "Monster", 10, 6);

            vareKartotek.IndSaet(vare1);
            vareKartotek.IndSaet(vare2);
            vareKartotek.IndSaet(vare3);

            vareKartotek.PrintVare(2);
            Console.WriteLine("");
            Console.WriteLine(vareKartotek.BeregnVaerdi(vareKartotek));

            vareKartotek.Slet(3);
        }
    }
}
