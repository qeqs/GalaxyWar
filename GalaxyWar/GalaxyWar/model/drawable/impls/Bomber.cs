
using GalaxyWar.logic.impls.ships;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model.drawable.impls
{
    class Bomber:SpaceShip
    {
        
        public Bomber(PointF location, Color color, Civilization civ) : base(location, civ)
        {
            this.Health = int.Parse(Properties.Resources.bomber_health);
            this.Atack = int.Parse(Properties.Resources.bomber_attack);
            this.Speed = int.Parse(Properties.Resources.bomber_speed);
            this.Metal = int.Parse(Properties.Resources.bomber_metal);
            this.Hydrocarbon = int.Parse(Properties.Resources.bomber_carbon);
            this.Organic = int.Parse(Properties.Resources.bomber_organic);
            this.Behavior = new BomberBehavior();
            this.Size = new SizeF(20, 20);
            this.Model = createModel(color);
        }

        private Bitmap createModel(Color color)
        {
            Bitmap bitmap = new Bitmap((int)Size.Width, (int)Size.Height);
            Graphics g = Graphics.FromImage(bitmap as Image);
            g.FillRectangle(new SolidBrush(color), 0F, 0F, Size.Width, Size.Height);
            g.DrawRectangle(Pens.Black, 0F, 0F, Size.Width, Size.Height);
            return bitmap;
        }

        public override void CalculateFight(IDrawable target)
        {
            if (!(target is Planet)) return;

            Planet aim = (Planet)target;
            aim.Civilization.Planets.Remove(aim);
            aim.Civilization = null;
        }
    }
}
