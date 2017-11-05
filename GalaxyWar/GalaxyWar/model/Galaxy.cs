using GalaxyWar.model.drawable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model
{
    class Galaxy
    {
        private List<Civilization> civilizations;
        private List<SpaceObject> spaceObjects;

        public List<IDrawable> getAllDrawables()
        {
            List<IDrawable> drawables = new List<IDrawable>();
            drawables.AddRange(SpaceObjects);
            foreach (Civilization civ in Civilizations)
                drawables.AddRange(civ.Fleet);
            return drawables;
        }

        public List<SpaceShip> getAllSpaceShips()
        {
            List<SpaceShip> drawables = new List<SpaceShip>();
            foreach (Civilization civ in Civilizations)
                drawables.AddRange(civ.Fleet);
            return drawables;
        }

        public void deleteAllDeadShips()
        {
            foreach (Civilization civ in Civilizations)
                civ.Fleet.RemoveAll(ship => ship.Health <= 0);
        }

        public List<Civilization> Civilizations
        {
            get
            {
                return civilizations;
            }
        }

        public List<SpaceObject> SpaceObjects
        {
            get
            {
                return spaceObjects;
            }

            set
            {
                spaceObjects = value;
            }
        }
    }
}
