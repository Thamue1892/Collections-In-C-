using System;

namespace SortingACollection
{
    public class Car : IComparable<Car>
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public string Color { get; set; }


        public int CompareTo(Car other)
        {
            int compare;
            compare = String.Compare(this.Color, other.Color, true);
            if (compare == 0)
            {
                compare = this.Speed.CompareTo(other.Speed);

                //Use descending order for speed.
                compare = -compare;
            }
            return compare;
        }
    }
}