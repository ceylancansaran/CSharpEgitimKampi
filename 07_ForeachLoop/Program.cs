using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //string[] cities = {"milano", "roma","budapeşte","ankara","istanbul"};
            //foreach (string c in cities)
            //{
            //    Console.WriteLine(c);
            //}


            //int[] numbers = { 12, 25, 963, 5698, 4523, 10394, 563 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //int[] numbers = { 12, 25, 963, 5698, 4523, 10394, 563 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}


            //int[] numbers = { 12, 25, 963, 5698, 4523, 10394, 563 };
            //int total = 0;
            //foreach (int i in numbers)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);


            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,5,656,8,82,56,86
            //};
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}


            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}


            #endregion

            #region For Örnek

            //Console.WriteLine("***** C# Eğitim Kampı Sınav notu Hesaplama ******");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("----------------------------------");

            //int studentCount;

            ////Sınıftaki öğrenci sayısı kullanıcıdan almaktadır
            //Console.WriteLine("Lütfen Sınıfınızdaki Öğrenci Sayısını Giriniz: ");
            //studentCount = int.Parse(Console.ReadLine());

            ////öğrenci isimlerini ve not ortalamalarının tutulacağı diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}.öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j+1}.sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("-------------------------------------") ;
            //}

            #endregion

            Console.Read();

        }
    }
}
