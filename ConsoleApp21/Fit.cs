using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Fit
    {
        public int dates { get; set; }
        public int code { get; set; }
        public int month { get; set; }
        public int duration { get; set; }

        public Fit(int code, int dates, int month, int duration) 
        {
            this.dates = dates;
            this.code = code;
            this.month = month;
            this.duration = duration;
        }

    }
}
