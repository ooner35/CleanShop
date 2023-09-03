﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanShop.Application.Features.Products.Queries.GetList
{
    public class GetListProductListItemDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int Quantity { get; set; }
    }
}
