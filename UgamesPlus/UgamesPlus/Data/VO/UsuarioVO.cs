using System.Collections.Generic;
using UgamesPlus.Hypermedia;

namespace UgamesPlus.Data.VO
{
    public class UsuarioVO 
    {
        public long Id { get; set; }
        public string Password { get; set; }
       public string UserName { get; set; }

       public List<HyperMediaLink> Links { get; set; } = new List<HyperMediaLink>();
    }
}