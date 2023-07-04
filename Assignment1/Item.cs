using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Manufactuer
    {
        public String ManufacturerName { get; set; }
        public String Address { get; set; }
        public Manufactuer(String ManufacturerName, String Address) {
            this.ManufacturerName = ManufacturerName;
            this.Address = Address;
        }
    }
    public class Item
    {
        public BigInteger EAN {  get; set; }
        public Manufactuer ManufacturerDetails { get; set; }  
        public List<String> Variants { get; set; }
        
        public Item(BigInteger EAN, String ManufacturerName, String Address, Object Variants)
        {
            this.ManufacturerDetails= new Manufactuer(ManufacturerName, Address);          
            this.Variants = (List<string>?)Variants;
            this.EAN = EAN;           
        }
        public override string ToString()
        {
            return $"EAN - {EAN}\nManufacturer Details\n    Name - {ManufacturerDetails.ManufacturerName}\n    Address - {ManufacturerDetails.Address}\nVariants- {String.Join(", ",Variants)}";
        }       
    }
}