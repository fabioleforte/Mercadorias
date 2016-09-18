using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Desafio.Models
{
    public class EFContext:DbContext
    {

        public EFContext() : base("MERCADORIAS") { }

        public DbSet<MERCADORIA> Mercadorias { get; set; }
    }
}