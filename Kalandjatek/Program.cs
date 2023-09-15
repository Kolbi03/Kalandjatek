using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kalandjatek
{
    internal class Program
    {
        static int hp = 50;
        static bool vege = false;

        static void utvonal()
        {
            Console.WriteLine("Merre szeretnél menni,a hosszú, de biztonságos hídon, vagy a rövidebb, de veszélyes úton? \n a = hídon    b = úton");
            char valasz = char.Parse(Console.ReadLine());

            if (valasz == 'a')
            {
                Console.WriteLine("Biztonságban vagy!");
                vege = true;
            }
            else if (valasz == 'b')
            {
                Console.WriteLine("Az úton mész tovább");
            }
            else
            {
                Console.WriteLine("Ilyen opció nincs!");
                vege = true;
            }
        }


        static int dobas()
        {
            Random rnd = new Random();
            int kocka = rnd.Next(1,7);
            Console.WriteLine("A dobás eredménye: " + kocka);
            return kocka;
        }

        static void tigris()
        {
            Console.WriteLine("Találokozol egy éhes tigrissel!");
            Console.WriteLine("Üss le egy billentyűt a dobáshoz");
            Console.ReadKey();

            int kocka = 1;

            while (kocka == 1)
            {
                kocka = dobas();
                if (kocka == 1)
                {
                    Console.WriteLine("Elvesztettél 8 életet!");
                    hp -= 8;
                    if (hp <= 0)
                    {
                        Console.WriteLine("A játéknak vége, vesztettél");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hátralévő életpontok: " + hp);
                        Console.WriteLine("Újra kell dobnod \n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Sikeresen továbbjutottál!\n");
                    Console.ReadKey();
                }
            }
        }

        static void folyo()
        {
            Console.WriteLine("Egy veszélyes folyó van előtted");
            Console.WriteLine("Üss le egy billentyűt a dobáshoz");
            Console.ReadKey();
            int kocka = 1;

            while (kocka == 1)
            {
                kocka = dobas();
                if (kocka == 1)
                {
                    Console.WriteLine("Elvesztettél 8 életet!");
                    hp -= 8;
                    if (hp <= 0)
                    {
                        Console.WriteLine("A játéknak vége, vesztettél");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hátralévő életpontok: " + hp);
                        Console.WriteLine("Újra kell dobnod \n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Sikeresen továbbjutottál!\n");
                    Console.ReadKey();
                }
            }
        }

        static void csapda()
        {
            Console.WriteLine("Egy csapda van előtted");
            Console.WriteLine("Üss le egy billentyűt a dobáshoz");
            Console.ReadKey();
            int kocka = 1;

            while (kocka == 1)
            {
                kocka = dobas();
                if (kocka == 1)
                {
                    Console.WriteLine("Elvesztettél 8 életet!");
                    hp -= 8;
                    if (hp <= 0)
                    {
                        Console.WriteLine("A játéknak vége, vesztettél");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hátralévő életpontok: " + hp);
                        Console.WriteLine("Újra kell dobnod \n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Sikeresen továbbjutottál!\n");
                    Console.ReadKey();
                }
            }
        }

        static void jungle()
        {
            Console.WriteLine("A dzsungel legmélyebb bugyraiban vagy");
            Console.WriteLine("Üss le egy billentyűt a dobáshoz");
            Console.ReadKey();
            int kocka = 1;

            while (kocka == 1)
            {
                kocka = dobas();
                if (kocka == 1)
                {
                    Console.WriteLine("Elvesztettél 8 életet!");
                    hp -= 8;
                    if (hp <= 0)
                    {
                        Console.WriteLine("A játéknak vége, vesztettél");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hátralévő életpontok: " + hp);
                        Console.WriteLine("Újra kell dobnod \n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Sikeresen továbbjutottál!\n");
                    Console.ReadKey();
                }
            }
        }

        static void kigyo()
        {
            Console.WriteLine("Egy mérgező kígyó van előtted");
            Console.WriteLine("Üss le egy billentyűt a dobáshoz");
            Console.ReadKey();
            int kocka = 1;

            while (kocka == 1)
            {
                kocka = dobas();
                if (kocka == 1)
                {
                    Console.WriteLine("Elvesztettél 8 életet!");
                    hp -= 8;
                    if (hp <= 0)
                    {
                        Console.WriteLine("A játéknak vége, vesztettél");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Hátralévő életpontok: " + hp);
                        Console.WriteLine("Újra kell dobnod \n");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Sikeresen továbbjutottál!\n");
                    Console.ReadKey();
                }
            }
        }
        

        static void Main(string[] args)
        {
            utvonal();

                if (vege == false)
                {
                    tigris();
                    folyo();
                    csapda();
                    jungle();
                    kigyo();
                }
            Console.WriteLine("Gratulálok, kijutottál a dzsungelből!");

            Console.ReadKey();
        }
    }
}

// Lengyel Milán 2/14S
