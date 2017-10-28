using GalaxyWar.logic;
using GalaxyWar.model.drawable;
using GalaxyWar.model.drawable.impls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.model
{
    class Civilization
    {
        private List<SpaceShip> fleet;
        private List<Planet> planets;
        private CivilizationBehavior behavior;
        private Color color;

        public List<SpaceShip> Fleet
        {
            get
            {
                return fleet;
            }
        }

        public List<Planet> Planets
        {
            get
            {
                return planets;
            }
        }

        public CivilizationBehavior Behavior
        {
            get
            {
                return behavior;
            }

            set
            {
                behavior = value;
            }
        }

        public Color Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }
        
    }
}
