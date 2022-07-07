using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingFabric
{
    internal class BuildingTypeA : Building
    {
        internal BuildingTypeA(
            int BuildingHeight,
            int AmountsOfFloor,
            int AppartmentNumbers,
            int AmountsOfEntrance) : base(BuildingHeight, AmountsOfFloor, AppartmentNumbers, AmountsOfEntrance)
        {

        }

    }
}
