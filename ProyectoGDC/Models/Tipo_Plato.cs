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
    
    public partial class Tipo_Plato
    {
        public Tipo_Plato()
        {
            this.Plato = new HashSet<Plato>();
        }
    
        public int tipo_menu_id { get; set; }
        public string tipo_menu_nomnbre { get; set; }
    
        public virtual ICollection<Plato> Plato { get; set; }
    }
}