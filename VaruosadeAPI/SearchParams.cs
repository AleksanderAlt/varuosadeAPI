using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VaruosadeAPI
{
    public class SearchParams
    {
        const int maxPageSize = 250;
        private int pageSize = 30;
        public int Page { get; set; } = 1;
        public string Name { get; set; }
        public int PageSize {
            get
            {
                return pageSize;
            }
            set
            {
                pageSize = Math.Min(value, maxPageSize);
            }
        }
        public string Sort { get; set; } = "";
    }
}
