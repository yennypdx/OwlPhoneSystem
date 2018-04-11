using System;

namespace OwlPhoneSystem
{
    public class DeviceCallHistoryTest
    {
        public static void DeviceCallHistoryTests()
        {
            var device = new Device("MotoX4", "Motorola", 489.99m, "Lee Seungi",
                              new Battery { BatteryType = BatteryType.NiMH, HoursIdle = 14, HoursTalk = 6.5 },
                              new Display { NumberOfColors = 256, Size = 5.6 });

            var call1 = new Call
            {
                CallStart = DateTime.Now,
                DialedNumber = 5035445472,
                DurationInMinutes = 55
            };

            var call2 = new Call
            {
                CallStart = DateTime.Now,
                DialedNumber = 9714703141,
                DurationInMinutes = 90
            };

            var call3 = new Call
            {
                CallStart = DateTime.Now,
                DialedNumber = 5035445472,
                DurationInMinutes = 45
            };

            device.AddCall(call1);
            device.AddCall(call2);
            device.AddCall(call3);

            foreach (var call in device.CallHistory)
            {
                Console.WriteLine(call);
            }

            var totalCost = device.TotalCostCalculator(0.42m);
            Console.WriteLine("Total Cost for calls: " + totalCost.ToString("C"));

            //removing the longest call
            device.RemoveCall(call2);
            totalCost = device.TotalCostCalculator(0.42m);
            Console.WriteLine("Total Cost after removing the longest call: " + totalCost.ToString("C"));

            //clearing the call history
            device.ClearCallHistory();
            totalCost = device.TotalCostCalculator(0.42m);
            Console.WriteLine("Total Cost after clearing call history: " + totalCost.ToString("C"));
        }
    }
}
