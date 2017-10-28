using GalaxyWar.logic.impls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model.drawable.impls
{
    class Fighter:SpaceShip
    {
        public Fighter(PointF location, Color color) : base(location)
        {
            this.Health = int.Parse(Properties.Resources.fighter_health);
            this.Atack = int.Parse(Properties.Resources.fighter_attack);
            this.Speed = int.Parse(Properties.Resources.fighter_speed);
            this.Metal = int.Parse(Properties.Resources.fighter_metal);
            this.Hydrocarbon = int.Parse(Properties.Resources.fighter_carbon);
            this.Organic = int.Parse(Properties.Resources.fighter_organic);
            this.Behavior = new FighterBehavior();
            this.Size = new SizeF(20, 20);
            this.Model = createModel(color);
        }

        private Bitmap createModel(Color color)
        {
            Bitmap bitmap = new Bitmap((int)Size.Width, (int)Size.Height);
            Graphics g = Graphics.FromImage(bitmap as Image);
            g.FillEllipse(new SolidBrush(color), 0F, 0F, Size.Width, Size.Height);
            g.DrawEllipse(Pens.Black, 0F, 0F, Size.Width, Size.Height);
            return bitmap;
        }
    }
}
