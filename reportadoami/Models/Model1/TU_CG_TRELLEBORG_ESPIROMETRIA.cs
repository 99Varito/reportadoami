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
    
    public partial class TU_CG_TRELLEBORG_ESPIROMETRIA
    {
        public int ESP_ID_PERSONA { get; set; }
        public Nullable<decimal> ESP_REP_FVC { get; set; }
        public Nullable<decimal> ESP_REP_FVE1 { get; set; }
        public string EMPRESA { get; set; }
        public string NOMBRE_PACIENTE { get; set; }
        public string DIAG { get; set; }
        public string COMENT { get; set; }
        public string ESP_RECOMENDACIONES { get; set; }
        public Nullable<int> ESP_ID_PRUEBAS_ACEPTABLES { get; set; }
    }
}
