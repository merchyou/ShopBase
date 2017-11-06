using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza_sklepu
{
    class Base
    {
        private int lastId;
        //private Product[] products = new Product[100];
        //private List<Product> products = new List<Product>();
        private List<Product> products = new List<Product>(new Product[100]);

        private string name;



        public Base()
        {
            lastId = 0;
        }
        
        public void AddProduct(Product _product)
        {

            for (int i = 0; i <= 100; i++)
            {
                if (products[i].GetId() == -1)
                {
                    lastId++;
                    products[i] = _product;
                    products[i].SetId(lastId);
                    break;

                }
            }
            
        }
    
        public void RemoveProduct(int _id)
        {
            for (int i = 0; i<100; i++)
            {
                if (products[i].GetId() == _id)
                {
                    products[i] = new Product();
                    break;
                }
            }
        }

        public string GetName()
        {
            return name;
        }
        public void SetName(string _name)
        {
            name = _name;
        }

        public void WriteProducts()
        {
            Console.WriteLine("Products in base: " + name +"\n");
            foreach (Product element in products)
            {
                element.WriteProduct();
            }
        }

        public float CalculateProducts()
        {
            float price = 0;
            for (int i=0; i<100; i++)
            {
                price += products[i].GetPrice();
            }
            return price;
        }
        public Product FindProduct(int _id)
        {
            foreach(Product element in products)
            {
                if (element.GetId() == _id)
                    return element;
            }
            return new Product();
        }


        
    }
}
