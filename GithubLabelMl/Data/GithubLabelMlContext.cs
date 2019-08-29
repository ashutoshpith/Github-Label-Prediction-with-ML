using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GithubLabelMl.Models
{
    public class GithubLabelMlContext : DbContext
    {
        public GithubLabelMlContext (DbContextOptions<GithubLabelMlContext> options)
            : base(options)
        {
        }

        public DbSet<GithubLabelMl.Models.Gitpred> Gitpred { get; set; }
    }
}
