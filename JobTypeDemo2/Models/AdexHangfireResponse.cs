using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTypeDemo2.Models
{
    public class AdexHangfireResponse
    {
        public DateTime DateTime { get; set; }
        public int Enqueued { get; set; }
        public int Scheduled { get; set; }
        public int Processing { get; set; }
        public int Succeeded { get; set; }
        public int Failed { get; set; }
        public int Deleted { get; set; }
        public int Awaiting { get; set; }
    }
}
