using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamLindsay.Structure.Search
{
    public class BaseSearch
    {
        public int TotalCount { get; set; }
        public int CountPerPage { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
    }
}
