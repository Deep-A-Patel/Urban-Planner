using System;
using System.Collections.Generic;

namespace Planner
{
    public class Building
    {
        // This is called a field, and not a property
        // By convention these are private, and internal to this class.
        // These do not explicitly specify getters and setters
        private string _designer = "Deep Patel";

        private DateTime _dateConstructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        // Properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return (Width * Depth * (3 * Stories));
            }
        }

        // These are constructors. Constructors are what gets called when
        // anyone calls:  new Building()
        // I can overload it, just like any other method
        public Building(string address)
        {
            _address = address;
        }

        // Set construction date
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        // Set building owner
        public void Purchase(string owner)
        {
            _owner = owner;
        }

        // Print building data
        public void BuildingDeets()
        {
            Console.WriteLine($"{_address}");
            Console.WriteLine("********************");
            Console.WriteLine($"Designed by {_designer}");
            Console.WriteLine($"Constructed on {_dateConstructed}");
            Console.WriteLine($"Owned by {_owner}");
            Console.WriteLine($"{Volume} cubic meters of space");
            Console.WriteLine("--------------------");
        }
    }
}