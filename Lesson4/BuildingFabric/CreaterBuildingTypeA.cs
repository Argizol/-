

namespace BuildingFabric
{
    internal class CreaterBuildingTypeA : Creator
    {
        internal override void CreateBuilding(
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
            hashtable.Add(building.BuildingID,building);
        }
    }
}
