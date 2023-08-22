using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Interface_Segregation
{
    interface IGun
    {
        void Fire();
        void ReLoad();
    }

    interface IScope
    {
        void Zoom();
    }
}
