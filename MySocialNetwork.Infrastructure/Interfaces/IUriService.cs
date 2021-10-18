using MySocialNetwork.Core.QueryFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infrastructure.Interfaces
{
    public interface IUriService
    {
        Uri GetPostPaginationUrl(PostQueryFilter filter, string actionUrl);
    }
}
