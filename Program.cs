using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza_sklepu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            Base ShopBase = new Base();
            Base Basket = new Base();
            while (condition)

            {

                Console.WriteLine("Welcome in our shop! Chose what zou want to do:");

                Console.WriteLine("1 - Show all products in base");

                Console.WriteLine("2 - Add product to base");

                Console.WriteLine("3 - Show basket contents");

                Console.WriteLine("4 - Add product to the basket");

                Console.WriteLine("5 - Delete product from the basket");

                Console.WriteLine("6 - Calculate basket value");

                int helpVar = 0;
                helpVar = Convert.ToInt32(Console.ReadLine());
                switch(helpVar)
                {
                    case 1:
                        {
                            ShopBase.WriteProducts();
                            break;
                        }
                    case 2:
                        {
                            string name;
                            float price;
                            Console.WriteLine("Put in a name: ");
                            name = Console.ReadLine();
                            Console.WriteLine("Put in a price: ");
                            price = float.Parse(Console.ReadLine());
                            Product tmpProduct = new Product(-1, name, price); 
                            ShopBase.AddProduct(tmpProduct);
                            break;
                        }
                    case 3:
                        {
                            Basket.WriteProducts();
                            Console.WriteLine("\n");
                            break;
                        }
                    case 4:
                        {
                            int tmpId;
                            Console.WriteLine("pt in id: ");
                            tmpId = Convert.ToInt32(Console.ReadLine());
                            Product tmpProd = ShopBase.FindProduct(tmpId);
                            Basket.AddProduct(tmpProd);
                            break;
                        }
                    case 5:
                        {
                            int tmpId;
                            tmpId = Convert.ToInt32(Console.ReadLine());
                            Basket.RemoveProduct(tmpId);
                            break;
                        }
                    case 6:
                        {
                            float tmpPrice = Basket.CalculateProducts();
                            Console.WriteLine("Value of the basket is: " + tmpPrice + "\n");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("You chose valid option!");
                            break;
                        }

                }
            }
        }
    }
}
