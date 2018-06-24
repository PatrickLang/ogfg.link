﻿using Microsoft.EntityFrameworkCore;
using ogfg.recipeapp.Models;

namespace ogfg.recipeapp.Data
{
    public class RecipeContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }

        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().ToTable("Recipe");
        }
    }
}