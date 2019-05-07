using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LocalSqlDbLibrary.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        private string _databasePath;

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
