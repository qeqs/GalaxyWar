using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyWar.model;
using GalaxyWar.model.drawable;
using System.Drawing;

namespace GalaxyWar.logic.impls.ships
{
    class FighterBehavior : AbstractShipBehavior
    {
        public override void execute(Galaxy galaxy, SpaceShip ship, ShipState state)
        {
            var aim = aimSearcher.search(ship, galaxy.getAllSpaceShips().ToList<IDrawable>(), ship.Civilization.Behavior.AimSearcherRange);
            executeBehavior(galaxy, ship, state, aim);
        }
       
    }
}
