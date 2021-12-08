using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    // Состав стены
    class Wall
    {
        // Из чего строится дом
        public string Type { get; set; }
    }
    // Цемент
    class Cement
    { }
    // Стройительные материалы
    class BuildingMaterials
    {
        public string Name { get; set; }
    }
    // Стекло
    class Glass
    { }

    class House
    {
        // Стена
        public Wall Wall { get; set; }
        // Цемент
        public Cement Cement { get; set; }
        // Строительные материалы
        public BuildingMaterials BuildingMaterials { get; set; }
        // Стекло
        public Glass Glass { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (Wall != null)
                sb.Append(Wall.Type + "\n");
            if (Cement != null)
                sb.Append("Цемент \n");
            if (Glass != null)
                sb.Append("Стекло \n");
            if (BuildingMaterials != null)
                sb.Append("Строительные материалы: " + BuildingMaterials.Name + " \n");
            return sb.ToString();
        }
    }
}
