using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportadoami.Models.ViewModels
{
    public class PapeletadiariaCemViewModel
    {    
        public int Folio { get; set; }
        public String FECHA_ALTA { get; set; }
        public String NOMBRE_PACIENTE { get; set; }
        public String PERF_DESCRIPCION { get; set; }
        public String Comentarios { get; set; }
        public String NOMBRE_EXAMEN { get; set; }

    }
}