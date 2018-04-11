using System;
using System.Text;

namespace OwlPhoneSystem
{
    public class Call
    {
        public DateTime CallStart { get; set; }
        public long DialedNumber { get; set; }
        public double DurationInMinutes { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(">> ");
            builder.Append("Call Start: " + CallStart);
            builder.Append(" >> ");
            builder.Append("Dialed Number: " + DialedNumber);
            builder.Append(" >> ");
            builder.Append("Duration in Minutes: " + DurationInMinutes);
         
            return builder.ToString();
        }
    }
}
