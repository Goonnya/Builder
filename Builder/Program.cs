using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем объект архитектор
            Architect architect = new Architect();
            // создаем билдер для деревянного дома
            HouseBuilder builder = new WoodHouseBuilder();
            // проектируем
            House woodHouse = architect.Design(builder);
            Console.WriteLine(woodHouse.ToString());
            // создаем билдер для кирпичного дома
            builder = new BrickHouseBuilder();
            // проектируем
            House brickHouse = architect.Design(builder);
            Console.WriteLine(brickHouse.ToString());

            Console.ReadLine();
        }
    }
    // абстрактный класс строителя
    abstract class HouseBuilder
    {
        public House House { get; private set; }
        public void CreateHouse()
        {
            House = new House();
        }
        public abstract void SetWall();
        public abstract void SetCement();
        public abstract void SetBuildingMaterials();
        public abstract void SetGlass();
    }
    // Архитектор
    class Architect
    {
        public House Design(HouseBuilder houseBuilder)
        {
            houseBuilder.CreateHouse();
            houseBuilder.SetWall();
            houseBuilder.SetCement();
            houseBuilder.SetBuildingMaterials();
            houseBuilder.SetGlass();
            return houseBuilder.House;
        }
    }
    // строитель для деревянного дома
    class WoodHouseBuilder : HouseBuilder
    {
        public override void SetWall()
        {
            this.House.Wall = new Wall { Type = "Брёвна для стен" };
        }
        public override void SetGlass()
        {
            this.House.Glass = new Glass();
        }

        public override void SetCement()
        {
            this.House.Cement = new Cement();
        }

        public override void SetBuildingMaterials()
        {
            this.House.BuildingMaterials = new BuildingMaterials { Name = "Лак для дерева, гвозди" };
        }
    }
    // строитель для кирпичного дома
    class BrickHouseBuilder : HouseBuilder
    {
        public override void SetWall()
        {
            this.House.Wall = new Wall { Type = "Кирпичи" };
        }

        public override void SetCement()
        {
            this.House.Cement = new Cement();
        }
        public override void SetGlass()
        {
            this.House.Glass = new Glass();
        }

        public override void SetBuildingMaterials()
        {
            this.House.BuildingMaterials = new BuildingMaterials { Name = "Краска, штукатурка, обои" };
        }
    }
}
