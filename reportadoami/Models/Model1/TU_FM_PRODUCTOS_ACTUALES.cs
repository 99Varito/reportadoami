//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace reportadoami.Models.Model1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TU_FM_PRODUCTOS_ACTUALES
    {
        public int ID { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public string PARTE { get; set; }
        public string DESCRIPCION { get; set; }
        public string CATEGORIA { get; set; }
        public string DESCATEGORIA { get; set; }
        public Nullable<float> PRECIOUNITARIOORIGEN { get; set; }
        public Nullable<float> PRECIO { get; set; }
        public Nullable<int> UNIDADEMPAQUE { get; set; }
        public Nullable<int> MINIMOS { get; set; }
        public Nullable<int> MAXIMOS { get; set; }
        public Nullable<int> TE { get; set; }
        public Nullable<int> MONEDA { get; set; }
        public string OBSERVACIONES { get; set; }
        public Nullable<short> ALTA_SICK { get; set; }
        public Nullable<System.DateTime> FECHACREACION { get; set; }
        public Nullable<short> ACTIVO { get; set; }
        public Nullable<int> marcaId { get; set; }
        public Nullable<short> AdminPaq { get; set; }
        public string comentario { get; set; }
        public Nullable<int> Embalaje { get; set; }
        public string Familia { get; set; }
        public Nullable<int> ActMensaje { get; set; }
        public string Mensaje { get; set; }
        public Nullable<int> tipoProducto { get; set; }
        public Nullable<int> AplicaRango { get; set; }
    }
}
