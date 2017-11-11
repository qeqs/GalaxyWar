using System;
using System.Drawing;

namespace GalaxyWar.model.drawable.impls
{
    class Planet:SpaceObject
    {
        private PointF destination;

        public Planet(PointF location, int metal, int carbon, int organic)
        {
            this.Location = location;
            destination = location;
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

        public void produce(SpaceShip ship)
        {
            Metal -= ship.Metal;
            Hydrocarbon -= ship.Hydrocarbon;
            Organic -= ship.Organic;
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

        public override int Hydrocarbon
        {
            get
            {
                return this.hydrocarbon;
            }
            set
            {
                if (value <= 0)
                    hydrocarbon = 0;
                else
                    hydrocarbon = value;
                if (hydrocarbon == 0)
                    Model = Properties.Resources.planet_noresources;
            }
        }

        public override int Organic
        {
            get
            {
                return this.organic;
            }
            set
            {
                if (value <= 0)
                    organic = 0;
                else
                    organic = value;
                if (organic == 0)
                    Model = Properties.Resources.planet_noresources;
            }
        }

        public override double Speed
        {
            get
            {
                return double.Parse(Properties.Resources.planets_speed);
            }

            set
            {
            }
        }

        public override PointF Destination
        {
            get
            {
                return destination;
            }

            set
            {
                destination = value;
            }
        }
    }
}
