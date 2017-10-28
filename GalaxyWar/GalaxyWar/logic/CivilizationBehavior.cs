using GalaxyWar.model;
using GalaxyWar.model.drawable.impls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalaxyWar.logic
{
    interface CivilizationBehavior
    {
        void produce(Planet planet, Civilization civilization);
        void execute(Galaxy galaxy ,Civilization civilization);
    }
}
