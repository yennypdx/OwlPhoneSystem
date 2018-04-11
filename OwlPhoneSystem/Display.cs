using System.Text;

namespace OwlPhoneSystem
{
    public class Display
    {
        public double Size { get; set; }
        public int NumberOfColors { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(" >> ");
            builder.Append("Size: " + Size);
            builder.Append(" >> ");
            builder.Append("Number of Colors: " + NumberOfColors);

            return builder.ToString();
        }
    }
}
