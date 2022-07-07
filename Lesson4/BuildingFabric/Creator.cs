using System.Collections;
namespace BuildingFabric
{
    internal abstract class Creator
    {
        internal static Hashtable hashtable = new();
        internal abstract Building CreateBuilding(
            int BuildingHeight,
            int AmountsOfFloor,
            int AppartmentNumbers,
            int AmountsOfEntrance);
    }
}
