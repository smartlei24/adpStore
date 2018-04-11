using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdpStore.Models
{
    public class PaginationReqModel
    {
        public int CurrentPageIndex { get; set; }

        public int PageSize = 6;
    }
}
