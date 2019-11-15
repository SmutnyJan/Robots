using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    abstract class RoboticPart
    {
        public virtual string StatusMessage { get { return "This is General Robotic Part."; } }
        public double Consumption { get { return DeviceConsumption; } }
        public virtual double DeviceConsumption { get; protected set; }
    }
}
