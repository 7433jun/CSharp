using System.Data.Common;
using System.Threading.Tasks;
using Game.Inventory_Class;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 5;
            Inventory inventory = new Inventory(x, y);
            Cursor cursor = new Cursor();

            while (true)
            {
                Console.Clear();

                inventory.Render(cursor);

                cursor.Input(Console.ReadKey(true), inventory);
            }
        }
    }
}