using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        // Fields
        private DateTime _yearEstablished;
        private string _mayor;

        // Properties
        public string Name { get; set; }

        // These are my constructors. Constructors are what gets called when
        // anyone calls:  new Car()
        // I can overload it, just like any other method
        // Here I have one constructor that takes an int, and another that takes no parameters
        public List<Building> CityBuildings { get; set; } = new List<Building>();

        public void AddBuilding(Building building)
        {
            CityBuildings.Add(building);
        }

        public void Founded()
        {
            _yearEstablished = DateTime.Now;
        }

        public void Election(string mayor)
        {
            _mayor = mayor;
        }
    }
}