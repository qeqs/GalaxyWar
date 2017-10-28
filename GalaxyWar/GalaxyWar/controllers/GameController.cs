using GalaxyWar.model;
using GalaxyWar.model.drawable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar
{
    class GameController
    {
        private readonly double MS_PER_UPDATE = 10;
        private Galaxy galaxy;

        public Galaxy Galaxy
        {
            get
            {
                return galaxy;
            }

            set
            {
                galaxy = value;
            }
        }

        public GameController(Galaxy galaxy)
        {
            this.Galaxy = galaxy;
        }

        public void gameLoop(Graphics graphics, UserInput userInput, Galaxy galaxy)
        {
            double previous = DateTime.Now.Ticks;
            double lag = 0.0;
            while (true)//change in case of timer use
            {
                double current = DateTime.Now.Ticks;
                double elapsed = current - previous;
                previous = current;
                lag += elapsed;

                processInput(userInput, galaxy);

                while (lag >= MS_PER_UPDATE)
                {
                    update(galaxy);
                    lag -= MS_PER_UPDATE;
                }

                render(graphics, galaxy, lag / MS_PER_UPDATE);
            }
        }

        private void render(Graphics graphics, Galaxy galaxy, double lag)
        {
            graphics.Clear(Color.Black);

            List<IDrawable> drawables = new List<IDrawable>();
            drawables.AddRange(galaxy.SpaceObjects);
            foreach (Civilization civ in galaxy.Civilizations)
                drawables.AddRange(civ.Fleet);
            drawables.Sort((a, b) => a.Alpha > b.Alpha ? 1 : -1);

            foreach (IDrawable drawable in drawables)
            {
                PointF loc = drawable.Location;
                PointF des = drawable.Destination;
                double x = des.X - loc.X;
                double y = des.Y - loc.Y;
                double c = Math.Sqrt(x * x + y * y);

                loc.X = (float)(lag * drawable.Speed * Math.Cos(x / c));
                loc.Y = (float)(lag * drawable.Speed * Math.Cos(y / c));
                drawable.Location = loc;

                graphics.DrawImage(drawable.Model as Image,
                    drawable.Location.X, drawable.Location.Y, drawable.Size.Width, drawable.Size.Height);
            }
        }


        private void update(Galaxy galaxy)
        {
            galaxy.Civilizations.ForEach(civ => civ.Planets.ForEach(planet => civ.Behavior.produce(planet, civ)));
            galaxy.Civilizations.ForEach(civ => civ.Behavior.execute(galaxy, civ));
        }

        private void processInput(UserInput userInput, Galaxy galaxy)
        {
            throw new NotImplementedException();
        }
    }
}
