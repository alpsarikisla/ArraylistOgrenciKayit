using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraylistOgrenciKayit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ogrenciler = new ArrayList();

            string secenek = "e";

            while (secenek == "e")
            {
                Ogrenci ogr = new Ogrenci();
                Console.WriteLine("Lütfen öğrenci adını giriniz");
                ogr.Isim = Console.ReadLine();

                Console.WriteLine("Lütfen öğrenci soyadını giriniz");
                ogr.Soyisim = Console.ReadLine();

                Console.WriteLine("Lütfen öğrenci numarasını giriniz");
                ogr.OkulNo = Convert.ToInt32(Console.ReadLine());
                ogrenciler.Add(ogr);
                Console.WriteLine("Öğrenci eklemeye devam edilsin mi? e/h");
                secenek = Console.ReadLine();
            }
            Console.WriteLine("*-*-*-*-Öğrenciler-*-*-*-*");
            for (int i = 0; i < ogrenciler.Count; i++)
            {
                Ogrenci veri = (Ogrenci)ogrenciler[i];
                Console.WriteLine("No = " + veri.OkulNo + ") " + veri.Isim + " " + veri.Soyisim );
            }
        }
    }
    class Ogrenci
    {
        public int OkulNo { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }
    }
}
