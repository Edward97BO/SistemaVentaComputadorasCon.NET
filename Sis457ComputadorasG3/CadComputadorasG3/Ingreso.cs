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
    
    public partial class Ingreso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingreso()
        {
            this.DetalleIngreso = new HashSet<DetalleIngreso>();
        }
    
        public int id { get; set; }
        public int idProveedor { get; set; }
        public int idUsuario { get; set; }
        public string tipoComprobante { get; set; }
        public string numComprobante { get; set; }
        public decimal total { get; set; }
        public string usuarioRegistro { get; set; }
        public System.DateTime fechaRegistro { get; set; }
        public short estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleIngreso> DetalleIngreso { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}