using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Crud işlemleri

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------");

            #region Kategori Tablosuna Veri Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H8KFKNA;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine($"{categoryName} isimli kategori başarıyla eklendi!");

            #endregion

            #region Ürün Tablosuna Veri Ekleme İşlemi

            //Console.Write("Eklemek istediğiniz ürün adını giriniz: ");
            //string productName = Console.ReadLine();

            //Console.Write("Eklemek istediğiniz ürün fiyatını giriniz: ");
            //double productPrice = Double.Parse(Console.ReadLine());

            ////Console.Write("Eklemek istediğiniz ürünün durumunu giriniz: ");
            ////bool productStatus = Boolean.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H8KFKNA;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (productName,productPrice,productStatus) values (@p1,@p2,@p3)",connection);
            //command.Parameters.AddWithValue("@p1", productName);
            //command.Parameters.AddWithValue("@p2",productPrice);
            //command.Parameters.AddWithValue("@p3",true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine($"{productName} isimli ürün başarılı şekilde eklenmiştir.");

            #endregion

            #region ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H8KFKNA;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();            

            #endregion

            #region ürün Silme İşlemi

            //Console.Write("Silinecek ürün ID giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H8KFKNA;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("delete from TblProduct where ProductId = @productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine($"{productId} ID li ürün başarılı şekilde silindi!");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek ürün ID: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-H8KFKNA;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("update TblProduct set ProductName = @productName, ProductPrice = @productPrice where ProductId = @productId",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine($"{productId} ID li ürünün Adı: {productName} ve Fiyatı: {productPrice} Tl olarak güncellenmiştir.");

            #endregion

            #endregion

            Console.Read();
        }
    }
}
