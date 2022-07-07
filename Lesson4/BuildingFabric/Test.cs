
namespace BuildingFabric
{
    public class Test
    {
        public static void Run()
        {
            var createrA = new CreaterBuildingTypeA();
            createrA.CreateBuilding(30, 15, 200, 4);
            createrA.CreateBuilding(30, 15, 200, 4);
            createrA.CreateBuilding(30, 15, 200, 4);
            createrA.CreateBuilding(30, 15, 200, 4);
            Console.WriteLine($"{Creator.hashtable.Count}");
            foreach (var item in Creator.hashtable.Values)
            {
                Console.WriteLine($"{((Building)item).BuildingID} {((Building)item).AppartmentNumbers}");
            }
            Creator.hashtable.Remove(2);
            Console.WriteLine();
            foreach (var item in Creator.hashtable.Values)
            {
                Console.WriteLine($"{((Building)item).BuildingID} {((Building)item).AppartmentNumbers}");
            }
        }
    }
}
