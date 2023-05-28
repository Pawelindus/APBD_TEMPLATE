using System.ComponentModel.DataAnnotations;

namespace APBD_6.Models;

public class Doctor
{
    private List<Prescription> Prescriptions = new();

    [Key] public int IdDoctor { get; set; }

    [MaxLength(100)] public string FirstName { get; set; } = string.Empty;

    [MaxLength(100)] public string LastName { get; set; } = string.Empty;

    [MaxLength(100)] public string Email { get; set; } = string.Empty;
}