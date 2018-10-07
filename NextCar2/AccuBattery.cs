using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar2
{
    class AccuBattery
    {
        private int voltage;
        private Boolean stateOn = false;
        private Boolean stateOff = true;

        public AccuBattery(int voltage)
        {
            this.voltage = voltage;
        }

        public void turnOn()
        {
            this.stateOn = true;
        }
        public void turnOff()
        {
            this.stateOn = false;
        }
        public Boolean isOn()
        {
            return this.stateOn;
        }
        public Boolean isOff()
        {
            return this.stateOff;
        }
    }
}
