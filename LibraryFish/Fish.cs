using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_monitoring
{
    class Fish
    {
        public int maxTemp;
        public int minTemp;
        public int time;

        public Fish(int t1, int t2, int t3)
        {
            t1 = maxTemp;
            t2 = minTemp;
            t3 = time;
        }

        public virtual void Inf()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
