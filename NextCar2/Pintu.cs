using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar2
{
    class Pintu
    {
        private int pintunya;
        private Boolean stateOn = false;
        private Boolean stateOff = true;

        public Pintu(int pintunya)
        {
            this.pintunya = pintunya;
        }

        public void kunci()
        {
            this.stateOn = true;
        }
        public void bukaKunci()
        {
            this.stateOn = false;
        }
        public Boolean isLocked()
        {
            return this.stateOn;
        }
        public Boolean isUnLocked()
        {
            return this.stateOff;
        }
    }
}

