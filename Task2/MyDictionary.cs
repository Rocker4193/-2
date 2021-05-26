using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class MyDictionary<Tkey, Tval>
    {
        private int count = 0;
        private Tkey[] keysArray = null;
        private Tval[] valsArray = null;

        public int Count
        {
            get { return this.count; }
        }

        public void Add(Tkey key, Tval val)
        {
            this.count++;

            Array.Resize(ref keysArray, count);
            keysArray[count - 1] = key;

            Array.Resize(ref valsArray, count);
            valsArray[count - 1] = val;
        }

        public Tval this[Tkey key]
        {
            get
            {
                int ind = 0;
                for (int i = 0; i < keysArray.Length; i++)
                {
                    if (key.Equals(keysArray[i]))
                        ind = i;
                }
                return valsArray[ind];
            }
        }
    }
}
