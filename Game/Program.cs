using System.Threading.Tasks;

namespace Game
{
    public class Item
    {
        private string name;
        private int price;

        public Item(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }

    public class Inventory
    {
        Item[] items;
        public Inventory(int x, int y)
        {
            items = new Item[x * y];
        }

        public void AddItem(Item _item)
        {
            for(int i = 0;i < items.Length;i++)
            {
                if (items[i] == null)
                {
                    items[i] = _item;
                    Console.WriteLine("아이템이 추가되었습니다.");
                    break;
                }

                if(i == items.Length - 1)
                {
                    Console.WriteLine("인벤토리가 다 찼습니다.");
                }
            }
        }

        public void RemoveItem(int i)
        {
            if (items[i] != null)
            {
                items[i] = null;
            }
        }

        public int GetSize()
        {
            return items.Length;
        }

        public Item GetItem(int i)
        {
            return items[i];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 4;
            int y = 5;
            Inventory inventory = new Inventory(4, 5);

            int cursorx = 0;
            int cursory = 0;

            ConsoleKeyInfo cki;

            while (true)
            {
                Console.Clear();

                for(int i = 0; i < inventory.GetSize(); i++)
                {
                    if (i == cursorx + cursory * 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    if(inventory.GetItem(i) == null)
                    {
                        Console.Write("□ ");
                    }
                    else
                    {
                        Console.Write("■ ");
                    }


                    if((i + 1) % x == 0)
                    {
                        Console.WriteLine();
                    }
                }

                


                cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if(cursorx > 0)
                        {
                            cursorx--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if(cursorx < x)
                        {
                            cursorx++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if(cursory > 0)
                        {
                            cursory--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (cursory < y)
                        {
                            cursory++;
                        }
                        break;
                    case ConsoleKey.NumPad1:
                        inventory.AddItem(new Item("아이템", 10));
                        break;
                    case ConsoleKey.Backspace:
                        inventory.RemoveItem(cursorx + cursory * 4);
                        break;
                    default:
                        break;
                }


            }
        }
    }
}