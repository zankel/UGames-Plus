using System.Collections.Generic;
using UgamesPlus.Hypermedia;
using UgamesPlus.Hypermedia.Abstract;

namespace UgamesPlus.Data.VO
{
    public class ComentarioVO : ISupportsHyperMedia
    {
        public long Id { get; set; }

        public string Descritivo { get; set; }         
        
        public long Id_Usuario { get; set; }     
        
        public long Id_Post { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}