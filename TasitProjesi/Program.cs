using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tasit;

namespace TasitProjesi
{
    
    class Program
    {
        static void Main(string[] args)
        {
                    
            Console.WriteLine("Kaç tane taşıt girmek istediğinizi yazınız.");
            int girilecek_arac_sayisi = int.Parse(Console.ReadLine());
            Araba[] dizi = new Araba[girilecek_arac_sayisi];
            for (int i = 0; i < girilecek_arac_sayisi; i++)
            {             
                Araba araba = new Araba();
                Console.WriteLine("Taşıt tipi giriniz.");
                araba.TasitTipi = Console.ReadLine();
                Console.WriteLine("Aracınızın markasını giriniz.");
                araba.Marka = Console.ReadLine();
                Console.WriteLine("Aracınızın model giriniz.");
                araba.Model = Console.ReadLine();
                Console.WriteLine("Aracınızın fiyatını giriniz.");
                araba.Fiyati = int.Parse(Console.ReadLine());
                dizi[i] = araba;    
            }
            using (FileStream kaydet = new FileStream(@"C:\Tasit\Bilgi.txt", FileMode.Append))
            {
                using (StreamWriter yazdir = new StreamWriter(kaydet))
                {
                    for (int i = 0; i < dizi.Length; i++)
                    {

                        yazdir.WriteLine(dizi[i].TasitBilgiYazdir());
                        yazdir.WriteLine("-------------------------------");
                    }        
                }
            }
        }
    }
}
