using GalaxyWar.model;
using GalaxyWar.model.drawable;
using GalaxyWar.model.drawable.impls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.logic
{
    abstract class CivilizationBehavior
    {
        protected double fighters = 0.0;
        protected double bombers = 0.0;
        protected double colonies = 0.0;


        public virtual void produce(Planet planet, Civilization civilization)
        {

            List<SpaceShip> ships = new List<SpaceShip>();

            if (fighters >= 1)
            {
                fighters -= 1.0;
                Fighter fighter = new Fighter(planet.Location, civilization.Color, civilization);
                ships.Add(fighter);
            }

            if (bombers >= 1)
            {
                bombers -= 1.0;
                Bomber bomber = new Bomber(planet.Location, civilization.Color, civilization);
                ships.Add(bomber);
            }

            if (colonies >= 1)
            {
                colonies -= 1.0;
                Colony colony = new Colony(planet.Location, civilization.Color, civilization);
                ships.Add(colony);
            }
            ships.ForEach(ship =>
            {
                planet.produce(ship);
                civilization.Fleet.Add(ship);
            });


        }
        public virtual void execute(Galaxy galaxy ,Civilization civilization)
        {
            civilization.Fleet.ForEach(ship => ship.Behavior.execute(galaxy, ship, ShipState.auto));
        }

        public abstract float AimSearcherRange { get; }
    }
}
