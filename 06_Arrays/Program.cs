using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];
            //colors[0] = "Red";
            //colors[1] = "Yellow";
            //colors[2] = "White";
            //colors[3] = "Blue";

            //Console.WriteLine(colors[2]);


            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Belgrad";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);


            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 24;
            //numbers[3] = 62;
            //numbers[7] = 18;

            //Console.WriteLine(numbers[7]);


            //string[] cities = { "Prag", "Roma", "Atina", "İstanbul" };
            //Console.WriteLine(cities[2]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme 

            //string[] colors = {"yellow", "red", "blue", "pink", "brown","green", "grey", "black","white" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}



            //int[] numbers = { 4, 85, 64, 23, 159, 789, 654, 153, 258, 954 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            //char[] symbls = { 'a', 'b', '*', '-', 'k' };
            //for (int i = 0; i < symbls.Length; i++)
            //{
            //    Console.WriteLine(symbls[i]);
            //}



            //int[] myArray = { 47, 85, 95, 64, 25, 63, 100, 852, 951, 736, 6512 };
            //int maxNumber = myArray[0];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            #endregion

            #region Dizi Metotları

            //string[] persons = { "Ali", "Ayşe", "Deniz", "Buse", "Cem" };
            //Console.WriteLine(persons.Length);


            //int[] numbers = { 1, 2, 10, 20, 85, 13, 24 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 1, 2, 10, 20, 85, 13, 24 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //string[] customers = { "Ali", "Buse", "Beyza", "Ceylan" };
            //int index = Array.IndexOf(customers, "Ceylan");
            //Console.WriteLine(index);



            //int[] numbers = { 45, 85, 96, 63, 74, 10, 25, 22, 36 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + " Dizinin En Küçük Elemanı: " + numbers.Min());


            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine($"Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}



            //int[] numbers = {10,20,30,52,65,9,85,74,72,30,61 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);



            //int[] numbers = { 1, 3, 5, 89, 64, 10, 20, 54, 84, 82, 30, 63, 21, 17, 19 };
            //Console.WriteLine("Çift Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);                   
            //    }
            //}
            //Console.WriteLine();

            //Console.WriteLine("Tek Sayılar");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion

            Console.Read();
        }
    }
}
