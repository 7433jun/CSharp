using System.ComponentModel;
using System.ComponentModel.Design;
using static Game.Program;

namespace Game
{
    internal class Program
    {
        #region 봉인 클래스
        // 클래스가 다른 클래스에 상속되는 것을 원하지 않을 때
        // 해당 클래스를 봉인하는 것입니다.

        public class Complete
        {
            public virtual void Skill()
            {
                Console.WriteLine("완전체 스킬");
            }
        }

        public class Maturity : Complete
        {
            public sealed override void Skill()
            {
                Console.WriteLine("성숙기 스킬");
            }
        }

        public class Babyhood : Maturity
        {
            // 상위 클래스에서 봉인 함수로 선언된 함수는
            // 하위 클래스에서 더 이상 재정의할 수 없습니다.
            // public override void Skill() { }
        }
        #endregion

        #region 인덱서
        // 인덱스를 이용해서 객체 내부에 존재하는 데이터에 접근할 수 있도록
        // 해주는 기능입니다.

        public class Player
        {
            public Bullet[] bullet = new Bullet[5];

            private int x;
            private int y;
            private string shape = "▲";

            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
            }

            public string Shape
            {
                get { return shape; }
            }

            public void Fire()
            {
                foreach(Bullet element in bullet)
                {
                    if (!element.active)
                    {
                        element.active = true;
                        element.X = x;
                        element.Y = 15;
                        break;
                    }
                }
            }

        }

        public class Bullet
        {
            //public int[] index = new int[5];

            private int x = 10;
            private int y;
            private string shape = "●";
            public bool active;

            //public int this[int index]
            //{
            //    get
            //    {
            //        if(index >= this.index.Length)
            //        {
            //            Console.WriteLine("범위 초과");
            //            return 0;
            //        }
            //        else
            //        {
            //            return this.index[index];
            //        }
            //    }
            //    set
            //    {
            //        if (index >= this.index.Length)
            //        {
            //            Console.WriteLine("범위 초과");
            //        }
            //        else
            //        {
            //            this.index[index] = value;
            //        }
            //    }
            //}
            
            public int X
            {
                get { return x; }
                set { x = value; }
            }

            public int Y
            {
                get { return y; }
                set { y = value; }
            }

            public string Shape
            {
                get { return shape; }
            }
        }

        public class Progress
        {
            private Player player;
            public Progress(Player player)
            {
                this.player = player;
            }

            public void Input(ConsoleKeyInfo cki)
            {
                switch (cki.Key)
                {
                    case ConsoleKey.Spacebar:
                        player.Fire();
                        break;
                    case ConsoleKey.LeftArrow:
                        if(player.X > 0)
                        {
                            player.X--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if(player.X < 20)
                        {
                            player.X++;
                        }
                        break;
                    default:
                        break;
                }
            }

            public void BulletMove()
            {
                foreach(Bullet element in player.bullet)
                {
                    if (element.active)
                    {
                        element.Y--;
                        if(element.Y < 0)
                        {
                            element.active = false;
                        }
                    }
                }
            }
        }

        public class Render
        {
            private Player player;

            public Render(Player player)
            {
                this.player = player;
            }

            public void Draw()
            {
                Console.SetCursorPosition(player.X, player.Y);
                Console.Write(player.Shape);
                foreach(Bullet element in player.bullet)
                {
                    if (element.active)
                    {
                        Console.SetCursorPosition(element.X, element.Y);
                        Console.Write(element.Shape);
                    }
                }
            }
        }

        #endregion

        static void Main(string[] args)
        {
            #region 봉인 클래스
            // Complete complete = new Complete();
            // Maturity maturity = new Maturity();
            // Babyhood babyhood = new Babyhood();
            // 
            // complete.Skill();
            // maturity.Skill();
            // babyhood.Skill();
            #endregion

            Player player = new Player();
            Progress progress = new Progress(player);
            Render render = new Render(player);

            while(true)
            {
                Console.Clear();
                progress.Input(Console.ReadKey(true));
                progress.BulletMove();
                render.Draw();
                Thread.Sleep(100);
            }
        }
    }
}