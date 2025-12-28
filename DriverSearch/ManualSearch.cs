using System;
using System.Collections.Generic;

namespace DriverSearch
{
    public class ManualSearch
    {
        public List<Driver> Find(List<Driver> drivers, double x, double y)
        {
            if (drivers == null)
                throw new ArgumentNullException(nameof(drivers));

            var result = new List<Driver>();
            var remaining = new List<Driver>(drivers);

            for (int i = 0; i < 5 && remaining.Count > 0; i++)
            {
                Driver closest = remaining[0];
                double minDistance = Distance.Calculate(closest.X, closest.Y, x, y);

                foreach (var driver in remaining)
                {
                    double dist = Distance.Calculate(driver.X, driver.Y, x, y);
                    if (dist < minDistance)
                    {
                        minDistance = dist;
                        closest = driver;
                    }
                }

                result.Add(closest);
                remaining.Remove(closest);
            }

            return result;
        }
    }
}