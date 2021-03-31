using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Practice.Models.APIModels
{
    public class TenRandomJokesResponse
    {
        public Class1[] Property1 { get; set; }
    }
    public class Class1
    {
        public int id { get; set; }
        public string type { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
    }

}
