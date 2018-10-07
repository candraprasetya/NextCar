using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar2
{
    class AccuBatteryController
    {
        private AccuBattery accubattery;

        public AccuBatteryController()
        {
            this.accubattery = new AccuBattery(12);
        }
        public Boolean accubatterryIsOn()
        {
            return this.accubattery.isOn();
        }
        public Boolean accubatterryIsOff()
        {
            return this.accubattery.isOff();
        }
        public void turnOn()
        {
            this.accubattery.turnOn();
        }
        public void turnOff()
        {
            this.accubattery.turnOff();
        }
    }
}
