using PieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.ViewModels
{
    public class PieListViewModel
    {
        public string CurentCategory { get; set; }
        public IEnumerable<Pie> Pies { get; set; }
    }
}
