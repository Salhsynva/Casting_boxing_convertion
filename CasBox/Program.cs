using System;
using ClassLibrary;

namespace CasBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.NotebookLimit = 3;
            store.PhoneLimit = 5;

            Notebook notebook1 = new Notebook()
            { 
                Name = "notebook 1",
                No = 12,
                Price = 1999.9
            };

            Notebook notebook2 = new Notebook()
            {
                Name = "notebook 2",
                No = 34,
                Price = 2345
            };
            Notebook notebook3 = new Notebook()
            {
                Name = "notebook 3",
                No = 23,
                Price = 1245
            };
            Notebook notebook4 = new Notebook()
            {
                Name = "notebook 4",
                No = 34,
                Price = 4323
            };

            Phone phone1 = new Phone()
            {
                Name = "phone 1",
                No = 12,
                Price = 750
            };
            Phone phone2 = new Phone()
            {
                Name = "phone 2",
                No = 34,
                Price = 450
                
            };
            Phone phone3 = new Phone()
            {
                Name = "phone 3",
                No = 4,
                Price = 500
            };

            store.AddProduct(notebook1);
            store.AddProduct(notebook2);
            store.AddProduct(notebook3);
            store.AddProduct(notebook4);
            store.AddProduct(phone1);
            store.AddProduct(phone2);
            store.AddProduct(phone3);
            

            //foreach (var item in store.Products)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //store.FindByNo(12);
            Console.WriteLine(store.CalcNotebookAvg());
            Console.WriteLine(store.CalcPhoneAvg());
        }
    }
}
