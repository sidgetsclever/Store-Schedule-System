using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class TimeSlotB:TimeSlot
    {
      
        public override string GetOpeningTime()
        {
            // Donot change method signature
            // Implement code here
           

            if (this.isEssentialItemsStore)
            {
                return "02:00 PM";
            }
            else
            {
                return "04:00 PM";
            }
         
        }
        public override string GetClosingTime()
        {
            // Donot change method signature
            // Implement code here
           
            Console.WriteLine("Close in b: " + this.isEssentialItemsStore);
            if (this.isEssentialItemsStore)
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
