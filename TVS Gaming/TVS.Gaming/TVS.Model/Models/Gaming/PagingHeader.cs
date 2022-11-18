using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVS.Model.Models.Gaming
{
    public class PagingHeader
    {
        public int TotalItems { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public bool HasPreviousPage { get; set; }
        public int PreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int NextPage { get; set; }
    }

    public class PagingParams
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public string SearchData { get; set; }
    }
}
