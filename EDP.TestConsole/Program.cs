using EDP.ExceptionHandling;
using EDP.TestConsole.BusinessLogic;
using EDP.TestConsole.Exception;
using EDP.TestConsole.Model;
using System;

namespace EDP.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProductModel model = new ProductModel();
                Console.Write("CategoryID değerini giriniz ...:");
                model.CategoryID = Convert.ToInt32(Console.ReadLine());

                Console.Write("SupplierID değerini giriniz ...:");
                model.SupplierID = Convert.ToInt32(Console.ReadLine());

                Console.Write("ProductName değerini giriniz ...:");
                model.ProductName = Console.ReadLine();

                ProductManager manager = new ProductManager();
                manager.AddNewProduct(model);
                Console.WriteLine("Product eklendi");
            }
            catch (ExceptionBase exbs)
            {
                ExceptionManager exManager = new ExceptionManager();
                string m = exManager.GetExceptionMessage(exbs);
                Console.WriteLine("Bir hata meydana geldi");
                Console.WriteLine(m);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Tanımlanmamış bir hata meydana geldi");
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
