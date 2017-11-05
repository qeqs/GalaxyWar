using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyWar.model;
using GalaxyWar.model.drawable;
using GalaxyWar.model.drawable.impls;

namespace GalaxyWar.logic.impls.ships
{
    class BomberBehavior : AbstractShipBehavior
    {
        public override void execute(Galaxy galaxy, SpaceShip ship, ShipState state)
        {
            var aim = aimSearcher.search(
                ship,
                galaxy.SpaceObjects.FindAll(obj => obj is Planet).ToList<IDrawable>(),
                ship.Civilization.Behavior.AimSearcherRange);
            executeBehavior(galaxy, ship, state, aim);
        }

    }
}
