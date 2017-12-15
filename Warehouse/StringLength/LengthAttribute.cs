using System;

namespace StringLength
{
    internal class LengthAttribute : Attribute
    {
        public int MiniumLength { get; set; }
    }
}