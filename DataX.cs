using DataStuctures;
using System;

namespace Logic.InnerDataTypes
{
    public class DataX : IComparable<DataX>
    {   
        public double X { get; set; }

        public BST<DataY> DataY {get; set; }

        public DataX(double x,double y)
        {
            BST<DataY> data = new BST<DataY>();
            data.AddY(new DataY(y) { Y = y });
            X = x;
        }

        public int CompareTo(DataX other)
        {
            return X.CompareTo(other.X);
        }       
    }

    
}
