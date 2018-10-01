using System;
using System.Collections.Generic;
using System.Text;

namespace T800.Domain
{
    class T800Collection
    {
        private List<T800> t800List = new List<T800>();
        public T800Collection()
        {
            for(int i = 0; i < 5; i++)
            {
                t800List.Add(new T800(i + 1, true, true, true, null));
            }
        }
        public void AttackAllTargets()
        {
            foreach(T800 t800 in t800List)
            {
                t800.Attack();
            }
        }

    }
}
