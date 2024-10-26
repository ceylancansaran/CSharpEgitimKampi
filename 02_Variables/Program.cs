using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            ////basamak belirtme sembolü olarak nokta kullanılıyor

            ////double number;
            ////number = 4.35;
            ////Console.WriteLine(number);

            //Console.WriteLine("****** Fiyat Listesi ******");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.75;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " TL");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " TL");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawTotalPrice = strawGram * strawberryPrice;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma +  " + "Birim Fiyat: " + applePrice + "Gramaj: " + appleGram + "Toplam Tutar: "  + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal  +  " + "Birim Fiyat: " + orangePrice + "Gramaj: " + orangeGram + "Toplam Tutar: "  + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek +  " + "Birim Fiyat: " + strawberryPrice + "Gramaj: " + strawGram + "Toplam Tutar: "  + strawTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates +  " + "Birim Fiyat: " + potatoPrice + "Gramaj: " + potatoGram + "Toplam Tutar: "  + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates +  " + "Birim Fiyat: " + tomatoPrice + "Gramaj: " + tomatoGram + "Toplam Tutar: "  + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Aliıveriş Toplam Tutar: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerAge, passengerCity, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş Bilgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC Bilgisi: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------");
            //Console.WriteLine("Yolcu TC:" + passengerIdentityNumber +  "Yolcu Adı: " + passengerName + " Yolcu Soyadı: " + passengerSurname + " Yolcu Yaş Bilgisi: " + passengerAge + " Yolcu Şehir Bilgisi: " + passengerCity + " Yolcu İlçe Bilgisi " + passengerDistrict);

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int shoesPrice, computerPrice, chairPrice, tvPrice;
            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;

            Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            Console.WriteLine();
            Console.WriteLine("Toplam Ödemeniz Gereken Değer: " + totalPrice + " ₺");


            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. Sınav Notunuz Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sınav Notunuz Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. Sınav Notunuz Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}
