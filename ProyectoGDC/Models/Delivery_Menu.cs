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
    
    public partial class Delivery_Menu
    {
        public int menu_id { get; set; }
        public int delivery_id { get; set; }
        public int cantidad { get; set; }
        public decimal subTotal { get; set; }
        public int estado { get; set; }
    
        public virtual Delivery Delivery { get; set; }
        public virtual Plato Plato { get; set; }
    }
}
