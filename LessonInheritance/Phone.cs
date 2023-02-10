using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonInheritance
{
    class Phone : Product
    {
        private string Name;
        private float Price;
        private int Count;


        public Phone( string name, float price, int count):base(name,price,count)
        {
            
        }
        public override void FilterName(string name)
        {
            base.FilterName(name);
        }
        public override void AddProduct(string name, float price, int count)
        {
            base.AddProduct(name, price, count);
        }
    }
}
