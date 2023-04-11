using System;

namespace TechJobsMVCAutograded6.Models
{
    public class Location : JobField
    {
        public Location(string value) : base(value) { }
        public string Name { get { return Value; } }
    }
}



