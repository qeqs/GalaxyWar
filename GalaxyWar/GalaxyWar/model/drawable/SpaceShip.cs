using GalaxyWar.logic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model.drawable
{
    abstract class SpaceShip:IDrawable
    {
        protected PointF destination;
        protected PointF location;
        protected double speed;
        protected SizeF size;
        protected Bitmap model;
        protected Civilization civilization;

        protected int health;
        protected int atack;

        protected int metal;
        protected int hydrocarbon;
        protected int organic;

        protected Behavior behavior;

        protected SpaceShip(PointF location, Civilization civ)
        {
            this.Location = location;
            this.Destination = location;
            Civilization = civ;
        }

        public virtual void CalculateFight(IDrawable target)
        {
            if (!(target is SpaceShip)) return;

            SpaceShip aim = (SpaceShip)target;
            aim.Health -= this.Atack;
            this.Health -= aim.Atack;
        }

        public virtual PointF Destination
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

        public virtual PointF Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        public virtual double Speed
        {
            get
            {
                return speed;
            }

            set
            {
                speed = value;
            }
        }

        public virtual Behavior Behavior
        {
            get
            {
                return behavior;
            }

            set
            {
                behavior = value;
            }
        }

        public virtual int Atack
        {
            get
            {
                return atack;
            }

            set
            {
                atack = value;
            }
        }

        public virtual int Health
        {
            get
            {
                return health;
            }

            set
            {
                health = value;
            }
        }

        public virtual SizeF Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        public virtual Bitmap Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public virtual int Metal
        {
            get
            {
                return metal;
            }

            set
            {
                metal = value;
            }
        }

        public virtual int Hydrocarbon
        {
            get
            {
                return hydrocarbon;
            }

            set
            {
                hydrocarbon = value;
            }
        }

        public virtual int Organic
        {
            get
            {
                return organic;
            }

            set
            {
                organic = value;
            }
        }

        public int Alpha
        {
            get
            {
                return 100;
            }
            set
            {

            }
        }

        public virtual Civilization Civilization
        {
            get
            {
                return civilization;
            }

            set
            {
                civilization = value;
            }
        }

        public PointF Center
        {
            get
            {
                return new PointF(Location.X + Size.Width / 2, Location.Y + Size.Height / 2);
            }

            set
            {
                location = new PointF(value.X - Size.Width / 2, value.Y - Size.Height / 2);
            }
        }
    }
}
