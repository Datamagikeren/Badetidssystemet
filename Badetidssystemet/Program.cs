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






            Console.ReadKey();
        

        }
    }
}
