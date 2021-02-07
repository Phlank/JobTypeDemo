using JobTypeDemo2.Enumerations;
using JobTypeDemo2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTypeDemo2.Jobs
{
    public class AccunetJob : IJob
    {
        private readonly string _url;

        public AccunetJob(string url)
        {
            _url = url;
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
