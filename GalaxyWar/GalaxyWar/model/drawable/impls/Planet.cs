using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model.drawable.impls
{
    class Planet:SpaceObject
    {
        public Planet(PointF location, int metal, int carbon, int organic)
        {
            this.Location = location;
            this.Model = Properties.Resources.planet;
            this.Size = new SizeF(100, 100);

            this.Metal = metal;
            this.Hydrocarbon = carbon;
            this.Organic = organic;
        }

        public Planet(PointF location)
        {

            this.Location = location;
            this.Model = Properties.Resources.planet;
            this.Size = new SizeF(100, 100);

            Random rand = new Random();
            this.Metal = rand.Next();
            this.Hydrocarbon = rand.Next();
            this.Organic = rand.Next();
        }

        public override int Metal
        {
            get
            {
                return this.metal;
            }
            set
            {
                if (value <= 0)
                    metal = 0;
                else
                    metal = value;
                if (metal == 0)
                    Model = Properties.Resources.planet_noresources;
            }
        }
        
    }
}
