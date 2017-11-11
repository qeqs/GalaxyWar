using GalaxyWar.logic;
using GalaxyWar.model.drawable;
using GalaxyWar.model.drawable.impls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model
{
    class Galaxy
    {
        private List<Civilization> civilizations = new List<Civilization>();
        private List<SpaceObject> spaceObjects = new List<SpaceObject>();

        private AimSearcher aimSearcher = new AimSearcher();

        public List<IDrawable> getAllDrawables()
        {
            List<IDrawable> drawables = new List<IDrawable>();
            drawables.AddRange(SpaceObjects);
            foreach (Civilization civ in Civilizations)
                drawables.AddRange(civ.Fleet);
            drawables.Sort((a, b) => a.Alpha > b.Alpha ? 1 : -1);
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

        public void planetsMovement()
        {
            spaceObjects
                .FindAll(obj => obj is Planet)
                .ForEach(planet => aimSearcher.pending(this, planet));
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
