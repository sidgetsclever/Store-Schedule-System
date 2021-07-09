using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class Store
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string OwnerName { get; set; }
        public string MobileNo { get; set; }
        public string StoreAddress { get; set; }
        public bool SellsEssentials { get; set; }
        public string OpeningTime { get; set; }
        public string ClosingTime { get; set; }
    }
}
