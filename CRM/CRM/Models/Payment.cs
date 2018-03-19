﻿using System;
using System.Collections.Generic;

namespace CRM.Models
{
    public class Payment
    {
        public static string PluralDbTableName { get { return "Payments"; } }

        public int Id { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> Sum { get; set; }
        public string Method { get; set; }

        public virtual Order Order { get; set; }
    }
}