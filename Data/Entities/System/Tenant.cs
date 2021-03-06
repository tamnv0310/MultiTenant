﻿using Data.Abstracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Entities
{
    public class Tenant : EntityBase
    {
        [Required]
        public string TenantId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SubDomain { get; set; }

        [Required]
        public string Server { get; set; }

        [Required]
        public string Database { get; set; }

        [Required]
        public bool IsEnabled { get; set; }

        [Required]
        public int Subscription { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime SubscriptionExipreDate { get; set; }

        [Required]
        public string DbConnectionString { get; set; }
    }
}
