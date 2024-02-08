using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
   public class DbConnect:DbContext
    {
        public DbConnect(DbContextOptions<DbConnect>options) : base(options)
        {

        }
        public DbSet<Doctor> DoctorTableList { get; set; }
    }
}
