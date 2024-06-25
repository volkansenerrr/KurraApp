using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KurraApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan kaç kişinin katılacağını al
            Console.WriteLine("Kuraya kaç kişi katılacak?");
            int kisiSayisi = Convert.ToInt32(Console.ReadLine());

            // Konsolu temizle
            Console.Clear();

            // Kişi isimlerini tutmak için bir dizi oluştur
            string[] kisiler = new string[kisiSayisi];

            // Kullanıcıdan kişi isimlerini al
            for (int i = 0; i < kisiSayisi; i++)
            {
                Console.WriteLine("Kişi adı giriniz:");
                kisiler[i] = Console.ReadLine();
            }

            // Konsolu tekrar temizle
            Console.Clear();

            // Kayıt tamamlandı mesajı göster
            Console.WriteLine("Kayıt tamamlandı");

            // Rastgele sayı üretmek için Random sınıfından bir nesne oluştur
            Random rnd = new Random();

            // 0 ile dizi uzunluğu arasında rastgele bir index seç
            int index = rnd.Next(0, kisiler.Length);

            // Seçilen kişiyi ekrana yazdır
            Console.WriteLine("Seçilmiş olan = " + kisiler[index]);
        }
    }
}
