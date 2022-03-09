using System.Collections.Generic;

namespace OP.PortalOncoprod.Application.ViewModels
{
    public class PagedViewModel<T> where T : class
    {
        public IEnumerable<T> List { get; set; }
        public int Count { get; set; }
    }
}