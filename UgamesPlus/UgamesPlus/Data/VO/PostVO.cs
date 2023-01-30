using System.Collections.Generic;
using UgamesPlus.Hypermedia;
using UgamesPlus.Hypermedia.Abstract;

namespace UgamesPlus.Data.VO
{
    public class PostVO : ISupportsHyperMedia
    {
        public long Id { get; set; }
        public string Conteudo { get; set; }
   
        public long Id_Tipo { get; set; }
            
        public long Id_Usuario { get; set; }
            
        public long Id_Jogo { get; set; }

        public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();

    }
}