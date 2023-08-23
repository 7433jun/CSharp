using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Virtual_Function
{
    public class Unit
    {
        protected int hp;
        protected int attack;

        public virtual void Created()
        {
            Console.WriteLine("유닛 생성");
        }
    }

    public class Vulture : Unit
    {
        public Vulture()
        {
            Created();
        }
        public override void Created()
        {
            Console.WriteLine("벌처 생성");
        }
    }

    public class Tank : Unit
    {
        public Tank()
        {
            Created();
        }
        public override void Created()
        {
            Console.WriteLine("탱크 생성");
        }
    }

    public class Goliath : Unit
    {
        public Goliath()
        {
            Created();
        }
        public override void Created()
        {
            Console.WriteLine("골리앗 생성");
        }
    }
}
