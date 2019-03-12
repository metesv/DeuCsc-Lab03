using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList ListelerinEfendisi = new ArrayList();
            
            Dikucgen dikucgen = new Dikucgen(0, 0, 3, 4);
            Daire daire = new Daire(2, 2, 5);
            Dikdortgen dikdortgen = new Dikdortgen(3, 3, 5, 5);
            Object obje = new Object();

            ListelerinEfendisi.Add(dikucgen);
            ListelerinEfendisi.Add(daire);
            ListelerinEfendisi.Add(dikdortgen);
            ListelerinEfendisi.Add("deneme");
            ListelerinEfendisi.Add(17);
            ListelerinEfendisi.Add(obje);



            Yazdir(ListelerinEfendisi);
            Temizle(ListelerinEfendisi);
            Console.Read();
        }

       static void Yazdir(ArrayList diziListesi)
        {
            /*
             * Dizi listesinde Sekil olan her bir öğenin alan ve cevresini hesapla ve konsola yazdir. Örneğin;
             * Ucgen Alan: ** Cevre: **
             * Daire Alan:** Cevre:**
             * Dikdorgen Alan:** Cevre:**
             * Formatında...
             * İPUCU:
                if (obj is int) {
                     Console.WriteLine("Yuppi it is int!!!!");
                } else {
                    Console.WriteLine("not an int");
                 }
             */
             foreach(object element in diziListesi)
             {
                if (element is Dikucgen)
                {
                    Dikucgen dikucgen = (Dikucgen)element;
                    Console.WriteLine("Diküçgen Alan : {0} Çevre : {1}",dikucgen.AlanHesapla(),dikucgen.CevreHesapla());
                }
                else if (element is Daire)
                {
                    Daire daire = (Daire)element;
                    Console.WriteLine("Daire Alan : {0} Çevre : {1}",daire.AlanHesapla(),daire.CevreHesapla());
                }
                else if (element is Dikdortgen)
                {
                    Dikdortgen dikdortgen = (Dikdortgen)element;
                    Console.WriteLine("Dikdörtgen Alan : {0} Çevre : {1}",dikdortgen.AlanHesapla(),dikdortgen.CevreHesapla());
                }
                else
                {
                    Console.WriteLine("Sekil abstract class'ına dahil değildir.");
                }
             }
             
        }

        static void Temizle(ArrayList diziListesi)
        {
            /*
             * Dizi listesinde Sekil olmayan öğeleri listeden çıkar.
             */
              for(int i=0;i<diziListesi.Count;i++)
              {
                  if(!(diziListesi is Sekil))
                  {
                    diziListesi.RemoveAt(i);
                    i--;
                  }
              }

        }
    }
}
