﻿using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {
        //public int Id { get; }
        //private static int nextId = 1;
        //public string Value { get; set; }

        //public PositionType()
        //{
        //    Id = nextId;
        //    nextId++;
        //}

        //public PositionType(string value) : this()
        //{
        //    Value = value;
        //}

        //// TODO: Add custom Equals(), GetHashCode(), and ToString() methods.

        ////QUESTION: do i need to do an Equals and GetHasCode for value? We don't in the other classes, so my guess is no.//
        //public override bool Equals(object obj)
        //{
        //    return obj is PositionType type &&
        //           Id == type.Id;
        //}

        //public override int GetHashCode()
        //{
        //    return HashCode.Combine(Id);
        //}

        //public override string ToString()
        //{
        //    return Value;
        //}

        public PositionType(string value) : base(value)
        {
            
        }
    }
}
