using Vektorel.Orms.DapperLib.Managers;

namespace Vektorel.Orms.DarkScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sm = new ClassroomSample();
            var suppliers = sm.GetSuppliersInGermany();
            foreach (var supplier in suppliers)
            {
                Console.WriteLine("{0,2} | {1, -40} | {2,10}", supplier.SupplierID, supplier.CompanyName, supplier.City);
            }
            Console.WriteLine("Bir tuşa basınız");
            Console.ReadKey();

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
