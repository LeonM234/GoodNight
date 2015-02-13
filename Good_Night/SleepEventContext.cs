using Good_Night.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Good_Night
{
    public class SleepEventContext: DbContext
    {
        public DbSet<SleepEvent> SleepEvents { get; set; }
    }
}
