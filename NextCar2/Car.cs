using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar2
{
    class Car
    {
        AccuBatteryController AccuBatteryController;
        PintuController pintuContoller;

        public void setAccubaterryController(AccuBatteryController AccuBatteryController)
        {
            this.AccuBatteryController = AccuBatteryController;
        }

        public void SetPintuController(PintuController pintucontroller)
        {
            this.pintuContoller = pintucontroller;
        }

        public void turnOnPower()
        {
            this.AccuBatteryController.turnOn();
        }
        public void turnOfPower()
        {
            this.AccuBatteryController.turnOff();
        }

        public Boolean powerIsReady()
        {
            return this.AccuBatteryController.accubatterryIsOn();
        }
        public Boolean powerIsNotReady()
        {
            return this.AccuBatteryController.accubatterryIsOff();
        }

        public void lockPintu()
        {
            this.pintuContoller.lockedOn();
        }
        public void unlockPintu()
        {
            this.pintuContoller.lockedOff();
        }
        public Boolean PintuIsLocked()
        {
            return this.pintuContoller.PintuIsLocked();
        }
        public Boolean PintuIsUnLocked()
        {
            return this.pintuContoller.PintuIsUnLocked();
        }

    }
}
