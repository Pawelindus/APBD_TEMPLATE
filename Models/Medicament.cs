using System.ComponentModel.DataAnnotations;

namespace APBD_6.Models;

public class Medicament
{
    private List<Prescription_Medicament> Prescriptions = new();

    [Key] public int IdMedicament { get; set; }

    [MaxLength(100)] public string Name { get; set; } = string.Empty;

    [MaxLength(100)] public string Description { get; set; } = string.Empty;

    [MaxLength(100)] public string Type { get; set; } = string.Empty;
}