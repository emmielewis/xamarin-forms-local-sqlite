using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LocalSqlDbLibrary.Entities
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }

        public override string ToString()
        {
            return Url;
        }
    }
}
