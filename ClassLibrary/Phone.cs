using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Phone:Product
    {
        public int SIMCount { get; set; }
        public override void ShowInfo()
        {
            Console.WriteLine($"mehsulun adi: {Name} - nomresi: {No} - qiymeti: {Price} - endirim faizi: {DiscountPercent} - sim kartin sayi: {SIMCount}");
        }
    }
}
