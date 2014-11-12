using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;



namespace Datos
{
    public class InquilinoDBContext:DbContext
    {
        public DbSet<Inquilino> Inquilinos { get; set; }

    }
}
