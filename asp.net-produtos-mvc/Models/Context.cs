﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net_produtos_mvc.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=asp.net-produtos-mvc;Integrated Security=True");
        
        }


    }
}
