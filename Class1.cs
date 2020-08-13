using System;
using System.Collections.Generic;
using System.Text;

namespace Fonskiyon_Cagirma
{
    class Class1
    {
        public static void DegerAl(int [] sayilar)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(sayilar[i]);

            }
            Class1 t = new Class1();
            t.Topla(sayilar);
        }
     private void Topla(int [] sayilar)
        {
          
            int toplam = 0;
            for (int i = 0; i < 5; i++)
            {
                toplam += sayilar[i];
            }


            Console.WriteLine("Dizi içindeki sayılarin toplamı: " + toplam);
        }
    }
}
