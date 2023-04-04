using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public partial class BeneficiaryDbContext : DbContext
    {
        public BeneficiaryDbContext()
        {
        }

        public BeneficiaryDbContext(DbContextOptions<BeneficiaryDbContext> options)
            : base(options)
        {
        }
    }
}
