using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnluCo.NetBootcamp.Odev3.Models;

namespace UnluCo.NetBootcamp.Odev3.DBOperations
{
    public class PatikaDevDBContext : DbContext
    {
        public PatikaDevDBContext(DbContextOptions<PatikaDevDBContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Educator> Educators{ get; set; }
        public DbSet<Assistant> Assistants{ get; set; }
    }
}
