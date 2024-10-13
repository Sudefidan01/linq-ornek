using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _20230827_Linq_Ornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>()
            {
                25,6,38,456,2,63,754,23,45,67,12,78,-5,-68,-640,3
            };

            //Koleksiyon içerisindeki verileri linq yöntemi ile çekip ekrana yazdıralım
            var list = from s in sayilar select s;
            foreach (var item in list)
            {
                Console.Write(item +" ");
            }

            Console.WriteLine("\n\n----------\n");
            //Koleksiyon içerisindeki verileri küçükten büyüğe doğru sıralı bir şekilde yazdıralım
            var kbSayilar = from s in sayilar orderby s ascending select s;

            foreach (var item in kbSayilar) 
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n\n----------\n");

            //Koleksiyon içerisindeki verilerden 3'e bölünebilenleri ekrana yazdıralım
            var bolunen3 = from s
                           in sayilar
                           where s % 3 == 0
                           select s;
            foreach (var item in bolunen3)
            {
                Console.Write(item+ " ");
            }
            Console.WriteLine("\n\n----------\n");

            //Koleksiyon içerisindeki verilerden 4'e bölünüp 7'ye bölünmeyenleri büyükten küçüğe doğru sıralayalım
            var bolunen4 = from s
                         in sayilar
                           where s % 4 == 0  //where s %4 ==0 && where s%7!=0
                           where s % 7 != 0
                           orderby s descending
                           select s;
            foreach (var item in bolunen4)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n\n----------\n");
            //Koleksiyon içerisindeki verilerden 2'ye tam bölünebilen sayıların en büyüğünü ve en küçüğünü ekrana yazdıralım
            var bolunenSayi=(from s
                            in sayilar
                            where s %2==0
                            orderby s ascending
                            select s).ToList();
            Console.WriteLine("2'ye bölünebilen sayıların en büyüğü : " + bolunenSayi[bolunenSayi.Count-1]);
            Console.WriteLine("2'ye bölünebilen sayıların en küçüğü : " + bolunenSayi[0]);


            Console.ReadKey();
        }
    }
}
