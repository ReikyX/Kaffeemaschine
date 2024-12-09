using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffeemaschine
{
    internal class Kaffeemaschine
    {
        private int wasserstand;
        private int bohnenMenge;
        private static int maxWassermenge = 2000;
        private static int maxBohnenmenge = 500;

        public Kaffeemaschine(int wasserstand, int bohnenmenge)
        {
            this.wasserstand = wasserstand;
            this.bohnenMenge = bohnenmenge;
        }

        public int Wasserstand { get => wasserstand; set => wasserstand = value; }
        public int Bohnenmenge { get => bohnenMenge; set => bohnenMenge = value; }
        public static int MaxWassermenge { get => maxWassermenge; }
        public static int MaxBohnenmenge { get => maxBohnenmenge; }

        public void Wiederholen()
        {
            while (true)
            {
                Console.Clear();

                Menue();
                KaffeeMachen();
                WasserAuffuellen();
                BohnenAuffuelen();


                Console.ReadKey();
            }
        }
        public void Menue()
        {

        }
        public void WasserAuffuellen()
        {
            bool zurueck = true;
            int fuellmengeWasser = MaxWassermenge - this.Wasserstand;

            if (this.wasserstand <= 0)
            {
                while (zurueck)
                {
                    zurueck = true;
                    Console.WriteLine("Wollen sie den Wasserstand auffüllen? (j/n)");
                    string eingabe = Console.ReadLine().ToLower().Trim();
                    if (eingabe == "j")
                    {
                        this.wasserstand = 2000;
                        Console.WriteLine($"Ihr Wasserstand wurde wieder aufgefüllt. Stand: {this.wasserstand}ml");
                        zurueck = false;
                    }
                    else if (eingabe == "n")
                    {
                        Console.WriteLine("Schade! Aber dann gibt es auch kein Kaffee!");
                        zurueck = false;
                    }
                    else
                    {
                        Console.WriteLine("Keine gültige eingabe");
                    }
                }
            }
            else if (this.wasserstand < 2000)
            {
                Console.WriteLine($"Wasserstatus:\t\t{this.Wasserstand}ml");
                Console.WriteLine($"Aufzufüllende Menge:\t{fuellmengeWasser}ml.\n");
            }
            else
            {
                Console.WriteLine("Der Kaffeeautomat ist bereits voll.");
            }
        }
        public void BohnenAuffuelen()
        {
            bool zurueck = true;
            int fuellmengeBohnen = MaxBohnenmenge - this.Bohnenmenge;

            if (this.bohnenMenge <= 0)
            {
                while (zurueck)
                {
                    zurueck = true;
                    Console.WriteLine("Wollen sie den Bohnenstand auffüllen? (j/n)");
                    string eingabe = Console.ReadLine().ToLower().Trim();
                    if (eingabe == "j")
                    {
                        this.bohnenMenge = 500;
                        Console.WriteLine($"Ihr Bohnenstand wurde wieder aufgefüllt. Stand: {this.bohnenMenge}g");
                        zurueck = false;
                    }
                    else if (eingabe == "n")
                    {
                        Console.WriteLine("Schade! Aber dann gibt es auch kein Kaffee!");
                        zurueck = false;
                    }
                    else
                    {
                        Console.WriteLine("Keine gültige eingabe");
                    }
                }
            }
            else if (this.bohnenMenge < 500)
            {
                Console.WriteLine($"Bohnenstatus:\t\t{this.Bohnenmenge}g");
                Console.WriteLine($"Aufzufüllende Menge:\t{fuellmengeBohnen}g.\n");
            }
            else
            {
                Console.WriteLine("Der Kaffeeautomat ist bereits voll.");
            }
        }

        public void KaffeeMachen()
        {

            if (WasserstandPruefen() && BohnenstandPruefen())
            {
                this.Wasserstand -= 250;
                this.Bohnenmenge -= 14;
                Console.WriteLine("\nHier ist Ihr Kaffee!\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Füllen sie bitte die Kaffeemaschine auf!");
                Console.ResetColor();
            }
        }
        public bool WasserstandPruefen()
        {
            int benoetigtesWasser = 250;
            return this.wasserstand >= benoetigtesWasser;
        }
        public bool BohnenstandPruefen()
        {
            int benoetigteBohnen = 14;
            return this.bohnenMenge >= benoetigteBohnen;

        }

    }
}
