using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ResistenciaBR.Models
{
    public class MyContext : DbContext, IDisposable
    {

        public MyContext()
            :base(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString)
        {

        }

        public System.Data.Entity.DbSet<ResistenciaBR.Models.Tip> Tips { get; set; }
    }
}