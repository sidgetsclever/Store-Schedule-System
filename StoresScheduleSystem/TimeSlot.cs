using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class TimeSlot
    {
        protected bool isEssentialItemsStore;
       
        public void SetIsEssentialItemsStore(bool isEssentialItemsStore)
        {

           this.isEssentialItemsStore = isEssentialItemsStore;

        }
        public virtual string GetOpeningTime()
        {

                return "08:00 AM";

        }
        public virtual string GetClosingTime()
        {

                return "02:00 PM";
        }
    }
}
