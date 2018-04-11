using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwlPhoneSystem
{
    public class Device
    {
        public Device(string inModel, string inManufacturer, decimal inPrice = default(decimal), 
            string inOwner = default(string), Battery inBattery = null, Display inDisplay = null)
        {
            Model = inModel;
            Manufacturer = inManufacturer;
            Price = inPrice;
            Owner = inOwner;
            Battery = inBattery;
            Display = inDisplay;

            CallHistory = new List<Call>();
        }

        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }
        public IList<Call> CallHistory { get; set; }
        public void AddCall(Call call)
        {
            CallHistory.Add(call);  //Add = push_back in cpp
        }

        public void RemoveCall(Call call)
        {
            CallHistory.Remove(call); //Remove = pop_back in cpp
        }

        public void ClearCallHistory()
        {
            CallHistory.Clear();
        }

        public decimal TotalCostCalculator(decimal costPerMinute)
        {
            var totalCost = 0.0m;

            foreach (var call in CallHistory)
            {
                totalCost += (Convert.ToDecimal(call.DurationInMinutes) * costPerMinute);
            }
            
            return totalCost;
        }
        public override string ToString()
        {
            var builder = new StringBuilder();
            //builder.Append("Model: " + Model); --- intented input data is vague
            builder.Append(">> ");
            builder.Append("Manufacturer: " + Manufacturer);
            builder.Append(" >> ");
            builder.Append("Price: " + Price.ToString("C"));
            builder.Append(" >> ");
            builder.Append("Owner: " + Owner);
            builder.Append(" >> ");
            builder.Append("Battery: " + Battery ?? "No information available");
            builder.Append(" >> ");
            builder.Append("Display: " + Display ?? "No information available");

            return builder.ToString();
        }
    }
}
