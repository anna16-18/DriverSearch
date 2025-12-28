using System;
using System.Collections.Generic;

namespace DriverSearch
{
    public class SortSearch
    {
        public List<Driver> Find(List<Driver> drivers, double x, double y)
        {
            if (drivers == null)
                throw new ArgumentNullException(nameof(drivers));

            var list = new List<Driver>(drivers);

            list.Sort((a, b) =>
                Distance.Calculate(a.X, a.Y, x, y)
                .CompareTo(Distance.Calculate(b.X, b.Y, x, y)));

            return list.Count > 5 ? list.GetRange(0, 5) : list;
        }
    }
}