using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //int sayi1, sayi2;
            //Console.WriteLine("Bir değer giriniz:");
            //sayi1 = int.Parse(Console.ReadLine());
            //sayi2 = 15;

            //if (sayi1 == sayi2)
            //{
            //    Console.WriteLine("Girilen sayı ile sayi2 birbirine eşittir.");
            //}
            //else
            //{
            //    Console.WriteLine("Girilen sayı ile sayi2 birbirine eşit değildir.");

            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler doğrulandı.");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı bilgi");
            //}

            //int sayi;
            //Console.Write("Sayıyı Giriniz: ");
            //sayi = int.Parse(Console.ReadLine());
            //if (sayi == 5)
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else {
            //    Console.WriteLine("Sayı Hatalı");
            //        }

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);


            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuç çok kötü";
            //}
            //else if (average > 50 & average <= 70)
            //{
            //    result = "Sonuç orta";
            //}
            //else if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç iyi";
            //}
            //else if (average > 84)
            //{
            //    result = "Sonuç çok iyi";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.WriteLine("Lütfen Şehir Giriniz: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankra" | city == "bursa" | city =="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            //Console.WriteLine("Kullanıcı adınızı giriniz: ");
            //string userName = Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("hoş geldiniz");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.WriteLine("1. Sayıyı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;
            //Console.WriteLine("1. Sayının 2. Sayıya Bölümünden Kalan: " + result);

            //Console.WriteLine("Lütfen Sayıyı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0 )
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir.");
            //}

            #endregion

            #region  Char Değişkenler ile Kara Yapıları


            //char team;
            //Console.WriteLine("Takım harfinizi giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Takımınız galatasaray");
            //}
            //else if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Takımınız fenerbahçe");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Takımınız beşiktaş");
            //}
            //else { Console.WriteLine("Takımınız listede yok"); }

            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran ******");
            //Console.WriteLine();
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.WriteLine("Detayını görmek istediğiniz menü seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Ana Yemekler ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Körü Soslu Tava");
            //    Console.WriteLine("2-Kızartılmış Tavuk");
            //    Console.WriteLine("3-Fırında Somon");
            //    Console.WriteLine("4-Kuru Fasulye Pilav");
            //    Console.WriteLine("5-Bonfile");
            //    Console.WriteLine("-------------- Ana Yemekler ---------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Çorbalar ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Domates");
            //    Console.WriteLine("2-Mercimek");
            //    Console.WriteLine("3-Tarhana");
            //    Console.WriteLine("4-Brokoli");
            //    Console.WriteLine("5-işkembe");
            //    Console.WriteLine("-------------- Çorbalar ---------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Pizzalar ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Margarita");
            //    Console.WriteLine("2-Karışık");
            //    Console.WriteLine("3-Akdeniz");
            //    Console.WriteLine("4-3 peynirli");
            //    Console.WriteLine("-------------- Pizzalar ---------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- İçecekler ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Su");
            //    Console.WriteLine("4-Sprite");
            //    Console.WriteLine("5-Şalgam");
            //    Console.WriteLine("-------------- İçecekler ---------------");

            //    Console.WriteLine();

            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("-------------- Tatlılar ---------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kazandibi");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Ekmek Kadayıfı");
            //    Console.WriteLine("4-Sütlaç");
            //    Console.WriteLine("5-Künefe");
            //    Console.WriteLine("-------------- Tatlılar ---------------");

            //    Console.WriteLine();

            //}


            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1: Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Temmuz"); break;
            //    case 8: Console.WriteLine("Ağustos"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi");
            //        break;
            //}


            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1. Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Carpım: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //}


            #endregion

            Console.Read();

        }
    }
}
