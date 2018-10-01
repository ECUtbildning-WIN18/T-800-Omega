using System;
using System.Collections.Generic;
using System.Text;

namespace T800.Domain
{
    class T800 : BaseObject
    {
        public bool IsActivated { get; set; }
        public bool BatteryCharge { get; set; }
        public BaseObject Target { get; set; }

        public T800(int objectid, bool destructable, bool isActivated, bool batteryCharge, BaseObject target) : base(objectid, destructable)
        {
            IsActivated = isActivated;
            BatteryCharge = batteryCharge;
            Target = target;
        }

        public void SelfDestruct()
        {
            IsActivated = false;
            BatteryCharge = false;
            Target = null;
                Console.WriteLine("Self destruction is successful");
        }
        public void Activate()
        {
            IsActivated = true;
            Console.WriteLine("T-800 is Activated");
        }
        public void Deactivate()
        {
            IsActivated = false;
            Console.WriteLine("T-800 is Deactivated");
        }
        public void ChooseTarget(BaseObject target)
        {
            Target = target;
            Console.WriteLine("The target is choosen");
        }
        public void Attack()
        {
            if (Target.Destructable==true)
            {
                Target.Destructable = false;
                Target = null;
                Console.WriteLine("Attack attack");
            }                
            else
            {
                Target = null;
                Console.WriteLine("Target is not destructable.I Cannot attack on it ");
            }
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
