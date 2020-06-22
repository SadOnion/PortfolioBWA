using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class TechnologyModel
    {
        public string Icon {get; set;}
        public string Name {get; set;}
        public string TechName => Name.ToUpper();
        public byte Table {get; set;}
    }
}
