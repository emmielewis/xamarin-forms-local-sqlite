using LocalSqlDbLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LocalSqlDbLibrary
{
    /// <summary>
    /// This is not a typical install and only a quick test with
    /// Xamarin Essentials for a local DB
    /// </summary>
    public static class BlogHelper
    {
        public static IList<Blog> InitializeDatabase(string dbPath)
        {
            List<Blog> itemSource;

            // Create Database & Tables
            using (var db = new DatabaseContext(dbPath))
            {
                // Ensure database is created
                db.Database.EnsureCreated();

                if (!db.Blogs.Any())
                {
                    // Insert Data
                    db.Add(new Blog() { BlogId = 1, Rating = 5, Url = "https://exrin.net" });
                    db.Add(new Blog() { BlogId = 2, Rating = 5, Url = "https://xamarinhelp.com" });
                    db.Add(new Blog() { BlogId = 3, Rating = 5, Url = "https://azuremobilehelp.com" });
                    db.SaveChanges();
                }

                // Retreive Data
                itemSource = db.Blogs.ToList();
            }

            return itemSource;
        }
    }
}
