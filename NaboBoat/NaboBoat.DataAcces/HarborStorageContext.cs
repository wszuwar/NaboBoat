using Microsoft.EntityFrameworkCore;
using NaboBoat.DataAcces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaboBoat.DataAcces
{
    class HarborStorageContext : DbContext

    {
        public HarborStorageContext(DbContextOptions<HarborStorageContext> opt) : base(opt)
        {

        }
        public DbSet<Boat> Boats { get; set; }
    }
}
