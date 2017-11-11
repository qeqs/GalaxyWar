using GalaxyWar.logic;
using GalaxyWar.model;
using GalaxyWar.model.drawable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GalaxyWar
{
    class GameController
    {
        private readonly int MS_PER_UPDATE = 10;
        private int current = 0;
        private Galaxy galaxy;
        bool started = false;
        AimSearcher searcher = new AimSearcher();
        public event EventHandler OnRender;
        

        public static void Log(string message)
        {
            File.AppendAllText("log.txt", message+"\n");
        }

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

        public bool Started
        {
            get
            {
                return started;
            }

            set
            {
                started = value;
            }
        }

        public GameController(Galaxy galaxy)
        {
            this.Galaxy = galaxy;
            
        }

        public void init()
        {
        }   

        public void gameLoop(Graphics graphics)
        {
            if (!started) return;
            
            update(galaxy);
            render(graphics, galaxy);
        }

        private void render(Graphics graphics, Galaxy galaxy)
        {
            graphics.Clear(Color.Black);
            List<IDrawable> drawables = galaxy.getAllDrawables();

            foreach (IDrawable drawable in drawables)
            {
                Log(drawable.Location + " moving to " + drawable.Destination);
                movement(drawable);
                Log(drawable.Location + " moved to " + drawable.Destination);

                graphics.DrawImage(drawable.Model as Image,
                    drawable.Location.X, drawable.Location.Y, drawable.Size.Width, drawable.Size.Height);
            }
            if (OnRender != null)
            {
                OnRender(this, EventArgs.Empty);
            }
        }

        public void draw(Graphics graphics)
        {
            graphics.Clear(Color.Black);
            galaxy.getAllDrawables().ForEach(drawable =>
                graphics.DrawImage(drawable.Model as Image,
                    drawable.Location.X, drawable.Location.Y, drawable.Size.Width, drawable.Size.Height));
        }


        private void update(Galaxy galaxy)
        {
            if (current-- > 0) return;
            else current = MS_PER_UPDATE;

            galaxy.planetsMovement();
            galaxy.Civilizations.ForEach(civ => civ.Planets.ForEach(planet => civ.Behavior.produce(planet, civ)));
            galaxy.Civilizations.ForEach(civ => civ.Behavior.execute(galaxy, civ));
            galaxy.deleteAllDeadShips();
        }

        private void movement(IDrawable drawable)
        {
            float x = drawable.Center.X;
            float y = drawable.Center.Y;

            float b = Math.Abs(x - drawable.Destination.X) == 0 ? 1 : Math.Abs(x - drawable.Destination.X);
            float a = Math.Abs(y - drawable.Destination.Y);
            double phi = Math.Atan(a / b);
            float xSpeed = (float)(drawable.Speed * Math.Cos(phi * (180.0/Math.PI )));
            float ySpeed = (float)(drawable.Speed * Math.Sin(phi * (180.0/Math.PI )));

            if (x < drawable.Destination.X && y <= drawable.Destination.Y)
            {
                x += xSpeed;
                y += ySpeed;
            }
            if (x < drawable.Destination.X && y > drawable.Destination.Y)
            {
                x += xSpeed;
                y -= ySpeed;
            }
            if (x > drawable.Destination.X && y <= drawable.Destination.Y)
            {
                x -= xSpeed;
                y += ySpeed;
            }
            if (x > drawable.Destination.X && y > drawable.Destination.Y)
            {
                x -= xSpeed;
                y -= ySpeed;
            }

            drawable.Center = new PointF(x, y);

        }
    }
}
