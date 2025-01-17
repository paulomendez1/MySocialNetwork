﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Core.QueryFilters
{
    public class PostQueryFilter
    {
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public int PageSize { get; set; }
        public int PageNumber { get; set; }
    }
}
