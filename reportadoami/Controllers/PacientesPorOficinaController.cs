using reportadoami.Models.Model1;
using reportadoami.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace reportadoami.Controllers
{
    public class PacientesPorOficinaController : Controller
    {
        // GET: PacientesPorOficina

        public ActionResult IndePacientesPorOficina(int dias = 7)
        {
            List<PacientesPorOficinaViewModel> data;
            using (ANALISISEntities db = new ANALISISEntities())
            {
                DateTime fecha_hasta = DateTime.Now;
                DateTime fecha_desde = fecha_hasta.AddDays(-dias);
                string query = @"
DECLARE @dias INT = " + dias + @"

SELECT TOP 50 OFNa, COUNT(*) AS TotalPacientes, MAX(Fecha_alta) AS Fecha_alta
FROM TU_CG_PAPELETADIA_CEM2
WHERE Fecha_alta >= DATEADD(DAY, -@dias, GETDATE())
GROUP BY OFNa
ORDER BY Fecha_alta DESC;
";

                data = db.Database.SqlQuery<PacientesPorOficinaViewModel>(query, dias).ToList();




            }

            return View(data);
        }





    }


}