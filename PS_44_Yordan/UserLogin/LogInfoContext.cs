﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class LogInfoContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public LogInfoContext()
            : base(Properties.Settings.Default.DbConnect)
        {

        }
    }
}
