using System;
using System.Collections.Generic;

namespace WebComputadorasG3.Models;

public partial class DetalleIngreso
{
    public int Id { get; set; }

    public int IdIngreso { get; set; }

    public int IdArticulo { get; set; }

    public int Cantidad { get; set; }

    public decimal Precio { get; set; }

    public string UsuarioRegistro { get; set; } = null!;

    public DateTime FechaRegistro { get; set; }

    public short Estado { get; set; }

    public virtual Articulo IdArticuloNavigation { get; set; } = null!;

    public virtual Ingreso IdIngresoNavigation { get; set; } = null!;
}
