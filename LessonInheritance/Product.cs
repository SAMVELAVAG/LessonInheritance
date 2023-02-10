using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInheritance
{
    public  class Product
    {

        private  string Name;
        private  float Price;
        private  int Count;

        public Product(string name, float price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public void PrintProduct()
        {
            Console.WriteLine($"Name:  {Name}, Price:  {Price}, Count:  {Count}");
        }
        public virtual void FilterName(string name)
        {
            if (Name == name || Name.StartsWith(name))
            {
                    
                if (Name.StartsWith(name) && name == "")
                {
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine($"Name: {Name}, Price: {Price}, Count: {Count}");
                }

            }
        }
        public virtual void AddProduct(string name, float price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
            Console.WriteLine($"Name: {name}, Price: {price}, Count: {count}");
        }

    }
}
