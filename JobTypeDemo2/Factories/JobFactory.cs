using JobTypeDemo2.Enumerations;
using JobTypeDemo2.Interfaces;
using JobTypeDemo2.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTypeDemo2.Factories
{
    public class JobFactory : IJobFactory
    {
        public JobFactory()
        {

        }

        public IJob GetJob(string url, JobType jobType)
        {
            switch (jobType)
            {
                case JobType.Accunet:
                    return new AccunetJob(url);
                case JobType.ADEX:
                    return new AdexJob(url);
                default:
                    return null;
            }
        }
    }
}
