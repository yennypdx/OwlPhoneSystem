using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlPhoneSystem
{
    public class DeviceTest
    {
        public static void DeviseTests()
        {
            var device1 = new Device("iPhone", "Apple", 790.99m, "Yenny Purwanto",
                                new Battery { BatteryType = BatteryType.LiIon, HoursIdle = 15, HoursTalk = 9 },
                                new Display { NumberOfColors = 256, Size = 6.7 });

            var device2 = new Device("GalaxyS9", "Samsung", 699.99m, "Shin Wonho",
                                new Battery { BatteryType = BatteryType.NiMH, HoursIdle = 14, HoursTalk = 7 },
                                new Display { NumberOfColors = 256, Size = 7.1 });

            var device3 = new Device("Storm", "Blackberry", 689.99m, "Zhang Hans",
                                new Battery { BatteryType = BatteryType.NiCd, HoursIdle = 12, HoursTalk = 6 },
                                new Display { NumberOfColors = 256, Size = 6.9 });

            var device4 = new Device("MotoX4", "Motorola", 489.99m, "Lee Seungi",
                               new Battery { BatteryType = BatteryType.NiMH, HoursIdle = 14, HoursTalk = 6.5 },
                               new Display { NumberOfColors = 256, Size = 5.6 });

            var device5 = new Device("Banana", "Nokia");
              
            //create an array of devices
            var devices = new Device[] { device1, device2, device3, device4, device5 };

          foreach (var phone in devices)
            {
                Console.WriteLine(phone);
            }
        }
    }
            
}
