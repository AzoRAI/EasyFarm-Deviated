using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyFarm.Classes
{
    public class VanaTime
    {

        public double Second { get; set; }
        public double Minute { get; set; }
        public double Hour { get; set; }

        public double DoubleValue
        {
            get
            {
                return Convert.ToDouble($"{Hour}.{Minute}");
            }
        }
      

        public VanaTime()
        {
            TimeSpan tmp = DateTime.Now.ToUniversalTime().Subtract(new DateTime(2002, 6, 23, 15, 0, 0, 0));
            Int64 tt = Convert.ToInt64(tmp.TotalSeconds * 25);

            var sc = tt % 60;
            var mn = Convert.ToInt64(tt / 60) % 60;
            var hr = Convert.ToInt64(tt / (60 * 60)) % 24;
            var dy = Convert.ToInt64(tt / (60 * 60 * 24)) % 30 + 1;
            var mo = Convert.ToInt64(tt / (60 * 60 * 24 * 30)) % 12 + 2;
            var yr = Convert.ToInt64(tt / (60 * 60 * 24 * 30 * 12)) + 898;

            Second = Convert.ToDouble(sc);
            Minute = Convert.ToDouble(mn);
            Hour = Convert.ToDouble(hr);
        }

        public static VanaTime Now
        {
            get { return new VanaTime(); }
        }

    }
}
