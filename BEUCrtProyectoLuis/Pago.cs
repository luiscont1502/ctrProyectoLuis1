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
    
    public partial class Pago
    {
        public int pgo_id { get; set; }
        public int cln_id { get; set; }
        public string pgo_nom { get; set; }
        public string pgo_ntg { get; set; }
        public System.DateTime pgo_fven { get; set; }
        public Nullable<int> pgo_cseg { get; set; }
        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }
    }
}
