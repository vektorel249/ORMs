using Vektorel.Orms.BuiltIn.Managers;
using Vektorel.Orms.Data.Entities;

namespace Vektorel.Orms.DarkScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dm = new NorthwindManager();
            var categories = dm.GetCategories();
            foreach (var category in categories)
            {
                Console.WriteLine($"{category.CategoryID} {category.CategoryName}");
            }

            foreach (var product in dm.GetProducts())
            {
                Console.WriteLine($"{product.ProductID}\t {product.ProductName}\t {product.UnitPrice}");
            }
        }
    }
}
