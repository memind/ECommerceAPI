﻿using ECommerceAPI.Domain.Entities.Common;

namespace ECommerceAPI.Domain.Entities
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public string OrderCode { get; set; }

        // Nav Props
        public Basket Basket { get; set; }
        public CompletedOrder CompletedOrder { get; set; }
    }
}
