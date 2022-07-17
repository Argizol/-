
namespace BuildingFabric
{
    public class Test
    {
        public static void Run()
        {
            var createrA = new CreaterBuildingTypeA();

            var house1 = createrA.CreateBuilding(30, 15, 200, 4);
            var house2 = createrA.CreateBuilding(30, 15, 200, 4);
            var house3 = createrA.CreateBuilding(30, 15, 200, 4);
            var house4 = createrA.CreateBuilding(30, 15, 200, 4);
            Creator.hashtable.Add(house1.BuildingID, house1);
            Creator.hashtable.Add(house2.BuildingID, house2);
            Creator.hashtable.Add(house3.BuildingID, house3);
            Creator.hashtable.Add(house4.BuildingID, house4);

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
