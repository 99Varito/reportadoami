using reportadoami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reportadoami.Models.ViewModels;
using reportadoami.Models.Model1;
using System.Collections;
using System.Web.Services.Description;
using System.Data.SqlClient;

namespace reportadoami.Controllers
{
    public class TU_CG_PAPELETADIA_CEM2022Controller : Controller
    {
        public ActionResult Index(string ofna, DateTime? fechaSeleccionada, bool mostrarExamenesCovid = false)
        {

            return IndexSinCovid(ofna,fechaSeleccionada);
        }

        public ActionResult IndexConCovid(string ofna, DateTime? fechaSeleccionada, bool mostrarExamenesCovid = true)
        {
            List<PapeletadiariaCemViewModel> lst;
            using (ANALISISEntities db = new ANALISISEntities())
            {
                var query = @"
            DECLARE @ofna varchar(50) = @p_ofna;
DECLARE @fechaSeleccionada DATE = COALESCE(@p_fechaSeleccionada, DATEADD(day, -1, GETDATE()));
DECLARE @mostrarExamenesCovid BIT = @p_mostrarExamenesCovid;

SELECT Folio,
    Nombre_paciente, 
    MAX(CONVERT(VARCHAR(10), Fecha_alta, 120)) AS Fecha_alta, 
    MAX(Perf_descripcion) AS Perf_descripcion, 
    MAX(comentarios) AS comentarios, 
    SUM(Cantidad) AS Cantidad, 
    SUM(Costo) AS Costo, 
    MAX(OFNa) AS OFNa, 
    MAX(servicio) AS servicio,
    STRING_AGG(NOMBRE_EXAMEN, ', ') AS NOMBRE_EXAMEN
FROM ANALISIS.dbo.TU_CG_PAPELETADIA_CEM2
WHERE 
    (OFNa = @ofna OR @ofna IS NULL)
    AND 
    (CONVERT(date, Fecha_alta, 120) = @fechaSeleccionada OR @fechaSeleccionada IS NULL)
AND (@mostrarExamenesCovid = 1 AND (NOMBRE_EXAMEN = 'PRUEBA PCR COVID' OR NOMBRE_EXAMEN = 'PRUEBA DE ANTIGENO COVID'))
GROUP BY Folio, Nombre_paciente, OFNa
ORDER BY MAX(Fecha_alta) DESC


        ";

                var ofnaParam = new SqlParameter("@p_ofna", string.IsNullOrEmpty(ofna) ? (object)DBNull.Value : ofna);
                var fechaSeleccionadaParam = new SqlParameter("@p_fechaSeleccionada", fechaSeleccionada.HasValue ? (object)fechaSeleccionada.Value : DBNull.Value);
                var mostrarExamenesCovidParam = new SqlParameter("@p_mostrarExamenesCovid", mostrarExamenesCovid);
                lst = db.Database.SqlQuery<PapeletadiariaCemViewModel>(query, ofnaParam, fechaSeleccionadaParam,mostrarExamenesCovidParam).ToList();
            }

            return View("Index", lst);
        }

        public ActionResult IndexSinCovid(string ofna, DateTime? fechaSeleccionada, bool mostrarExamenesCovid = false)
        {
            List<PapeletadiariaCemViewModel> lst;
            using (ANALISISEntities db = new ANALISISEntities())
            {
                var query = @"
               DECLARE @ofna varchar(50) = @p_ofna;
DECLARE @fechaSeleccionada DATE = COALESCE(@p_fechaSeleccionada, DATEADD(day, -1, GETDATE()));
DECLARE @mostrarExamenesCovid BIT = @p_mostrarExamenesCovid;

SELECT Folio,
    Nombre_paciente, 
    MAX(CONVERT(VARCHAR(10), Fecha_alta, 120)) AS Fecha_alta, 
    MAX(Perf_descripcion) AS Perf_descripcion, 
    MAX(comentarios) AS comentarios, 
    SUM(Cantidad) AS Cantidad, 
    SUM(Costo) AS Costo, 
    MAX(OFNa) AS OFNa, 
    MAX(servicio) AS servicio,
    STRING_AGG(NOMBRE_EXAMEN, ', ') AS NOMBRE_EXAMEN
FROM ANALISIS.dbo.TU_CG_PAPELETADIA_CEM2
WHERE 
    (OFNa = @ofna OR @ofna IS NULL)
    AND 
    (CONVERT(date, Fecha_alta, 120) = @fechaSeleccionada OR @fechaSeleccionada IS NULL)
AND (@mostrarExamenesCovid = 0 AND (NOMBRE_EXAMEN = 'PRUEBA PCR COVID' OR NOMBRE_EXAMEN = 'PRUEBA DE ANTIGENO COVID'))
GROUP BY Folio, Nombre_paciente, OFNa
ORDER BY MAX(Fecha_alta) DESC

        ";

                var ofnaParam = new SqlParameter("@p_ofna", string.IsNullOrEmpty(ofna) ? (object)DBNull.Value : ofna);
                var fechaSeleccionadaParam = new SqlParameter("@p_fechaSeleccionada", fechaSeleccionada.HasValue ? (object)fechaSeleccionada.Value : DBNull.Value);
                var mostrarExamenesCovidParam = new SqlParameter("@p_mostrarExamenesCovid", mostrarExamenesCovid);
                lst = db.Database.SqlQuery<PapeletadiariaCemViewModel>(query, ofnaParam, fechaSeleccionadaParam,mostrarExamenesCovidParam).ToList();
            }

            return View("Index", lst);
        }





       



    

    }
}