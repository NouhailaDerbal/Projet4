using EtudiantService.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtudiantService.Models
{
    public class ModelContext:DbContext
    {
        public ModelContext(DbContextOptions<ModelContext> options) : base(options)
        {
        }
        public DbSet<Etudiant> Etudiants { get; set; }
       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0DHF9G0\\SQLEXPRESS;Database=UseMicroservices;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        */
    }

}
