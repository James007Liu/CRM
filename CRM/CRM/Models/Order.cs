﻿using System;

namespace CRM.Models
{
    public partial class Order
    {
        public static string PluralDbTableName { get { return "Orders"; } }

        public int Id { get; set; }
        public string Number { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public string Status { get; set; }
        public int OwnerId { get; set; }
        public Nullable<int> DeliveryDriverId { get; set; }
        public string DeliveryAddress { get; set; }
        public Nullable<int> ReceiverId { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual User DeliveryDriver { get; set; }
        public virtual User Owner { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
