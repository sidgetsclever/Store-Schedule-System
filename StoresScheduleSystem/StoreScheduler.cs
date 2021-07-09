using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class StoreScheduler
    {
          StoresScheduleDAO StoresScheduleDAO = new StoresScheduleDAO();
        public StoreScheduler()
        {
            // Instantiate fields here
        }
        public Store AssignTimings(Store store, string timeSlot)
        {
            // Donot change method signature
            // Implement code here
           // TimeSlot TimeSlot = new TimeSlot();
           //if(timeSlot=="TimeSlotA")
           // {
           //     store.OpeningTime = TimeSlot.GetOpeningTime();
           //     store.ClosingTime = TimeSlot.GetClosingTime();
           // }
           //else if(timeSlot=="TimeSlotB")
           // {
           //     store.OpeningTime = TimeSlot.GetOpeningTime();
           //     store.ClosingTime = TimeSlot.GetClosingTime();

           // }

            
            return store;
        }

        public Store GetStoreById(int storeId)
        {
            Store Store = new Store();


            // Donot change method signature
            // Implement code here
            DataTable dt = StoresScheduleDAO.FindStore(storeId);
            if(dt!=null && dt.Rows.Count>0)
            {
                Store.MobileNo = dt.Rows[0]["MobileNo"].ToString();
                Store.StoreName = dt.Rows[0]["StoreName"].ToString();
                Store.OwnerName = dt.Rows[0]["OwnerName"].ToString();
                Store.StoreId = Convert.ToInt32(dt.Rows[0]["StoreId"]);
                Store.StoreAddress = dt.Rows[0]["StoreAddress"].ToString();
                Store.SellsEssentials = Convert.ToBoolean(dt.Rows[0]["SellsEssentials"]);
                Store.OpeningTime = dt.Rows[0]["OpeningTime"].ToString();
                Store.ClosingTime = dt.Rows[0]["ClosingTime"].ToString();

            }


            return Store;
        }

        public bool UpdateStoreTimings(Store store, string timeSlot)
        {
            bool IsUpdated = false;
            // Donot change method signature
            // Implement code here

            TimeSlotA timeSlotA = new TimeSlotA();
            TimeSlotB timeSlotB = new TimeSlotB();
            if (timeSlot == "timeSlotA" || timeSlot=="TimeSlotA")
            {
                store.OpeningTime = timeSlotA.GetOpeningTime(store.SellsEssentials);
                store.ClosingTime = timeSlotA.GetClosingTime(store.SellsEssentials);
            }
            else if(timeSlot == "timeSlotB" || timeSlot == "TimeSlotB")
            {
                store.OpeningTime = timeSlotB.GetOpeningTime(store.SellsEssentials);
                store.ClosingTime = timeSlotB.GetClosingTime(store.SellsEssentials);
            }
            else
            {
                throw new Exception("Error : Invalid Time Slot");
            }
            StoresScheduleDAO storesScheduleDAO = new StoresScheduleDAO();
    
            int a = storesScheduleDAO.UpdateStore(store.StoreId, store.OpeningTime, store.ClosingTime);
            if (a > 0)
                IsUpdated = true;
            
            return IsUpdated;
        }
    }
}
