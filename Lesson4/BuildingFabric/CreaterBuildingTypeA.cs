

namespace BuildingFabric
{
    internal class CreaterBuildingTypeA : Creator
    {
        internal override Building CreateBuilding(
            int BuildingHeight,
            int AmountsOfFloor,
            int AppartmentNumbers,
            int AmountsOfEntrance)
        {
            var building = new BuildingTypeA(
                BuildingHeight,
                AmountsOfFloor,
                AppartmentNumbers,
                AmountsOfEntrance);
            return building;

        }
    }
}
