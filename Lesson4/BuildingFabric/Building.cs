namespace BuildingFabric
{
    abstract class Building
    {
        private static int counter = 0;

        internal Building(
            int BuildingHeight,
            int AmountsOfFloor,
            int AppartmentNumbers,
            int AmountsOfEntrance)
        {
            this.BuildingID = GenerateBuildingNumber();
            this.BuildingHeight = BuildingHeight;
            this.AmountsOfFloor = AmountsOfFloor;
            this.AppartmentNumbers = AppartmentNumbers;
            this.AmountsOfEntrance = AmountsOfEntrance;
        }

        internal int BuildingID { get; set; }
        internal int BuildingHeight { get; set; }
        internal int AmountsOfFloor { get; set; }
        internal int AppartmentNumbers { get; set; }
        internal int AmountsOfEntrance { get; set; }

        public int CalcFloorHeight()
        {
            int floorHeight;
            if (this.BuildingHeight != 0)
            {
                floorHeight = this.BuildingHeight / this.AmountsOfFloor;
                return floorHeight;
            }
            return default;
        }

        public int AmountOfAppartmentInEntrance()
        {
            int amountsAppEntr;
            if(this.AmountsOfEntrance > 0)
            {
                amountsAppEntr = (this.AppartmentNumbers / this.AmountsOfEntrance) / this.AmountsOfFloor;
                return amountsAppEntr;
            }
            return default;
        }

        public int AmountOfAppartmentOnFloor()
        {
            int amountAppOnFloor = this.AmountsOfFloor / this.AppartmentNumbers;
            return amountAppOnFloor;
        }

        public int GenerateBuildingNumber()
        {
            counter = counter + 1;
            this.BuildingID = counter;
            return this.BuildingID;
        }
    }
}