using System.Collections.Generic;
using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
