using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Ikuji
{
    class BabyContext : DbContext
    {
        public DbSet<Baby> Babys { get; set; }

        public DbSet<BabyInfomation> BabyInfomations { get; set; }

        public DbSet<BabyOmutu> BabyOmutus { get; set; }
    }
}
