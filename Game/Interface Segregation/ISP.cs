using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Interface_Segregation;

namespace Game.Interface_Segregation
{
    public class Pistol : IGun
    {
        public void Fire()
        {
            Console.WriteLine("권총 발사");
        }

        public void ReLoad()
        {
            Console.WriteLine("권총 장전");
        }
    }

    public class Rifle : IGun
    {
        public void Fire()
        {
            Console.WriteLine("소총 발사");
        }

        public void ReLoad()
        {
            Console.WriteLine("소총 장전");
        }
    }

    public class Snipe : IGun, IScope
    {
        public void Fire()
        {
            Console.WriteLine("저격총 발사");
        }

        public void ReLoad()
        {
            Console.WriteLine("저격총 장전");
        }

        public void Zoom()
        {
            Console.WriteLine("저격총 확대");
        }
    }
}
