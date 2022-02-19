using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using equiposWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace equiposWebApi
{
    public class prestamosContext : DbContext
    {
        public prestamosContext(DbContextOptions<prestamosContext> options) : base(options)
        {

        }

        public DbSet<equipos> equipos { get; set; }

    }
}
