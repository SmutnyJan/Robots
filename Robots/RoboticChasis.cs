using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    class RoboticChasis : RoboticPart
    {
        public RoboticChasis(string name, double battery, double consumption) {
            Name = name;
            MaxBatteryCapacity = battery;
            DeviceConsumption = consumption;
            RemainingBatteryCapacity = MaxBatteryCapacity;
        }
        public string Name { get; protected set; }
        public double MaxBatteryCapacity { get; protected set; }
        public double RemainingBatteryCapacity { get; protected set; }
    }
}
