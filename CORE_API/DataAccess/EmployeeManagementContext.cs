using CORE_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CORE_API.DataAccess
{
    public class EmployeeManagementContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLExpress;Initial Catalog=EmployeeManagement;Integrated Security=True");


            
        }
        public DbSet<Calisan> Calisanlar { get; set; }
    }
}
