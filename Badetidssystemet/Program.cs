using System;

namespace Badetidssystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            // BadetidsPeriode objekter
            BadetidsPeriode b1 = new BadetidsPeriode("Morgendukkert", DayOfWeek.Wednesday, new DateTime(2022, 07, 06, 07, 00, 00), new DateTime(2022, 07, 06, 08, 00, 00));
            BadetidsPeriode b2 = new BadetidsPeriode("Aftendukkert", DayOfWeek.Thursday, new DateTime(2022, 07, 07, 21, 00, 00), new DateTime(2022, 07, 07, 22, 00, 00));
            BadetidsPeriode b3 = new BadetidsPeriode("SøRæs", DayOfWeek.Friday, new DateTime(2022, 07, 08, 15, 30, 00), new DateTime(2022, 07, 08, 18, 30, 00));

            // Kreds objekter
            Kreds k1 = new Kreds("1", "København kredsen", "Roskildevej 2", 23);
            Kreds k2 = new Kreds("2", "Sydsjlælland kredsen", "Humlevej 22", 29);
            Kreds k3 = new Kreds("3", "Midtjylland kredsen", "Jyllandvej 2", 25);



            // Opgave 1: Test af ToString metoden på klassen Kreds
            Console.WriteLine(k1);
            Console.WriteLine();

            // Opgave 2: Test af ToString metoden på klassen Badetidsperiode
            Console.WriteLine(b1);

            // Opgave 4: Test af AdderKreds og SletKreds metoderne
            // Adder 2 kredse til b1 og b2 kollektionerne:
            b1.AdderKreds("1", k1);
            b1.AdderKreds("2", k2);
            b2.AdderKreds("1", k2);
            b2.AdderKreds("2", k3);

            Console.WriteLine(b1); //Tester ToString på b1 efter der er blevet added 2 objekter til dens collection
            Console.WriteLine();
            Console.WriteLine(b2); //Tester ToString på b1 efter der er blevet added 2 objekter til dens collection

            // Sletter kredsene fra kollektioerne b1 og b2:
            b1.SletKreds("2");
            b1.SletKreds("1");
            b2.SletKreds("2");
            b2.SletKreds("1");

            Console.WriteLine(b1); //Tester ToString på b1 efter der er blevet slettet 2 objekter til dens collection
            Console.WriteLine();
            Console.WriteLine(b2); //Tester ToString på b1 efter der er blevet slettet 2 objekter til dens collection

            // Opgave 6/7: Test validering

            BadetidsPeriode b4 = new BadetidsPeriode("Tes", DayOfWeek.Wednesday, new DateTime(2023, 07, 06, 05, 00, 00), new DateTime(2022, 07, 06, 04, 00, 00)); // Badetidsperiode objekt oprettet med starttidspunkt efter sluttidspunkt og "Type" på mindre end 4 bogstaver for at teste exception
            Console.WriteLine(b4);

            Kreds k4 = new Kreds("4", "Test kredsen", "Testvej 2", 0); // Kreds objekt oprettet med 0 deltagere for at teste exception
            Console.WriteLine(k4);
            Console.WriteLine();

            // Opgave 9: Implementering af user stories
            // User story 1:

            // Adder 2 kredse til b1 og b2 kollektionerne:
            b1.AdderKreds("1", k1);
            b1.AdderKreds("2", k2);
            b2.AdderKreds("1", k2);
            b2.AdderKreds("2", k3);

            // Opretter KredsLeder objekter og tilføjer dem til lister i kredse og tester ToStrings:
            KredsLeder kl1 = new KredsLeder(29, "Jonas", "Løve", true);
            KredsLeder kl2 = new KredsLeder(24, "Benjamin", "Fisk", false);
            KredsLeder kl3 = new KredsLeder(49, "Bent", "Vægt", false);
            k1.KredsLedere.Add(kl1);
            k1.KredsLedere.Add(kl2);
            k2.KredsLedere.Add(kl3);
            Console.WriteLine(k1);
            Console.WriteLine(k2);





            BadetidsPeriodeForLoopAndList b10 = new BadetidsPeriodeForLoopAndList("TestAfNedarvning", DayOfWeek.Friday, new DateTime(2022, 07, 08, 15, 30, 00), new DateTime(2022, 07, 08, 18, 30, 00));
            b10.AdderKreds("1", k1);
            b10.AdderKreds("2", k2);
            b10.AdderKreds("3", k3);
            Console.WriteLine(b10);







            Console.ReadKey();
        

        }
    }
}
