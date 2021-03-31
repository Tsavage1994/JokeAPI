using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Practice.Models.ViewModels
{
    public class RandomJokeVM
    {
        public string Type { get; set; }
        public string Setup { get; set; }
        public string Punchline { get; set; }
    }
}
