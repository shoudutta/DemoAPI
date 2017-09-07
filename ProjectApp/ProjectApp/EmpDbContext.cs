using ProjectApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectApp
{
    public class EmpDbContext : DbContext
    {
        public EmpDbContext() : base("name=EmpConnString") { }
        public DbSet<EmpModel> Employees { get; set; }
    }
}