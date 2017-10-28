﻿using GalaxyWar.logic.impls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model.drawable.impls
{
    class Colony:SpaceShip
    {

        public Colony(PointF location, Color color) : base(location)
        {
            this.Health = int.Parse(Properties.Resources.colony_health);
            this.Atack = int.Parse(Properties.Resources.colony_attack);
            this.Speed = int.Parse(Properties.Resources.colony_speed);
            this.Metal = int.Parse(Properties.Resources.colony_metal);
            this.Hydrocarbon = int.Parse(Properties.Resources.colony_carbon);
            this.Organic = int.Parse(Properties.Resources.colony_organic);
            this.Behavior = new ColonyBehavior();
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
