using System;
using System.Collections.Generic;

namespace WebComputadorasG3.Models;

public partial class Ventum
{
    public int Id { get; set; }

    public int IdCliente { get; set; }

    public int IdUsuario { get; set; }

    public string TipoComprobante { get; set; } = null!;

    public string NumComprobante { get; set; } = null!;

    public decimal Total { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual ICollection<DetalleVentum> DetalleVenta { get; set; } = new List<DetalleVentum>();

    public virtual Persona IdClienteNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
