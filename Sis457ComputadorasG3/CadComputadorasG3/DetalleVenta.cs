
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CadComputadorasG3
{

using System;
    using System.Collections.Generic;
    
public partial class DetalleVenta
{

    public int id { get; set; }

    public int idVenta { get; set; }

    public int idArticulo { get; set; }

    public int cantidad { get; set; }

    public decimal precio { get; set; }

    public decimal descuento { get; set; }

    public string usuarioRegistro { get; set; }

    public System.DateTime fechaRegistro { get; set; }

    public short estado { get; set; }



    public virtual Articulo Articulo { get; set; }

    public virtual Venta Venta { get; set; }

}

}
