using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Practice.Models.ViewModels
{
    public class TenRandomJokesVM
    {
        public IEnumerable<int> Number { get; set; }
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }

    }

}
