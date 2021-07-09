using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoresScheduleSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string Continue = "y";
            StoreScheduler StoreScheduler = new StoreScheduler();
            if (Continue.ToLower() == "n")
            {
                System.Environment.Exit(1);
            }
            else
            {
                while (Continue.ToLower() == "y")
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("=========     GHMC Stores Scheduler     =========");
                    Console.WriteLine("-------------------------------------------------");
                    try
                    {
                        FindAndUpdateStore(StoreScheduler);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error : " + ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine();
                        Console.Write("Do you want to continue for another store(y/n) :");
                        Continue = Console.ReadLine();
                    }
                }
            }

            
        }

        private static void FindAndUpdateStore(StoreScheduler StoreScheduler)
        {
            // Donot change method signature
            // Implement code here
            // Console.WriteLine("Enter store id");
            //int id = Convert.ToInt32(Console.ReadLine());
            // StoreScheduler s = new StoreScheduler();
            // DataTable d = new DataTable();
            //d= s.GetStoreById(id);


            // s.UpdateStoreTimings();
            StoreScheduler storeScheduler = new StoreScheduler();
            Console.WriteLine("Enter store id");
            int id = Convert.ToInt32(Console.ReadLine());
           
            Store store = storeScheduler.GetStoreById(id);
                if (store.StoreId == id)
                {
                    Console.WriteLine("Found a store with following details");
                    Console.WriteLine("StoreName : " + store.StoreName);
                    Console.WriteLine("OwnerName : " + store.OwnerName);
                    Console.WriteLine("MobileNo : " + store.MobileNo);
                    Console.WriteLine("StoreAddress : " + store.StoreAddress);
                    Console.WriteLine("SellsEssentials : " + store.SellsEssentials);
                    Console.WriteLine("OpeningTime : " + store.OpeningTime);
                    Console.WriteLine("ClosingTime : " + store.ClosingTime);
                    Console.WriteLine("Enter the Timeslot assigned to store (TimeSlotA/TimeSlotB)");
                    try
                    {
                        string timeslot = Console.ReadLine();

                       storeScheduler.UpdateStoreTimings(store, timeslot);

                        Console.WriteLine("Time slot updated for the store {0}", store.StoreName);

                  
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            else
            {
                Console.WriteLine("No store found for store id : {0}", id);
            }



        }
    }
}

