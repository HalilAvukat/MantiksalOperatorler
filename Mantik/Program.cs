using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mantik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Karşılaştırma operatörleriyle birlikte kullanılabilir
            //Amacı birden çok soruya tek bir cevap üretmektir
            int sayi = 12;

            //sayi değişkeni içindeki veri 10 ile 20 arasında mı?
            //Bu soruyu sayı 10 dan büyük mü sayı 20 den küçük mü şeklinde ele alabilir
            //ve iki soruyada true sonuç verir ise sonucun true olmasını bekleriz
            
            //ve &&             Veya ||
            //T && T = T        T || F = T
            //T && F = F        T || F = T
            //F && T = F        F || T = T
            //F && F = F        F || F = F


            bool araliktami = sayi > 10 && sayi < 20;
            //sayı 10'dan büyük mü ve sayı 20 den küçük mü?
            //Mantık operatörlerinin sağ ve sol tarafları boolean veri
            //üretmelidir.
            Console.WriteLine("Sayı = " + sayi);
            Console.Write("Sayı 10 ile 20 arasında mı = ");
            Console.WriteLine(araliktami);

            //Sayı değişkeni içerisindeki veri 10 ile 20 aralığı dışında mı ? 
            bool aralikdisimi = sayi < 10 || sayi > 20;
            Console.Write("Sayı 10 ile 20 aralığı dışında mı = ");
            Console.WriteLine(aralikdisimi);

            bool aralikdisimi2 = !(sayi > 10 && sayi <20);
            Console.Write("Sayı 10 ile 20 aralığı dışında  mı = ");
            Console.WriteLine(aralikdisimi2);
        }
    }
}
