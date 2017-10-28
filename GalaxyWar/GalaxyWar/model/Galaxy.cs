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
