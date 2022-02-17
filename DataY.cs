using System;

namespace Logic.InnerDataTypes
{
    public class DataY : IComparable<DataY>
    {
        public double Y {get; set; }
        public int Count { get; set; }

        public DataY(double y)
        {
            Y = y;
        }
        

        public int CompareTo(DataY other)
        {
            return Y.CompareTo(other.Y);
        }
    }
}
