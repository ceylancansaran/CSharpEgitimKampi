using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Geriye Değer Döndürmeyen Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Öztürk");
            //    Console.WriteLine("Merve Çınar");
            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}

            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli String Metotlar

            //void WriteMetot(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMetot("Ceylan Cansaran");


            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+ name + " " + surName);
            //}

            //CustomerCard("Mehmet","Yıldız");
            //CustomerCard("Ayşegül","Kaya");

            #endregion

            #region Geriye Değer Döndürmeyen int Paramtreli Metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2+ number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1,3,5);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();


            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());




            #endregion

            #region Geriye Değer Döndüren Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));


            #endregion

            #region Geriye Değer Döndüren Int parametreli Metotlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(3,5));
            //Console.WriteLine(Sum(56, 67));
            //Console.WriteLine(Sum(36, 89));
            //Console.WriteLine(Sum(48, 67));


            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result>=50)
                {
                    return student + " isimli Öğrenci Sınavı Geçti" + "Ortalama: " + result;
                }
                else
                {
                    return student + " isimli Öğrenci Sınavı Geçemedi" + "Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Ahmet", 25, 41, 85));
            Console.WriteLine(ExamResult("Ali", 36, 88, 23));


            #endregion

            Console.Read();

        }
    }
}
