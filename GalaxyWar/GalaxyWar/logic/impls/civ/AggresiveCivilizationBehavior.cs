using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyWar.model;
using GalaxyWar.model.drawable.impls;

namespace GalaxyWar.logic.impls
{
    class AggresiveCivilizationBehavior : CivilizationBehavior
    {
        private static double fighterRate = double.Parse(Properties.Resources.aggressive_fighter);
        private static double bomberRate = double.Parse(Properties.Resources.aggressive_bomber);
        private static double colonyRate = double.Parse(Properties.Resources.aggressive_colony);

        public override float AimSearcherRange
        {
            get
            {
                return float.Parse(Properties.Resources.aggressive_aim_range);
            }
        }

        public override void execute(Galaxy galaxy, Civilization civilization)
        {
            civilization.Fleet.ForEach(ship => ship.Behavior.execute(galaxy, ship, ShipState.aggressive));
        }

        public override void produce(Planet planet, Civilization civilization)
        {
            fighters += fighterRate;
            bombers += bomberRate;
            colonies += colonyRate;

            base.produce(planet, civilization);
        }
    }
}
