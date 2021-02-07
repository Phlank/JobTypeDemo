using JobTypeDemo2.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTypeDemo2.ViewModels.Home
{
    public class SubmitViewModel
    {
        public string Url { get; set; }
        public JobType JobType { get; set; }
    }
}
