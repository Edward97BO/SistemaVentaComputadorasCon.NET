
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
    
public partial class Usuario
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Usuario()
    {

        this.Ingreso = new HashSet<Ingreso>();

        this.Venta = new HashSet<Venta>();

    }


    public int id { get; set; }

    public int idRol { get; set; }

    public string nombre { get; set; }

    public string tipoDocumento { get; set; }

    public string numDocumento { get; set; }

    public string direccion { get; set; }

    public string telefono { get; set; }

    public string email { get; set; }

    public string usuarioRegistro { get; set; }

    public System.DateTime fechaRegistro { get; set; }

    public short estado { get; set; }

    public string clave { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Ingreso> Ingreso { get; set; }

    public virtual Rol Rol { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Venta> Venta { get; set; }

}

}
