using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pagination.Models
{
    public class DemoViewModel
    {
        public string IdSortParam { get; set; }
        public string NameSortParam { get; set; }
        public string SearchName { get; set; }
        public List<DemoTable> Demos { get; set; }
        public int PageIndex { get; set; }
        public int TotalCount { get; set; }
    }
}
