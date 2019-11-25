using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCore.ViewModels
{
    public class PiesListViewModel
    {
        public IEnumerable<Models.Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
