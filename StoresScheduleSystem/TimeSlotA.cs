using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class TimeSlotA:TimeSlot
    {
        public override string GetOpeningTime(bool isEssentials)
        {
            // Donot change method signature
            // Implement code here
            if (isEssentials)
            {
                return "08:00 AM";
            }
            else
            {
                return "10:00 AM";
            }
        }
        public override string GetClosingTime(bool isEssentials)
        {
            // Donot change method signature
            // Implement code here
            if (isEssentials)
            {
                return "02:00 PM";
            }
            else
            {
                return "2:00 PM";
            }
        }
    }
}
