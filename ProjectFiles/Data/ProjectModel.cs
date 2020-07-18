using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Data
{
    public class ProjectModel
    {
        public string Icon {get; set;}
        public string[] Tags {get; set;}
        public string Description {get; set;}
        public string DescPl {get; set;}

        public string GitHubLink {get; set;}
    }
}
