using System;

namespace ProjectPetr2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string opakovani = "ano";
            while (opakovani == "ano")
            {
                Console.WriteLine("Vítej v početní hře <3");
                Console.Write("Teď si vyber početní akci v které chceš soutěžit, 1 = sčítání, 2 = odčítání, 3 = násobení, 4 = dělení: ");
                int pocetniakce;
                while (!int.TryParse(Console.ReadLine(), out pocetniakce) || pocetniakce > 4)
                    Console.Write("Neplatný vstup, prosím zadejte znovu: ");

                int kolo = 0;
                int score = 0;
                int pocetkol = 10;
                Console.WriteLine("Dobrá, teď tě čeká {0} příkladů <3", pocetkol);
                Random r = new Random();
                while (kolo < pocetkol)
                {
                    kolo++;
                    if (pocetniakce == 1)       //scitani
                    {
                        int scitani1 = r.Next(1, 101);
                        int scitani2 = r.Next(1, 101);
                        int scitanivysledekuzivatele;
                        while (scitani1 + scitani2 > 100)
                        {
                            scitani1 = r.Next(1, 101);
                            scitani2 = r.Next(1, 101);
                        }
                        int vysledekscitani = scitani1 + scitani2;
                        Console.Write("Kolik je {0} + {1} = ", scitani1, scitani2);
                        while (!int.TryParse(Console.ReadLine(), out scitanivysledekuzivatele))
                            Console.Write("Neplatný vstup, prosím zadejte znovu: ");

                        if (vysledekscitani == scitanivysledekuzivatele)
                        {
                            Console.WriteLine("Správný výsledek <3");
                            score++;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Špatný výsledek");
                            Console.WriteLine();
                        }
                        
                    }
                    else if (pocetniakce == 2)    //odcitani
                    {
                        int odcitani1 = r.Next(1, 101);
                        int odcitani2 = r.Next(1, 101);
                        int odcitanivysledek;
                        int odcitanivysledekuzivatele;
                        while (odcitani1 < odcitani2)
                        {
                            odcitani1 = r.Next(1, 101);
                            odcitani2 = r.Next(1, 101);
                        }
                        odcitanivysledek = odcitani1 - odcitani2;
                        Console.Write("Kolik je {0} - {1} = ", odcitani1, odcitani2);
                        while (!int.TryParse(Console.ReadLine(), out odcitanivysledekuzivatele))
                            Console.Write("Neplatný vstup, prosím zadejte znovu: ");
                        if (odcitanivysledek == odcitanivysledekuzivatele)
                        {
                            Console.WriteLine("Správný výsledek <3");
                            score++;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Špatný výsledek");
                            Console.WriteLine();
                        }

                    }
                    else if (pocetniakce == 3)     //nasobeni
                    {
                        int nasobeni1;
                        int nasobeni2;
                        int nasobenivysledek;
                        int nasobenivysledekuzivatele;
                        nasobeni1 = r.Next(1, 11);
                        nasobeni2 = r.Next(1, 11);
                        Console.Write("Kolik je {0} x {1} = ", nasobeni1, nasobeni2);
                        nasobenivysledek = nasobeni1 * nasobeni2;
                        while (!int.TryParse(Console.ReadLine(), out nasobenivysledekuzivatele))
                            Console.Write("Neplatný vstup, prosím zadejte znovu: ");
                        if (nasobenivysledek == nasobenivysledekuzivatele)
                        {
                            Console.WriteLine("Správný výsledek <3");
                            score++;
                            Console.WriteLine();
                        }
                        else
                            Console.WriteLine("Špatný výsledek");
                        Console.WriteLine();
                    }
                    else if (pocetniakce == 4)     //deleni je v pici, vyreseno
                    {
                        double deleni1 = r.Next(1, 101);
                        double deleni2 = r.Next(2, 11);
                        double vysledekdeleni = r.Next(2, 11);
                        int delenivysledekuzivatele;
                        while (deleni1 / deleni2 != vysledekdeleni)
                        {
                            deleni1 = r.Next(2, 101);
                            deleni2 = r.Next(2, 11);
                            vysledekdeleni = r.Next(2, 11);
                        }

                        Console.Write("Kolik je {0} : {1}: ", deleni1, deleni2);
                        while (!int.TryParse(Console.ReadLine(), out delenivysledekuzivatele))
                            Console.Write("Neplatný vstup, prosím zadejte znovu: ");

                        if (vysledekdeleni == delenivysledekuzivatele)
                        {
                            Console.WriteLine("Správný výsledek <3");
                            score++;
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Špatný výsledek");
                            Console.WriteLine();
                        }
                    }
                }
                Console.WriteLine("Tvoje konečné skóre je {0}/{1}", score, pocetkol);
                Console.Write("Chcete pokračovat [ano/ne]: ");
                opakovani = Console.ReadLine();
                opakovani = opakovani.ToLower();
                Console.Clear();
            }
            Console.WriteLine("Doufám že se vám aplikace líbila ☺, stiskni libovolnou klávesu pro ukončení");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
