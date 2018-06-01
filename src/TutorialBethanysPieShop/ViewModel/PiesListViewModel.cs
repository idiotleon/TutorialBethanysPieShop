using System.Collections.Generic;
using TutorialBethanysPieShop.Models;

namespace TutorialBethanysPieShop.ViewModel
{
    public class PiesListViewModel
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}