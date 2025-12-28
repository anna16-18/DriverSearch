using System;
using System.Collections.Generic;
using System.Linq;

namespace DriverSearch
{
    public class QueueSearch
    {
        public List<Driver> Find(List<Driver> drivers, double x, double y)
        {
            if (drivers == null)
                throw new ArgumentNullException(nameof(drivers));

            return drivers
                .OrderBy(d => Distance.Calculate(d.X, d.Y, x, y))
                .Take(5)
                .ToList();
        }
    }
}