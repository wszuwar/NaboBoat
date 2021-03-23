using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaboBoat.DataAcces
{
    class HarborStorageContextFactory : IDesignTimeDbContextFactory<HarborStorageContext>
    {
        public HarborStorageContext CreateDbContext(string[] args)
        { 
        var optionsBuilder = new DbContextOptionsBuilder<HarborStorageContext>();
            optionsBuilder.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=HarborStorage;Integrated Security=True");
            return new HarborStorageContext(optionsBuilder.Options);
    }
    }
}
