using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model.drawable.impls
{
    class Star:SpaceObject
    {
        public Star(PointF location)
        {
            this.Location = location;
        }
    }
}
