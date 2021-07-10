using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class TimeSlotA:TimeSlot
    {
        
        public override string GetOpeningTime()
        {
            // Donot change method signature
            // Implement code here
          
            if (this.isEssentialItemsStore)
            {
                return "08:00 AM";
            }
            else
            {
                return "10:00 AM";
            }
            
         
        }
        public override string GetClosingTime()
        {
     
            if (this.isEssentialItemsStore)
            {

                return "02:00 PM";
            }
            else
            {
                return "02:00 PM";
            }
            
          
        }
    }
}
