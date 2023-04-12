using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportadoami.Models.ViewModels
{
   public class PapeletadiariaCemViewModel
{
    public int? Folio { get; set; }
    public string Nombre_paciente { get; set; }
    public String Fecha_alta { get; set;
        }
    public string Perf_descripcion { get; set; }
    public string comentarios { get; set; }
    public int? Cantidad { get; set; }
    public decimal? Costo { get; set; }
    public string OFNa { get; set; }
    public string servicio { get; set; }
    public string NOMBRE_EXAMEN { get; set; }
    public DateTime? FechaSeleccionada { get; set; } 
 
}

}