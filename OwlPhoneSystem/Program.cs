using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlPhoneSystem
{
    internal class Program //internal: only instantiable inside this namespace only
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Device Information: ");
            DeviceTest.DeviseTests();
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Call History and Total Cost Calculated: ");
            DeviceCallHistoryTest.DeviceCallHistoryTests();

            Console.ReadKey();
        }
    }
}
