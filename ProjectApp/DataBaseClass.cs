using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ProjectApp
{
    public class DataBaseClass
    {
        public int Key { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Image Picture { get; set; }
        public DataBaseClass(int key, string name, int price, Image image)
        {
            Key = key;
            Name = name;
            Price = price;
            Picture = image;
        }
    }
}
