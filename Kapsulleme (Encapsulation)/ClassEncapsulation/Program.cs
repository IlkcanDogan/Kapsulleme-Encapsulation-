using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Kodlayan: İlkcan Doğan
 * Tarih: 22.06.2018
 */
namespace ClassEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Field Kapsülleme";
            #region Ogrenci_Sinifi
            Ogrenci ogr = new Ogrenci();
            ogr.ad = "İlkcan";
            Console.WriteLine("İsim: " + ogr.ad);

            ogr.cinsiyet = true;
            Console.WriteLine("Uyruk: " + ogr.uyruk);

            ogr.vize = 130; 
            Console.WriteLine("Vize Değeri: " + ogr.vize);
            /*130 değerini verdik fakat vizenin propertysinde  biz 0 ile
              100 arasında bir değer girilmesini istedik. Sonuç olarak
              130 verilemeyeceği için 0 olarak kabul edecektir.
            */

            ogr.final = 80;
            Console.WriteLine("Final Değeri: " + ogr.final);

            Console.WriteLine("Ortalama: " + ogr.ortalama);

            Console.WriteLine(ogr.basari());
            #endregion
            Console.WriteLine("\n");
            #region Bilgisayar_Sinifi
            Console.Title = "Example Encapsulation";

            Bilgisayar bg = new Bilgisayar();
            bg.Marka = null;
            bg.Model = null;
            bg.Islemci = 4;
            bg.Ram = 8;
           
            

            Console.WriteLine("Marka: {0}\nModel: {1}\nİşlemci Sayısı: {2}\nRAM Bellek: {3}\nKontrol Tarihi: {4}"
                , bg.Marka, bg.Model, bg.Islemci, bg.Ram, bg.Kontrol_Tarih);
            #endregion


            Console.ReadLine();
        }
    }
}
