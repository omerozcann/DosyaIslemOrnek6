using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslemOrnek6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String secim = "", veri;
            Console.WriteLine("Ne yapmak istiyorsunuz Kayıt(K) / Listele(L) ?");
            secim = Console.ReadLine();
            if (secim == "K")
            {
                Console.WriteLine("Kaydedilecek Metni Yazınız:");
                veri = Console.ReadLine();
                File.AppendAllText("kayitlar.txt", veri);
                //AppendAllText: yoksa oluştur, varsa üzerine ekle şeklinde çalışır.
            }
            else if (secim == "L")
            {
                if (File.Exists("kayitlar.txt") == true)
                {//File.Exists belirtilen dosya varsa true, yoksa false cevabı verir
                    Console.WriteLine("Kayıtlı Verileriniz:");
                    veri = File.ReadAllText("kayitlar.txt");
                    Console.WriteLine(veri);
                }
            }
            else
            {
                Console.WriteLine("Yanlış seçim yaptınız!");
            }
        }
    }
}
