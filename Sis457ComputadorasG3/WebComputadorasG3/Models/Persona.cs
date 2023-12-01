using System;
using System.Collections.Generic;

namespace WebComputadorasG3.Models;

public partial class Persona
{
    public int Id { get; set; }

    public string TipoPersona { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string TipoDocumento { get; set; } = null!;

    public string NumDocumento { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual ICollection<Ingreso> Ingresos { get; set; } = new List<Ingreso>();

    public virtual ICollection<Ventum> Venta { get; set; } = new List<Ventum>();
}
