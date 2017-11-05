using GalaxyWar.model;
using GalaxyWar.model.drawable;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.logic.impls.ships
{
    abstract class AbstractShipBehavior: Behavior
    {
        protected AimSearcher aimSearcher = new AimSearcher();
        public abstract void execute(Galaxy galaxy, SpaceShip ship, ShipState state);

        protected void executeBehavior(Galaxy galaxy, SpaceShip ship, ShipState state, KeyValuePair<bool, IDrawable> foundedAim)
        {
            switch (state)
            {
                case ShipState.auto:
                    if (foundedAim.Key)
                    {
                        executeBehavior(galaxy, ship, ShipState.aggressive, foundedAim);
                    }
                    else
                    {
                        executeBehavior(galaxy, ship, ShipState.passive, foundedAim);
                    }
                    break;

                case ShipState.aggressive:
                    if (foundedAim.Key)
                    {
                        IDrawable aim = foundedAim.Value;
                        RectangleF enemy = new RectangleF(aim.Location, aim.Size);
                        RectangleF me = new RectangleF(ship.Location, ship.Size);

                        if (me.IntersectsWith(enemy))
                        {
                            ship.CalculateFight(aim);
                        }

                    }
                    break;

                case ShipState.passive:
                    aimSearcher.pending(galaxy, ship);
                    break;
            }
        }
        
    }
}
