using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class TimeSlotB:TimeSlot
    {
        public override string GetOpeningTime(bool isEssentials)
        {
            // Donot change method signature
            // Implement code here
            if (isEssentials)
            {
                return "02:00 PM";
            }
            else
            {
                return "4:00 PM";
            }
        }
        public override string GetClosingTime(bool isEssentials)
        {
            // Donot change method signature
            // Implement code here
            if (isEssentials)
            {
                return "08:00 PM";
            }
            else
            {
                return "08:00 PM";
            }
        }
    }
}
