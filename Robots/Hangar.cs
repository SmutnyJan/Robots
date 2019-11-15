using System;
using System.Collections.Generic;
using System.Text;

namespace Robots
{
    class Hangar
    {
        public Hangar() {
            Storage = new List<RoboticPart>();
            Storage.Add(new RoboticChasis("Albert))
        }
        public List<RoboticPart> Storage { get; set; }
    }
}
