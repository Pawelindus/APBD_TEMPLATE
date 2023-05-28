using System.ComponentModel.DataAnnotations;

namespace APBD_6.Models;

public class Patient
{
    private List<Prescription> Prescriptions = new();

    [Key] public int IdPatient { get; set; }

    [MaxLength(100)] public string FirstName { get; set; } = string.Empty;

    [MaxLength(100)] public string LastName { get; set; } = string.Empty;

    public DateTime Birthdate { get; set; }
}