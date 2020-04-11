using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MedicalManager.Models
{
    public class MedicalManagerDBContext: DbContext
    {
        public MedicalManagerDBContext(DbContextOptions<MedicalManagerDBContext> options): base(options)
        {

        }
        public DbSet<Medication> Medications { get; set; }
    }
}
