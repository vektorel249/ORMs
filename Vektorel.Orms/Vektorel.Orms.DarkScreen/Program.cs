using Vektorel.Orms.BuiltIn.Managers;

namespace Vektorel.Orms.DarkScreen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dm = new NorthwindManager();
            dm.GetCategories();
        }
    }
}
