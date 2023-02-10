using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LessonInheritance
{
     class NoteBook:Product
    {
        private  string Name;
        private float Price;
        private int Count;

        public NoteBook(string name, float price, int count) : base(name, price, count)
        {
            Name=name;
            Price=price;
            Count=count;
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
