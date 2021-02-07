using JobTypeDemo2.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTypeDemo2.Interfaces
{
    public interface IJobFactory
    {
        public IJob GetJob(string url, JobType jobType);
    }
}
