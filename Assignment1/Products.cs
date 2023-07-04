using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Products
    {
        static Dictionary<String, Item> catalogue { get; set; }
        public Products()
        {
            catalogue = new Dictionary<String, Item>();

            catalogue.Add("Door", new Item(12345678912,            
                "Red Rock Engineering Works ",
                "Avenue Street, US ",
                new List<String> { "Wood", "Iron", "Carbon" }
                ));
            catalogue.Add("Wallpaper", new Item(56781234913,
                "Smart Design Interiors",
                "Downtown Calgary, Canada",
                new List<String> { "Blue", "Pink", "Brown" }
                ));
        }
        public Dictionary<string, Item> Catalogue
        {
            get { return catalogue; }
        }
    }
}