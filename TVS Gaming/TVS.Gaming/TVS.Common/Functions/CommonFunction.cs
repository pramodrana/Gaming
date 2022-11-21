using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVS.Model.Models.Gaming;

namespace TVS.Common.Functions
{
    public  class CommonFunction
    {
        /// <summary>
        /// This methods will be used to select number of records from  a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="pagingParams"></param>
        /// <returns></returns>
        public static List<T> GetRecordList<T>(List<T> t, PagingParams pagingParams)
        {
            return t.Skip(pagingParams.PageSize * (pagingParams.PageNumber - 1)).Take(pagingParams.PageSize).ToList();
        }

        /// <summary>
        /// This method will be used to implement paging
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="pagingParams"></param>
        /// <param name="searchData"></param>
        /// <returns></returns>
        public static PagingHeader GetPagingHeader<T>(List<T> source, PagingParams pagingParams, string searchData)
        {
            PagingHeader pagingHeader = new PagingHeader();

            if (string.IsNullOrEmpty(searchData))
                pagingHeader.TotalItems = source.Count();
            else
                pagingHeader.TotalItems = source.Count();


            decimal _totalPages = (decimal)pagingHeader.TotalItems / pagingParams.PageSize;
            pagingHeader.TotalPages = Convert.ToInt32(Math.Ceiling(_totalPages));
            pagingHeader.PageSize = pagingParams.PageSize;
            pagingHeader.PageNumber = pagingParams.PageNumber;
            pagingHeader.HasPreviousPage = pagingParams.PageNumber > 1;
            pagingHeader.PreviousPage = pagingHeader.HasPreviousPage ? pagingParams.PageNumber - 1 : 1;
            pagingHeader.HasNextPage = pagingParams.PageNumber < pagingHeader.TotalPages;
            pagingHeader.NextPage = pagingHeader.HasNextPage ? pagingParams.PageNumber + 1 : pagingHeader.TotalPages;
            return pagingHeader;
        }

    }
}
