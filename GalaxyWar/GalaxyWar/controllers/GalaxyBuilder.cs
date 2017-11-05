using GalaxyWar.logic;
using GalaxyWar.model;
using GalaxyWar.model.drawable.impls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.controllers
{
    class GalaxyBuilder
    {
        public Star buildStar(Galaxy galaxy, PointF location)
        {
            Star star = new Star(location);
            galaxy.SpaceObjects.Add(star);
            return star;
        }

        public Planet buildPlanet(Galaxy galaxy, PointF location, Civilization civ = null)
        {
            Planet planet = new Planet(location);
            planet.Civilization = civ;
            galaxy.SpaceObjects.Add(planet);
            return planet;
        }

        public Planet buildPlanet(Galaxy galaxy, PointF location, decimal metal, decimal carbon, decimal organic, Civilization civ = null)
        {
            Planet planet = new Planet(location, (int)metal, (int)carbon, (int)organic);
            if (civ != null)
                civ.Planets.Add(planet);
            planet.Civilization = civ;
            galaxy.SpaceObjects.Add(planet);
            return planet;
        }

        public Civilization buildCivilization(Galaxy galaxy, CivilizationBehavior behavior)
        {
            Civilization civ = new Civilization();
            civ.Behavior = behavior;
            galaxy.Civilizations.Add(civ);
            return civ;
        }
    }
}
