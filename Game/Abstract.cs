namespace Game
{
    #region 인터페이스
    // 클래스 내의 구성요소들의 구현부가 없고,
    // 선언부의 집합으로만 이루어진 클래스입니다.
    public interface IEffect
    {
        // 인터페이스는 멤버 변수를 사용할 수 없습니다.
        // int data;(error)

        public void Use();
    }
    #endregion

    #region 추상클래스
    public abstract class Weapon
    {
        protected int attack;

        // 추상 함수
        public abstract void Attack();

        // 일반 함수
        public void Information()
        {
            Console.WriteLine("Weapon 클래스");
        }
    }
    #endregion

    public class Sword : Weapon, IEffect
    {
        public Sword()
        {
            attack = 10;
            Console.WriteLine("공격력 : " + attack);
        }

        // 함수 하이딩
        // 상위 클래스에서 구현된 함수를 감추고,
        // 하위 클래스에서 구현된 함수를 보여주는 것입니다.

        //new public void Attack()
        //{
        //    Console.WriteLine("검으로 공격");
        //    Use();
        //}

        public override void Attack()
        {
            Console.WriteLine("검으로 공격");
        }

        public void Use()
        {
            Console.WriteLine("불꽃");
        }
    }

    public class Armor
    {
        int defence;

        // 깊은 복사
        // 객체를 복사해서 새로운 객체를 만들어내는 것입니다.

        public Armor DeepCopy()
        {
            Armor armor = new Armor();
            armor.Defence = defence;

            return armor;
        }

        public int Defence
        {
            set { defence = value; }
            get { return defence; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 인터페이스
            // Weapon weapon = new Weapon();
            // weapon.Attack();
            // 
            // Sword sword = new Sword();
            // sword.Attack();
            #endregion

            #region 얕은 복사와 깊은 복사
            // 얕은 복사는 객체의 참조만 복사하는 것입니다.
            // Armor armor1 = new Armor();
            // armor1.Defence = 35;
            // 
            // // 객체를 얕은 복사하게 되면 스택에 있는 참조를 복사하는 것입니다.
            // Armor armor2 = armor1;
            // armor2.Defence = 65;
            // 
            // Armor armor3 = armor1.DeepCopy();
            // armor3.Defence = 95;
            // 
            // Console.WriteLine("armor1.Defence : " + armor1.Defence);
            // Console.WriteLine("armor2.Defence : " + armor2.Defence);
            // Console.WriteLine("armor3.Defence : " + armor3.Defence);
            #endregion

            #region 추상 클래스
            // Sword sword1 = new Sword();
            // 
            // Weapon weapon = sword1;
            // weapon.Attack();
            // weapon.Information();
            #endregion
        }
    }
}