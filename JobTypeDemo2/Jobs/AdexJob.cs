using JobTypeDemo2.Enumerations;
using JobTypeDemo2.Interfaces;
using JobTypeDemo2.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace JobTypeDemo2.Jobs
{
    public class AdexJob : IJob
    {
        private readonly string _url;

        public AdexJob(string url)
        {
            _url = url;
        }

        public void Run()
        {
            var client = new HttpClient();
            var result = client.GetAsync(_url).Result;
            if (result.IsSuccessStatusCode)
            {
                Console.WriteLine("Putting info from job into database: " + result.Content.ReadAsStringAsync().Result);
                var content = "Putting info from job into database: " + result.Content.ReadAsStringAsync().Result;
                var model = JsonConvert.DeserializeObject<AdexHangfireResponse>(result.Content.ReadAsStringAsync().Result);
            }
        }
    }
}
