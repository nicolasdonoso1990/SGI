﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class InmobiliariaEntities : DbContext
    {
        public InmobiliariaEntities()
            : base("name=InmobiliariaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<Contratista> Contratistas { get; set; }
        public DbSet<Contrato> Contratos { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Inquilino> Inquilinos { get; set; }
        public DbSet<Mejora> Mejoras { get; set; }
        public DbSet<Pago_alquiler> Pagos_alquiler { get; set; }
        public DbSet<Pago_seguro> Pagos_seguro { get; set; }
        public DbSet<Propiedad> Propiedades { get; set; }
        public DbSet<Reparacion> Reparaciones { get; set; }
        public DbSet<Seguro> Seguros { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<Valor_mensual> Valores_mensuales { get; set; }
        public DbSet<NumeroUltimaFoto> NumeroUltimaFoto { get; set; }
        public DbSet<Cuenta_corriente> Cuentas_corrientes { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
