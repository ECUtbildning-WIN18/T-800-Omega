using System;
using System.Collections.Generic;
using System.Text;

namespace T800.Domain
{
    class T800 : BaseObject
    {
        public bool IsActivated { get; set; }
        public bool BatteryCharge { get; set; }
        public int Target { get; set; }

        public T800(int objectid, bool destructable, bool isActivated, bool batteryCharge, int target) : base(objectid, destructable)
        {
            IsActivated = isActivated;
            BatteryCharge = batteryCharge;
            Target = target;
        }

        public void SelfDestruct()
        {
            Console.WriteLine("Self destruction is successful");
        }
        public void Activate()
        {
            if (IsActivated == false)
                Console.WriteLine("Please Activate the T-800");
            else
                Console.WriteLine("T-800 is Activated");
        }
        public void Deactivate()
        {
            if (IsActivated == true)
                Console.WriteLine("'please Deactivate the T-800 to conserve power");
            else
                Console.WriteLine("Target-800 is Deactivated");
        }
        public void ChooseTarget()
        {
            Console.WriteLine("The target is choosen");
        }
        public void Attack()
        {
            if (Destructable == true)
                Console.WriteLine("Attack attack");
            else
                Console.WriteLine("Target is not destructable.I Cannot attack on it ");
        }
        public void ShowStatus()
        {
            if (BatteryCharge == true)
                Console.WriteLine("T-800 is fully charged and it is ready to use");
            else
                Console.WriteLine("T-800 is out of battery please charge it");
        }
    }
}
