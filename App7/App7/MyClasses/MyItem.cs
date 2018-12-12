using System;
using System.Collections.Generic;
using System.Text;

namespace App7.MyClasses
{
    public class MyItem
    {
        public string Shop { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Shop + " " + Name + " " + Price;
        }
    }
}
