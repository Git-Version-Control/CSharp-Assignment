using System.Net.NetworkInformation;

namespace Assignment1
{
    public class Program
    {      
        static void Main(string[] args)
        {
            Products product =new Products();
            foreach (KeyValuePair<string, Item> item in product.Catalogue)
            {
                Console.WriteLine("Item Name - " + item.Key);
                Console.WriteLine(item.Value.ToString()+"\n");
            }
        }
    }
}