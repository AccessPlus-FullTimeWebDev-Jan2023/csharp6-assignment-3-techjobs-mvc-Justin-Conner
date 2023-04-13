using System;
using System.Diagnostics;

namespace TechJobsMVCAutograded6.Models;

public class PositionType : JobField
{
    public PositionType(string value) : base(value) { }
    public string Name
    {
        get { return Value; }
        set { Value = value; }
    }
}

