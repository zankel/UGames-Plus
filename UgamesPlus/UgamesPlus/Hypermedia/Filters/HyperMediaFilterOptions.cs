using UgamesPlus.Hypermedia.Abstract;
using System.Collections.Generic;

namespace UgamesPlus.Hypermedia.Filters
{
    public class HyperMediaFilterOptions
    {
        public List<IResponseEnricher> ContentResponseEnricherList { get; set; } = new List<IResponseEnricher>();
    }
}
