using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Notebook:Product
    {
        public int Ram { get; set; }
        public int Storage { get; set; }
        public override void ShowInfo()
        {
           Console.WriteLine($"mehsulun adi: {Name} - nomresi: {No} - qiymeti: {Price} - endirim faizi: {DiscountPercent} - rami: {Ram} - yaddasi: {Storage}");
        }
    }
}
