//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEUCrtProyectoLuis
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    
    public partial class Carrito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Carrito()
        {
            this.CuerpoFactura = new HashSet<CuerpoFactura>();
            this.ProductoEnCarrito = new HashSet<ProductoEnCarrito>();
        }
    
        public int car_id { get; set; }
        public int cln_id { get; set; }
        public string car_tipo { get; set; }
        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<CuerpoFactura> CuerpoFactura { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [JsonIgnore]
        public virtual ICollection<ProductoEnCarrito> ProductoEnCarrito { get; set; }
    }
}
