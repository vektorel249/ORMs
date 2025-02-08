using Vektorel.Orms.BuiltIn.Managers;

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
        }
    }
}
