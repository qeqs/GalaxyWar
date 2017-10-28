using GalaxyWar.model;
using GalaxyWar.model.drawable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.logic
{
    interface Behavior
    {
        void execute(Galaxy galaxy, SpaceShip ship, ShipState state);
    }

    public enum ShipState
    {
        aggressive,
        passive,
        auto
    }
}
