//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoGDC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Documento
    {
        public Tipo_Documento()
        {
            this.Usuario_Web = new HashSet<Usuario_Web>();
        }
    
        public int tipo_documento_id { get; set; }
        public string tipo_documento_nombre { get; set; }
    
        public virtual ICollection<Usuario_Web> Usuario_Web { get; set; }
    }
}
