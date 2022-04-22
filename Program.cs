using System;
    namespace diziler
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("**********Dizi Tanimlama***************");
                //dizi Tanimlama
                string [] renkler = new string[5];

                string[] hayvanlar = {"Kedi","Kopek","Kus","Fil"};

                int [] dizi;
                dizi = new int[5];
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("*********Dizilere Deger Atama ve Erisim************");
                //Dizilere deger atama ve erisim

                renkler[0]= "mavi";
                Console.WriteLine(hayvanlar[1]);
                dizi[3]= 10;

                Console.WriteLine(dizi[3]);
                Console.WriteLine(hayvanlar[3]);
                Console.WriteLine(renkler[0]);
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("*********Dongulerle Dizi Kullanimi************");
                
                //Klavyeden girilen n tane sayinin ortalamasini hesaplayan program
                Console.WriteLine("Lutfen dizinin eleman sayisini giriniz:");
                int diziUzunlugu = int.Parse(Console.ReadLine());
                int[] sayiDizisi = new int[diziUzunlugu];

                for (int i = 0; i < diziUzunlugu; i++)
                {
                    Console.Write("Lutfen {0}. sayisini giriniz", i+1);
                    sayiDizisi[i] = int.Parse(Console.ReadLine());
                }

                int toplam = 0;
                foreach (var sayi in sayiDizisi)
                {
                    toplam +=sayi;
                }
                Console.WriteLine("Ortalama :"+ toplam/diziUzunlugu);


            }
        }
    }
