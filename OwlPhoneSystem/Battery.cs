using System.Text;

namespace OwlPhoneSystem
{
    public enum BatteryType { LiIon, NiMH, NiCd };
    public class Battery
    {
        public string Model { get; set; }
        public double HoursIdle { get; set; }
        public double HoursTalk { get; set; }
        public BatteryType BatteryType { get; set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            //builder.Append("Model: " + Model); --- intented input data is vague
            builder.Append(" >> ");
            builder.Append("Hours Idle: " + HoursIdle);
            builder.Append(" >> ");
            builder.Append("Hours Talk: " + HoursTalk);
            builder.Append(" >> ");
            builder.Append("Battery Type: " + BatteryType);
            builder.Append(" >> ");

            return builder.ToString();
        }
    }
}
