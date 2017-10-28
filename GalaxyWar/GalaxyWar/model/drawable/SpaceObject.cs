using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model.drawable
{
    abstract class SpaceObject : IDrawable
    {
        protected PointF location;
        protected SizeF size;
        protected Bitmap model;

        protected int metal;
        protected int hydrocarbon;
        protected int organic;

        public virtual PointF Destination
        {
            get
            {
                return location;
            }

            set
            {
               
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
                return 0.0;
            }

            set
            {
                
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
                return 1000;
            }
            set
            {

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
    }
}
