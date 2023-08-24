using Game.Single_Responsibility;
using Game.Open_Closed;
using Game.Interface_Segregation;
using Game.Dependency_Inversion;
using Game.Liskov_Substitution;
using Game.Virtual_Function;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 단일 책임 원칙
            // module, class, function은 하나의 책임만 가져야 합니다.
            // Dog dog = new Dog();
            // Information info = new Information();
            // 
            // info.Show(dog);
            #endregion

            #region 개방 폐쇄 원칙
            // module, class, function은 확장에 대해 열려 있어야 하며,
            // 수정에 대해서는 닫혀 있어야 합니다.

            // UnitManager manager = new UnitManager();
            // 
            // manager.Create(new Marine());
            // manager.Create(new Medic());
            // manager.Create(new Ghost());
            // manager.Create(new Firebet());


            #endregion

            #region 인터페이스 분리 원칙
            // 클라이언트는 자신이 사용하지 않는 함수에 대해
            // 영향을 받지 않아야 하며, 인터페이스를 구체적이고 작은 단위의
            // 역할로 인터페이스를 분리시켜 클라이언트가 꼭 필요한 함수만
            // 이용할 수 있도록 해야합니다.

            // Pistol pistol = new Pistol();
            // pistol.Fire();
            // pistol.ReLoad();
            // 
            // Rifle rifle = new Rifle();
            // rifle.Fire();
            // rifle.ReLoad();
            // 
            // Snipe snipe = new Snipe();
            // snipe.Fire();
            // snipe.ReLoad();
            // snipe.Zoom();

            #endregion

            #region 의존관계 역전 원칙
            // 의존 관계를 맺을 때 자신보다 변화하기 쉬운 것보다는
            // 변화하지 않는 것에 의존해야 합니다.

            //ItemManager itemManager = new ItemManager();
            //
            //itemManager.AddItem(new Potion());
            //itemManager.AddItem(new Potion());
            //itemManager.AddItem(new Gem());
            //itemManager.AddItem(new Gem());
            //itemManager.AddItem(new Gem());
            //itemManager.AddItem(new Stone());
            //
            //itemManager.UseAllItem();

            #endregion

            #region 리스코프 치환 원칙
            // 상위 클래스와 하위 클래스가 있을 때 상위 클래스 객체를
            // 호출하는 동작에서 하위 클래스 객체가 상위 클래스 객체를
            // 완전하게 대체할 수 있어야 합니다.

            // Rect rect = new Rect();
            // rect.SetHeight(20);
            // rect.SetWidth(10);
            // Console.WriteLine(rect.GetArea());
            // 
            // Square square = new Square();
            // square.SetSide(20);
            // Console.WriteLine(square.GetArea());
            #endregion

            #region 가상 함수

            Unit unit = new Unit();

            ConsoleKeyInfo cki;

            while (true)
            {
                cki = Console.ReadKey(true);

                switch (cki.Key)
                {
                    case ConsoleKey.NumPad1:
                        unit = new Vulture();
                        break;
                    case ConsoleKey.NumPad2:
                        unit = new Tank();
                        break;
                    case ConsoleKey.NumPad3:
                        unit = new Goliath();
                        break;
                    default:
                        break;
                }
            }

            #endregion
        }
    }
}