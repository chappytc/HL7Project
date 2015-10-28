using System.Data.Entity;
using HL7Model;

namespace HL7Data
{
    internal class HL7DbContext : DbContext
    {
        public HL7DbContext()
            : base("Name=HL7DbContext")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<PersonName> PersonNames { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<PatientVisit> PatientVisits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Diagnosis)
                .WithOptional()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Patient>()
                .HasMany(p => p.Names)
                .WithOptional()
                .WillCascadeOnDelete(true);

            modelBuilder.Entity<Patient>()
                .HasMany(p => p.PatientVisit)
                .WithOptional()
                .WillCascadeOnDelete(true);
        }
    }
}
