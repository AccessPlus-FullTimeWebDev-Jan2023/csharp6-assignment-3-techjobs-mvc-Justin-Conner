using System;

namespace TechJobsMVCAutograded6.Models
{
    public class CoreCompetency : JobField
    {
        public CoreCompetency(string value) : base(value) { }

        public string Name
        {
            get { return "Core Competency"; }
            set { }
        }
    }
}
