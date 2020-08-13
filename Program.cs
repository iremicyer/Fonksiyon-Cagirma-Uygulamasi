using System;

namespace Fonskiyon_Cagirma
{
    // İŞLEM 1: Class1 oluşturuldu.
    // İŞLEM 2: ekrandan 5 tane int değer alındı.
    // İŞLEM 3: alınan değerler 2. class' ta ki DegerAl(9 fonksiyonuna gönderildi.
    // İŞLEM 4: Class1' de private Topla() metodu oluşturuldu.
    // İŞLEM 5: DegerAl() fonskitonu Topla() fonskiyonuna gönderildi.
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] sayilar = new int[5];

            // fonksiyon çağırma işlemini dizi tanımladıktan sonra yapmalıyız. Aksi takdirde hata alırız.

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Bir sayi giriniz:");

                sayilar[i] = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("-----------------------------------------");
            }

            Class1.DegerAl(sayilar); // sayilar dizisi içindeki değerleri Class1' de ki DegerAl() fonksiyonuna gönderiyoruz.


            



        }
    }
}
