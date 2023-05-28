using APBD_6.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_6.Context;

public class NAZWA_Context : DbContext
{
    public NAZWA_Context(DbContextOptions options) : base(options)
    {
    }

    protected NAZWA_Context()
    {
    }

    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Medicament> Medicaments { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Prescription> Prescriptions { get; set; }
    public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasData(new List<Doctor>
            {
                new()
                {
                    IdDoctor = 1,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Email = "milyDoktor@wp.pl"
                },
                new()
                {
                    IdDoctor = 2,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Email = "milyDoktor@wp.pl"
                },
                new()
                {
                    IdDoctor = 3,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Email = "milyDoktor@wp.pl"
                }
            });
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity.HasData(new List<Patient>
            {
                new()
                {
                    IdPatient = 1,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Birthdate = DateTime.Now
                },
                new()
                {
                    IdPatient = 2,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Birthdate = DateTime.Now
                },
                new()
                {
                    IdPatient = 3,
                    FirstName = "Janusz",
                    LastName = "Kowalski",
                    Birthdate = DateTime.Parse("23-03-2022")
                }
            });
        });

        modelBuilder.Entity<Prescription>(entity =>
        {
            entity.HasData(new List<Prescription>
            {
                new()
                {
                    IdPrescription = 1,
                    Date = DateTime.Now,
                    DueDate = DateTime.Now,
                    IdDoctor = 1,
                    IdPatient = 1,
                },
                new()
                {
                    IdPrescription = 2,
                    Date = DateTime.Now,
                    DueDate = DateTime.Now,
                    IdDoctor = 1,
                    IdPatient = 2,
                },
                new()
                {
                    IdPrescription = 3,
                    Date = DateTime.Now,
                    DueDate = DateTime.Now,
                    IdDoctor = 2,
                    IdPatient = 1,
                }
            });
        });

        modelBuilder.Entity<Medicament>(entity =>
        {
            entity.HasData(new List<Medicament>
            {
                new()
                {
                    IdMedicament = 1,
                    Name = "Apap",
                    Description = "Na ból glowy",
                    Type = "Przeciwbólowy"
                },
                new()
                {
                    IdMedicament = 2,
                    Name = "Ibuprofen",
                    Description = "Na ból glowy",
                    Type = "Przeciwbólowy"
                },
                new()
                {
                    IdMedicament = 3,
                    Name = "Rutinoscorbin",
                    Description = "Na odporność",
                    Type = "Odpornościowy"
                }
            });
        });

        modelBuilder.Entity<Prescription_Medicament>(entity =>
        {
            entity.HasData(new List<Prescription_Medicament>
            {
                new()
                {
                    IdMedicament = 1,
                    IdPrescription = 1,
                    Dose = 2,
                    Details = "brak"
                },
                new()
                {
                    IdMedicament = 2,
                    IdPrescription = 1,
                    Dose = 3,
                    Details = "brak"
                },
                new()
                {
                    IdMedicament = 1,
                    IdPrescription = 2,
                    Dose = 6,
                    Details = "Rano i wieczorem"
                }
            });
        });
    }
}