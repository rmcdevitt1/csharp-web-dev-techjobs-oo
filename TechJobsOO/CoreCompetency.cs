﻿using System;
namespace TechJobsOO
{
    public class CoreCompetency : JobField
    {
        //    private int Id { get; } //or should this be public??
        //    private static int nextId = 1;
        //    public string Value { get; set; }

        //// TODO: Change the fields to auto-implemented properties.

        //    public CoreCompetency()
        //    {
        //        Id = nextId;
        //        nextId++;
        //    }

        //    public CoreCompetency(string value) : this()
        //    {
        //        Value = value;
        //    }

        //    public override bool Equals(object obj)
        //    {
        //        return obj is CoreCompetency competency &&
        //               Id == competency.Id;
        //    }

        //    public override int GetHashCode()
        //    {
        //        return HashCode.Combine(Id);
        //    }

        //    public override string ToString()
        //    {
        //        return Value;
        //    }

        public CoreCompetency(string value) : base(value)
        {
           
        }
    }
    
}
