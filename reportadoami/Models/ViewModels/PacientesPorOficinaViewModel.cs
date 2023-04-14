using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace reportadoami.Models.ViewModels
{
    public class PacientesPorOficinaViewModel
    {
        public string OFNa { get; set; }
        public int TotalPacientes { get; set; }
        public int mes { get; set; }
        public int Semana { get; set; }
        public DateTime fecha  { get; set; }

    }
}