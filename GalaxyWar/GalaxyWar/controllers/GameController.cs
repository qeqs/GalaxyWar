using GalaxyWar.model;
using GalaxyWar.model.drawable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalaxyWar
{
    class GameController
    {
        private readonly double MS_PER_UPDATE = 10;
        private Galaxy galaxy;
        double previous;
        double lag;
        bool started = false;

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
            previous = DateTime.Now.Ticks;
            lag = 0.0;
        }

        public void loop(object data)
        {
            Dictionary<String, Object> param = (Dictionary<String, Object>)data;
            Graphics graphics = (Graphics)param["graphics"];
            Form form = (Form)param["form"];
            gameLoop(graphics, form);
        }

        private void gameLoop(Graphics graphics, Form form)
        {
            if (!started) return;

            double current = DateTime.Now.Ticks;
            double elapsed = current - previous;
            previous = current;
            lag += elapsed;

            processInput(form, galaxy);

            while (lag >= MS_PER_UPDATE)
            {
                update(galaxy);
                lag -= MS_PER_UPDATE;
            }

            render(graphics, galaxy, lag / MS_PER_UPDATE);
            form.Invalidate();//possibly would be changed to call event handle
        }

        private void render(Graphics graphics, Galaxy galaxy, double _lag)
        {
            graphics.Clear(Color.Black);

            List<IDrawable> drawables = galaxy.getAllDrawables();
            drawables.Sort((a, b) => a.Alpha > b.Alpha ? 1 : -1);

            foreach (IDrawable drawable in drawables)
            {
                PointF loc = drawable.Location;
                PointF des = drawable.Destination;
                double x = des.X - loc.X;
                double y = des.Y - loc.Y;
                double c = Math.Sqrt(x * x + y * y);

                loc.X = (float)(_lag * drawable.Speed * x / c);
                loc.Y = (float)(_lag * drawable.Speed * y / c);
                drawable.Location = loc;

                graphics.DrawImage(drawable.Model as Image,
                    drawable.Location.X, drawable.Location.Y, drawable.Size.Width, drawable.Size.Height);
            }
        }


        private void update(Galaxy galaxy)
        {
            galaxy.Civilizations.ForEach(civ => civ.Planets.ForEach(planet => civ.Behavior.produce(planet, civ)));
            galaxy.Civilizations.ForEach(civ => civ.Behavior.execute(galaxy, civ));
            galaxy.deleteAllDeadShips();
        }

        private void processInput(Form form, Galaxy galaxy)
        {
            return;
            //MainForm mainForm = (MainForm)form;
        }
    }
}
