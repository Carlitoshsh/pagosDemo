namespace DemoPagos.Models;
using System;
using System.ComponentModel.DataAnnotations;
public class DatosPago
{
    [Required]
    public string? Correo { get; set; }

    [Required]
    public string? TipoDocumento { get; set; }

    [Required]
    public string? NumeroDocumento { get; set; }

    [Required]
    public string? Banco { get; set; }

    [Required]
    public string? TipoPersona { get; set; }

    [Required]
    public double Pago { get; set; }
}