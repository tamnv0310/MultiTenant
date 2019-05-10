﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contants
{
    public class TenantConstant
    {
        public const string LocalServer = "(localdb)\\mssqllocaldb";
        public const string LocalDbConnectionString = @"Server={NCS_DbServer};Database={NCS_DbName};Trusted_Connection=True;MultipleActiveResultSets=true";
    }
}
