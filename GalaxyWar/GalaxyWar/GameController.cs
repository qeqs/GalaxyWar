using GalaxyWar.model;
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
            throw new NotImplementedException();
        }

        private void update(Galaxy galaxy)
        {
            throw new NotImplementedException();
        }

        private void processInput(UserInput userInput , Galaxy galaxy)
        {
            throw new NotImplementedException();
        }
    }
}
