using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Inventory_Class
{
    public class Inventory
    {
        Item[] items;
        private int x;
        private int y;
        public Inventory(int x, int y)
        {
            this.x = x;
            this.y = y;
            items = new Item[x * y];
        }

        public void AddItem(Item _item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == null)
                {
                    items[i] = _item;
                    Console.WriteLine("아이템이 추가되었습니다.");
                    break;
                }

                if (i == items.Length - 1)
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

        public int Getx()
        {
            return x;
        }

        public int Gety()
        {
            return y;
        }

        public int GetSize()
        {
            return items.Length;
        }

        public Item GetItem(int i)
        {
            return items[i];
        }

        public void Render(Cursor cursor)
        {
            Console.Clear();

            for (int i = 0; i < GetSize(); i++)
            {
                if (i == cursor.Position())
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ResetColor();
                }

                if (GetItem(i) == null)
                {
                    Console.Write("□ ");
                }
                else
                {
                    Console.Write(GetItem(i).GetShape() + " ");
                }

                if ((i + 1) % x == 0)
                {
                    Console.WriteLine();
                }
            }

            if (GetItem(cursor.Position()) != null)
            {
                Console.WriteLine("아이템 이름 : " + GetItem(cursor.Position()).GetName());
                Console.WriteLine("아이템 가격 : " + GetItem(cursor.Position()).GetPrice());
            }
        }
    }

    public class Cursor
    {
        public int x;
        public int y;

        public Cursor()
        {
            x = 0;
            y = 0;
        }

        public int Position()
        {
            return x + y * 4;
        }

        public void Input(ConsoleKeyInfo cki, Inventory inventory)
        {
            switch (cki.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (x > 0)
                    {
                        x--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (x < inventory.Getx() - 1)
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (y > 0)
                    {
                        y--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (y < inventory.Gety() - 1)
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.NumPad0:
                    inventory.AddItem(new Item());
                    break;
                case ConsoleKey.NumPad1:
                    inventory.AddItem(new Potion());
                    break;
                case ConsoleKey.NumPad2:
                    inventory.AddItem(new Gem());
                    break;
                case ConsoleKey.NumPad3:
                    inventory.AddItem(new Iron());
                    break;
                case ConsoleKey.Backspace:
                    inventory.RemoveItem(Position());
                    break;
                default:
                    break;
            }
        }
    }
}
