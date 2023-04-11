using System;

namespace TechJobsMVCAutograded6.Models
{
    public class Employer : JobField
    {
        // Add a Name property
        public string Name { get; set; }

        public Employer(string value, string name) : base(value)
        {
            // Set the Name property
            Name = name;
        }

        public Employer(string value) : base(value)
        {
        }
    }
}



