using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Store
    {
        Product[] _products = new Product[0];
        public Product[] Products { get =>_products; }
        public int NotebookLimit { get; set; }
        public int PhoneLimit { get; set; }

        public void AddProduct(Product product)
        {
            if (product is Notebook)
            {
                int count = 0;
                foreach (var item in Products)
                {
                    if (product is Notebook)
                        count++;
                }
                if (NotebookLimit > count)
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = product;
                }
            }
            else if (product is Phone)
            {
                int count = 0;
                foreach (var item in Products)
                {
                    if (item is Phone)
                        count++;
                }
                if (PhoneLimit > count)
                {
                    Array.Resize(ref Products, Products.Length + 1);
                    Products[Products.Length - 1] = product;
                }
            }
        }
        public void FindByNo(int no)
        {
            foreach (var pr in Products)
            {
                if (pr.No == no)
                    pr.ShowInfo();
            }
        }
        public double CalcNotebookAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var pr in Products)
            {
                if (pr is Notebook)
                {
                    Notebook prNotebook = pr as Notebook;
                    sum += prNotebook.Price;
                    count++;
                }
            }
            if (count > 0)
                return sum / count;
            else
                return 0;
        }
        public double CalcPhoneAvg()
        {
            int count = 0;
            double sum = 0;
            foreach (var pr in Products)
            {
                if (pr is Phone)
                {
                    Phone prPhone = pr as Phone;
                    sum += prPhone.Price;
                    count++;
                }
            }
            if (count > 0)
                return sum / count;
            else
                return 0;
        }
    }
}
