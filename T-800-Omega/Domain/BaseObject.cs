using System;
using System.Collections.Generic;
using System.Text;

namespace T800.Domain
{
    class BaseObject

    {       
         public int ObjectId { get; set; }
         public bool Destructable { get; set; }

            public BaseObject(int objectid, bool destructable)
            {
                ObjectId = objectid;
                Destructable = destructable;
            }
        public override string ToString()
        {
            return Convert.ToString(ObjectId);
        }

    }
}

