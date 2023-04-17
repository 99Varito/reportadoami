using reportadoami.Models.Model1;
using reportadoami.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

SELECT   OFNa, COUNT(*) AS TotalPacientes, MAX(Fecha_alta) AS Fecha_alta
FROM TU_CG_PAPELETADIA_CEM2
WHERE Fecha_alta >= DATEADD(DAY, -@dias, GETDATE())
GROUP BY OFNa
ORDER BY Fecha_alta DESC;
";

                data = db.Database.SqlQuery<PacientesPorOficinaViewModel>(query, dias).ToList();

            }

            return View(data);
        }

        public ActionResult Details(string oficina = "UMM", string periodo = "Dia")
        {
            List<DetailsviewModel> data;
            using (ANALISISEntities db = new ANALISISEntities())
            {
                string query;
                SqlParameter parameter = new SqlParameter("@oficina", oficina);

                switch (periodo)
                {
                    case "Semana":
                        query = @"
                    SELECT DATEADD(WEEK, DATEDIFF(WEEK, 0, FECHA_ALTA), 0) AS FechaSemana,
                           COUNT(*) AS TotalPacientes
                    FROM TU_CG_PAPELETADIA_CEM2
                    WHERE OFNA = @oficina
                    GROUP BY DATEADD(WEEK, DATEDIFF(WEEK, 0, FECHA_ALTA), 0)
                    ORDER BY DATEADD(WEEK, DATEDIFF(WEEK, 0, FECHA_ALTA), 0) ASC;
                ";
                        break;
                    case "Mes":
                        query = @"
                    SELECT DATEADD(MONTH, DATEDIFF(MONTH, 0, FECHA_ALTA), 0) AS FechaMes,
                           COUNT(*) AS TotalPacientes
                    FROM TU_CG_PAPELETADIA_CEM2
                    WHERE OFNA = @oficina
                    GROUP BY DATEADD(MONTH, DATEDIFF(MONTH, 0, FECHA_ALTA), 0)
                    ORDER BY DATEADD(MONTH, DATEDIFF(MONTH, 0, FECHA_ALTA), 0) ASC;
                ";
                        break;
                    default: // "Dia"
                        query = @"

SELECT CONVERT(VARCHAR(10), FECHA_ALTA, 23) AS Fecha,
       COUNT(*) AS TotalPacientes
FROM TU_CG_PAPELETADIA_CEM2
WHERE OFNA = @oficina
GROUP BY CONVERT(VARCHAR(10), FECHA_ALTA, 23)
ORDER BY CONVERT(VARCHAR(10), FECHA_ALTA, 23) ASC;


";

                        break;




                }

                data = db.Database.SqlQuery<DetailsviewModel>(query, parameter).ToList();
            }

            ViewBag.Oficina = oficina;
            ViewBag.Periodo = periodo;

            return View(data);
        }



    }
}
