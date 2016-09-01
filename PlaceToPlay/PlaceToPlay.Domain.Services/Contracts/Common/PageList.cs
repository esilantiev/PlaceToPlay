using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaceToPlay.Domain.Services.Contracts.Common
{
    public class PageList<T>
    {
        /// <summary>
        /// List of T object that will be returned from API method
        /// </summary>
        public List<T> Data { get; set; }

        /// <summary>
        /// Information about returned page <see cref="PageInfo"/>
        /// </summary>
        public PageInfo PageInfo { get; set; }
    }
}
