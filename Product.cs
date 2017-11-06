using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baza_sklepu
{
    class Product
    { 
        private int id;
        private string name;
        private float price;

        public Product()
        {
            id = -1;
            name = "empty";
            price = 0;
        }

        public Product(int _id, string _name, float _price)
        {
            int id = _id;
            string name = _name;
            float price = _price;
        }

        
        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }
        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float _price)
        {
            price = _price;
        }
        public void SetId(int _id)
        {
            id = _id;
        }
        public void WriteProduct()
        {
            Console.WriteLine("Product id: " + id + "\nnazwa: " + name + "\ncena: " + price +"\n");
        }
        
    }

}
