using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextCar2
{
    class PintuController
    {
        private Pintu pintunya;

        public PintuController()
        {
            this.pintunya = new Pintu(4);
        }
        public Boolean PintuIsLocked()
        {
            return this.pintunya.isLocked();
        }
        public Boolean PintuIsUnLocked()
        {
            return this.pintunya.isUnLocked();
        }
        public void lockedOn()
        {
            this.pintunya.kunci();
        }
        public void lockedOff()
        {
            this.pintunya.bukaKunci();
        }
    }
}
