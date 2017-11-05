using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaxyWar.model;
using GalaxyWar.model.drawable.impls;

namespace GalaxyWar.logic.impls
{
    class PassiveCivilizationBehavior : CivilizationBehavior
    {
        private static double fighterRate = double.Parse(Properties.Resources.passive_fighter);
        private static double bomberRate = double.Parse(Properties.Resources.passive_bomber);
        private static double colonyRate = double.Parse(Properties.Resources.passive_colony);

        public override float AimSearcherRange
        {
            get
            {
                return float.Parse(Properties.Resources.passive_aim_range);
            }
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
