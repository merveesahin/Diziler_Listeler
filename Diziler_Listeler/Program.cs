using System;
using System.Collections.Generic;

namespace Diziler_Listeler
{
    class Program
    {
        public struct Personel
        {
            public string Ad;
            public string Soyad;
            public int PersonelId;

        }
        static void Main(string[] args)
        {
            //İki Boyutlu Diziler
            int[] IlkSınavNotları = new int[5] { 50, 65, 84, 29, 62 };
            // 2 numaralı öğrencinin sınav notunu öğrenmek için:
            Console.WriteLine(IlkSınavNotları[2]);

            int[,] SınavNotları = new int[5, 2] { { 50, 74 }, { 65, 40 }, { 84, 90 }, { 29, 78 }, { 62, 55 } };
            // 2 numaralı öğrencinin ikinci sınav notunu öğrenmek için:
            Console.WriteLine(SınavNotları [2,1]);

            //Collection Yapılar >>Diziler ve Listeler
            
            //Diziler
            Personel[] personel = new Personel[3];
            personel[0].Ad = "Merve";
            personel[0].Soyad = "Şahin";
            personel[0].PersonelId = 1;

            personel[1].Ad = "Mustafa";
            personel[1].Soyad = "Hiçyılmaz";
            personel[1].PersonelId = 2;
            
            personel[2].Ad = "x";
            personel[2].Soyad = "y";
            personel[2].PersonelId = 3;

            for (int i = 0; i < personel.Length; i++)
            {
                Console.WriteLine(i+1 + ". Personel İsmi:" + personel[i].Ad + " " + "Personel Soyad: " + personel[i].Soyad+" " + 
                    "Personel Id:" + personel[i].PersonelId);
            }

            Console.WriteLine();
            Console.WriteLine("****************************");

            //Listeler
            List<Personel> PersonelList = new List<Personel>();
            
            Personel Ilk;
            Ilk.Ad = "Ali";
            Ilk.Soyad = "Ek";
            Ilk.PersonelId = 55;

            Personel Ikıncı;
            Ikıncı.Ad = "Zeynep";
            Ikıncı.Soyad = "Koç";
            Ikıncı.PersonelId = 66;

            Personel Ucuncu;
            Ucuncu.Ad = "Sıla";
            Ucuncu.Soyad = "Kaya";
            Ucuncu.PersonelId = 77;

            PersonelList.Add(Ilk);
            PersonelList.Add(Ikıncı);
            PersonelList.Add(Ucuncu);

            foreach (Personel pers in PersonelList)
            {
                Console.WriteLine("Personel İsmi: " + pers.Ad +" "+ "Personel Soyismi: " + pers.Soyad +" "+ 
                    "Personel Id: " + pers.PersonelId);
            }

            Console.WriteLine();
            Console.WriteLine("*****************"); 

            //While, Do-While

            //Do-While Örnek
            int a = 5;
            do
            {
                Console.WriteLine(a);
                a++;

            } while (a < 4);

            Console.WriteLine();
            Console.WriteLine("****************");

            int toplam = 0;
            int sayii;
            do
            {
                Console.WriteLine("sayı: ");
                sayii = int.Parse(Console.ReadLine());

                toplam += sayii;

            } while (sayii != 0);

            Console.WriteLine(toplam);

            //While Örnek
            int orneksayı = 0;
            int ornektoplam = 0;
            while (orneksayı <= 100) 
            {
                if (orneksayı % 2 == 1)
                    toplam += orneksayı;
                orneksayı++;
            }
            Console.WriteLine("Tek Sayıların Toplamı: " + toplam);
            


        }
    }
}
