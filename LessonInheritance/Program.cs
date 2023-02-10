// See https://aka.ms/new-console-template for more information

using System.IO;
using System.Collections.Generic;
using LessonInheritance;
using System.Xml.Linq;
using System.Linq;

Console.WriteLine("Product Inventory \n");


//List<Product> products = new List<Product>();
//products.Add(new Phone("SamSung", 850, 10));
//products.Add(new Phone("SamSung", 900, 8));
//products.Add(new NoteBook("MacPro", 1500, 5));

Product[] products = new Product[]
{
    new Phone("iPhone 8",900,5),
    new Phone("iPhone X",950,7),
    new Phone("iPhone XS",1000,10),
    new Phone("SamSung A32",450,10),
    new Phone("SamSung A52",500,7),
    new Phone("SamSung A72",630,7),

    new NoteBook("Acer",900,5),
    new NoteBook("HP",950,7),
    new NoteBook("Dell",1000,10),
    new NoteBook("MacPro",550,4),
    new NoteBook("HP",900,5),
    new NoteBook("MacAir",900,5),
    new NoteBook("Asus",900,5)
};
Phone phone = new Phone("Apple",400,7);
phone.AddProduct("Samsung",980,74);
NoteBook note = new NoteBook("MacPro", 450, 6);
note.AddProduct("MacPro", 450, 6);


foreach (Product item in products)
{

    item.PrintProduct();
    
  

}


//foreach (Product item in products)

//{
//    item.PrintProduct();

//}
Console.WriteLine();

//Console.WriteLine("All Product Sum: " + products.Sum(products => products.Price));


//Console.WriteLine("Product where name contains (SumSung)" + products.FindAll(x=>x.Name.Contains("SamSung")));

