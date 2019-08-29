using Microsoft.ML;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GithubLabelMl.Models
{
    public class Gitpred
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string Area { get; set; }

     
    }
}
