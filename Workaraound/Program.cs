using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Workaraound
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuç = Topla(3, 5);

            //Diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Derin";
            string ogrenci3 = "Salih";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Derin";
            ogrenciler[2] = "Salih";
            ogrenciler = new string[4];
            ogrenciler[3] = "Hazar";


            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new string[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[2]);

            Person person1 = new Person();
            person1.FirstName = "Engin";

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
                 
            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuç = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuç);
            return sonuç;
        }

    }
}