﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ANALISISEntities : DbContext
    {
        public ANALISISEntities()
            : base("name=ANALISISEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<clientes_asesor> clientes_asesor { get; set; }
        public virtual DbSet<TU_CG_CIFRAS_AMIHIST> TU_CG_CIFRAS_AMIHIST { get; set; }
        public virtual DbSet<TU_CG_CLIENTE_ASESOR> TU_CG_CLIENTE_ASESOR { get; set; }
        public virtual DbSet<TU_CG_CLIENTES_CONTPAQ> TU_CG_CLIENTES_CONTPAQ { get; set; }
        public virtual DbSet<TU_CG_CLIENTES_CONTPAQDOM> TU_CG_CLIENTES_CONTPAQDOM { get; set; }
        public virtual DbSet<TU_CG_CONCENTRADO_LABORATORIO> TU_CG_CONCENTRADO_LABORATORIO { get; set; }
        public virtual DbSet<TU_CG_CONTPASAT> TU_CG_CONTPASAT { get; set; }
        public virtual DbSet<TU_CG_EMPRESAS> TU_CG_EMPRESAS { get; set; }
        public virtual DbSet<TU_CG_FACTURAS_ORIGEN> TU_CG_FACTURAS_ORIGEN { get; set; }
        public virtual DbSet<TU_CG_FOLIOSFER> TU_CG_FOLIOSFER { get; set; }
        public virtual DbSet<TU_CG_PAPELETA_DESVIO> TU_CG_PAPELETA_DESVIO { get; set; }
        public virtual DbSet<TU_CG_PAPELETA_DESVIO_ONLINE> TU_CG_PAPELETA_DESVIO_ONLINE { get; set; }
        public virtual DbSet<TU_CG_PAPELETADIA> TU_CG_PAPELETADIA { get; set; }
        public virtual DbSet<TU_CG_PAPELETADIA_CEM> TU_CG_PAPELETADIA_CEM { get; set; }
        public virtual DbSet<TU_CG_PAPELETADIA_CEM2> TU_CG_PAPELETADIA_CEM2 { get; set; }
        public virtual DbSet<TU_CG_PAPELETADIA_CEM2022> TU_CG_PAPELETADIA_CEM2022 { get; set; }
        public virtual DbSet<TU_CG_PAPELETADIA_CEM3> TU_CG_PAPELETADIA_CEM3 { get; set; }
        public virtual DbSet<TU_CG_PAPELETAS_ORDEN> TU_CG_PAPELETAS_ORDEN { get; set; }
        public virtual DbSet<TU_CG_PED_KDM2KDM1> TU_CG_PED_KDM2KDM1 { get; set; }
        public virtual DbSet<TU_CG_PEDIDOS_aMI> TU_CG_PEDIDOS_aMI { get; set; }
        public virtual DbSet<TU_CG_PEDIDOSPDTES> TU_CG_PEDIDOSPDTES { get; set; }
        public virtual DbSet<TU_CG_PERFILESONLINE> TU_CG_PERFILESONLINE { get; set; }
        public virtual DbSet<TU_CG_PERFINPACIENTE> TU_CG_PERFINPACIENTE { get; set; }
        public virtual DbSet<TU_CG_PRODUCTOS_CONTPAQ> TU_CG_PRODUCTOS_CONTPAQ { get; set; }
        public virtual DbSet<TU_CG_PRODUCTOSK> TU_CG_PRODUCTOSK { get; set; }
        public virtual DbSet<TU_CG_PRUEBAS_HOY> TU_CG_PRUEBAS_HOY { get; set; }
        public virtual DbSet<TU_CG_PRUEBASMAYO> TU_CG_PRUEBASMAYO { get; set; }
        public virtual DbSet<TU_CG_REG_PAPELETADIA> TU_CG_REG_PAPELETADIA { get; set; }
        public virtual DbSet<TU_CG_REPORTE_FACT> TU_CG_REPORTE_FACT { get; set; }
        public virtual DbSet<TU_CG_RESUL_EXAMEN> TU_CG_RESUL_EXAMEN { get; set; }
        public virtual DbSet<TU_CG_RESUL_EXAMEN1> TU_CG_RESUL_EXAMEN1 { get; set; }
        public virtual DbSet<TU_CG_RESUMENCTE> TU_CG_RESUMENCTE { get; set; }
        public virtual DbSet<TU_CG_SALDOSINICIALESCOMPAC> TU_CG_SALDOSINICIALESCOMPAC { get; set; }
        public virtual DbSet<TU_CG_SEG_PRUEBAS> TU_CG_SEG_PRUEBAS { get; set; }
        public virtual DbSet<TU_CG_SERVICIOSGACSA> TU_CG_SERVICIOSGACSA { get; set; }
        public virtual DbSet<TU_CG_SERVICIOSGACSA_AUDIO> TU_CG_SERVICIOSGACSA_AUDIO { get; set; }
        public virtual DbSet<TU_CG_SERVICIOSGACSA_ESPIRO> TU_CG_SERVICIOSGACSA_ESPIRO { get; set; }
        public virtual DbSet<TU_CG_TRELLEBORG_ADUIOMETRIA> TU_CG_TRELLEBORG_ADUIOMETRIA { get; set; }
        public virtual DbSet<TU_CG_TRELLEBORG_ESPIROMETRIA> TU_CG_TRELLEBORG_ESPIROMETRIA { get; set; }
        public virtual DbSet<TU_CG_TRELLEBORG_EXMEDICO> TU_CG_TRELLEBORG_EXMEDICO { get; set; }
        public virtual DbSet<TU_CG_VISTAEXAM> TU_CG_VISTAEXAM { get; set; }
        public virtual DbSet<TU_FM_CLIENTE_ASESR> TU_FM_CLIENTE_ASESR { get; set; }
        public virtual DbSet<TU_FM_PAPSA_CAT_TOTALES> TU_FM_PAPSA_CAT_TOTALES { get; set; }
        public virtual DbSet<TU_FM_PAPSA_CAT_TOTALES2> TU_FM_PAPSA_CAT_TOTALES2 { get; set; }
        public virtual DbSet<TU_FM_PAPSA_CAT_TOTALES3> TU_FM_PAPSA_CAT_TOTALES3 { get; set; }
        public virtual DbSet<TU_FM_PERF> TU_FM_PERF { get; set; }
        public virtual DbSet<TU_FM_PERFILES> TU_FM_PERFILES { get; set; }
        public virtual DbSet<TU_FM_PRODUCSIM> TU_FM_PRODUCSIM { get; set; }
        public virtual DbSet<TU_FM_PRODUCTOS_ACTUALES> TU_FM_PRODUCTOS_ACTUALES { get; set; }
        public virtual DbSet<VW_CG_FACTURAS> VW_CG_FACTURAS { get; set; }
        public virtual DbSet<VW_CORTE_TOYOTA> VW_CORTE_TOYOTA { get; set; }
        public virtual DbSet<VW_SEGUIMIENTO_PERFILES> VW_SEGUIMIENTO_PERFILES { get; set; }
        public virtual DbSet<VW_TOY_PRUEBASINTERPRETACION> VW_TOY_PRUEBASINTERPRETACION { get; set; }
        public virtual DbSet<VW_TOY_PRUEBASINTERPRETACION_02> VW_TOY_PRUEBASINTERPRETACION_02 { get; set; }
        public virtual DbSet<VW_TOY_PRUEBASINTERPRETACION_CRAM> VW_TOY_PRUEBASINTERPRETACION_CRAM { get; set; }
    }
}