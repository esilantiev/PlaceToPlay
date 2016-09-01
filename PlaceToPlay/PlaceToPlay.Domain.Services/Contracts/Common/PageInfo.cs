using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceToPlay.Domain.Services.Contracts.Common
{
    public class PageInfo
    {
        /// <summary>
        /// Page number which is requested
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Elements quantity on page
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Total amount of elements
        /// </summary>
        public int TotalCount { get; set; }
    }
}
