﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_6.Models;

[PrimaryKey(nameof(IdMedicament), nameof(IdPrescription))]
public class Prescription_Medicament
{
    public int IdMedicament { get; set; }
    public int IdPrescription { get; set; }
    public int? Dose { get; set; }

    [MaxLength(100)] public string Details { get; set; } = string.Empty;

    [ForeignKey(nameof(IdMedicament))] public virtual Medicament Medicament { get; set; } = null!;

    [ForeignKey(nameof(IdPrescription))] public virtual Prescription Prescription { get; set; } = null!;
}