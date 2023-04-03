using reportadoami.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using reportadoami.Models.ViewModels;
using reportadoami.Models.Model1;

namespace reportadoami.Controllers
{
    public class TU_CG_PAPELETADIA_CEM2022Controller : Controller
    {
        // GET: TU_CG_PAPELETADIA_CEM2022
        public ActionResult Index()
        {
            List<PapeletadiariaCemViewModel> lst;
            using (ANALISISEntities db = new ANALISISEntities())
            {
                lst = db.Database.SqlQuery<PapeletadiariaCemViewModel>(@"
            SELECT Fecha_alta, Nombre_paciente, Perf_descripcion, comentarios, Cantidad, Costo, OFNa, servicio, 
                [Audiometria], [BiometriaHematica], [Campimetria], [Consulta], [CoproParasitoscopico3], [EGO], [Espirometria], 
                [Ex_Medico], [ExudadoFaringeo], [GrupoYRH], [PESP], [Pie_Orina], [QS6], [RxColumnaAPyLat], [RxTorax], [Tox3], 
                [Tox5], [Tox6], [ReaccionesFebriles], [CoproParasitoscopico1], [GlucosaCapilar], [VDRL], [RxCervicalesAPyLat], 
                [RxToraxAP], [PerfilLipidico], [RxAPyLatCodoDerecho], [RxPierna], [PruebaDeAnticuerposIgMIgGCOVID], [TeleDeToraxRx], 
                [PruebaDeAntigenoCOVID], [RxColumnaLumbosacraAPyLat], [RxLumbarAPyLat]
            FROM (
                SELECT Fecha_alta, Nombre_paciente, Perf_descripcion, comentarios, Cantidad, Costo, OFNa, servicio, Nombre_examen
                FROM ANALISIS.dbo.TU_CG_PAPELETADIA_CEM2022
                WHERE EX_REALIZADO = 1
            ) AS t
            PIVOT (
                COUNT(Nombre_examen)
                FOR Nombre_examen IN (
                    [Audiometria], [BiometriaHematica], [Campimetria], [Consulta], [CoproParasitoscopico3], [EGO], [Espirometria], 
                    [Ex_Medico], [ExudadoFaringeo], [GrupoYRH], [PESP], [Pie_Orina], [QS6], [RxColumnaAPyLat], [RxTorax], [Tox3], 
                    [Tox5], [Tox6], [ReaccionesFebriles], [CoproParasitoscopico1], [GlucosaCapilar], [VDRL], [RxCervicalesAPyLat], 
                    [RxToraxAP], [PerfilLipidico], [RxAPyLatCodoDerecho], [RxPierna], [PruebaDeAnticuerposIgMIgGCOVID], [TeleDeToraxRx], 
                    [PruebaDeAntigenoCOVID], [RxColumnaLumbosacraAPyLat], [RxLumbarAPyLat]
                )
            ) AS p
            ORDER BY Fecha_alta DESC").ToList();
            }
            return View(lst);
        }

    }
}