using manav_poroje;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _poroje
{
    internal class Program
    {
        private static readonly int _secim;
        private static int int_secim;

        public static object Manav_Sebze_list { get; private set; }

        static void Main(string[] args, List<manav_Sebze> Manav_sebze_list, object manav_Sebze_list)
        {
            Console.WriteLine("---------------------HOŞ GELDİNİZ---------------------------");
            List<Manav_meyve> Manav_Meyve_list = new List<Manav_meyve>();
            Random rnd = new Random();
            List<string> Hal_meyve = new List<string> { "Elma", "Armut", "Karpuz", "Muz" };
            List<string> Hal_sebze = new List<string> { "Domates", "Biber", "Patlıan", "Salatalık" };
            List<int> Hal_meyve_kg = new List<int> { rnd.Next(10, 50), rnd.Next(10, 50), rnd.Next(10, 50), rnd.Next(10, 50) };
            List<int> Hal_sebze_kg = new List<int> { rnd.Next(10, 50), rnd.Next(10, 50), rnd.Next(10, 50), rnd.Next(10, 50) };

            while (true)
            {
                Manav_sebze manav_sebze = new Manav_sebze();
                Manav_meyve manav_meyve = new Manav_meyve();
                Console.WriteLine("1-Manav OL HALE GİT\n2-Müşteri ol Manava git\n3-Çıkış Yap");
                int secim = int.Parse(Console.ReadLine());
                if (secim == 1)
                {
                    Console.Clear();
                    Console.WriteLine("1-Halin meyve listesini göster\n2-Halin sebze Listesini Göster\n3-Ana Menüye Dön");
                    int secim0 = int.Parse(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.Clear();
                        for (int i = 0; i < Hal_meyve.Count; i++)
                        {
                            Console.WriteLine(i + 1 + "-" + Hal_meyve[i] + Hal_meyve_kg[i]);
                        }
                        Console.WriteLine("--------------------------------------------------------");
                    }
                    else if (secim == 2)
                    {
                        Console.Clear();
                        for (int i = 0; i < Hal_sebze.Count; i++)
                        {
                            Console.WriteLine(i + 1 + "-" + Hal_sebze[i] + Hal_sebze_kg[i]);
                        }
                        Console.WriteLine("-----------------------------------------------------------");
                    }

                    else if (secim == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("ANA MENÜYE DÖNÜNÜZ");
                        Console.WriteLine("------------------------------------");
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("HATALI TUŞLAMA YAPTINIZ");
                        Console.WriteLine("------------------------");
                    }
                }
                // Manav Kısmı
                else if (secim == 2)
                {
                    Console.Clear();
                    Console.WriteLine("1-Manavın meyve listesini göster\n2-Manavın Sebze Listesini Göster\n3-ANA MENÜYE DÖN");
                    int_secim = int.Parse(Console.ReadLine());
                    if (secim == 1)
                    {
                        Console.Clear();
                        for (int i = 0; i < Manav_Meyve_list.Count; i++)
                        {
                            Console.WriteLine(i + 1 + "-" + Manav_Meyve_list[i] + Manav_Meyve_list[i]);
                        }
                        Console.WriteLine("-------------------------------");
                    }
                    if (secim == 2)
                    {
                        Console.Clear();
                        for (int i = 0; i < Manav_sebze_list.Count; i++)
                        {
                            Console.WriteLine(i + 1 + "-" + Manav_sebze_list[i] + Manav_sebze_list[i]);
                        }

                        Console.WriteLine("-----------------------------------");
                    }
                    else if (_secim == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("ANA MENÜYE DÖNÜNÜZ");
                        Console.WriteLine("--------------------------------------");
                        continue;

                    }
                }
                else if (secim == 4)
                {
                    Console.WriteLine("ÇIKIŞ YAPTINIZ");
                    break;
                }
                else { Console.WriteLine("Hatalı giriş yaptınız bir daha dene");}
            }
            Console.ReadLine();
        }
    }

}
