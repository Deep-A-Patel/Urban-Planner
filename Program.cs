using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building danTower = new Building("513 9th Avenue")
            {
                Width = 124,
                Stories = 42,
                Depth = 225
            };
            danTower.Construct();
            danTower.Purchase("Deep Patel");

            Building joeTower = new Building("514 11th Avenue")
            {
                Width = 114,
                Stories = 2,
                Depth = 125
            };
            joeTower.Construct();
            joeTower.Purchase("Deep Patel");

            Building supermanBuilding = new Building("515 12th Avenue")
            {
                Width = 153,
                Stories = 14,
                Depth = 225
            };
            supermanBuilding.Construct();
            supermanBuilding.Purchase("Deep Patel");

            Building nssBuilding = new Building("516 14th Avenue")
            {
                Width = 153,
                Stories = 14,
                Depth = 225
            };
            nssBuilding.Construct();
            nssBuilding.Purchase("Deep Patel");

            // Create new instance of the City class
            City Maldivs = new City();

            // Establish when the city was founded
            Maldivs.Founded();

            // Add mayor
            Maldivs.Election("Batman");

            // Add buildings to city list
            Maldivs.AddBuilding(danTower);
            Maldivs.AddBuilding(joeTower);
            Maldivs.AddBuilding(supermanBuilding);
            Maldivs.AddBuilding(nssBuilding);

            foreach (Building building in Maldivs.CityBuildings)
            {
                building.BuildingDeets();
            }
        }
    }
}