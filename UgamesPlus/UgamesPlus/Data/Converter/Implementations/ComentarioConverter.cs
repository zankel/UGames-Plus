using UgamesPlus.Data.Converter.Contract;
using UgamesPlus.Data.VO;
using UgamesPlus.Model;
using System.Collections.Generic;
using System.Linq;

namespace UgamesPlus.Data.Converter.Implementations
{
    public class ComentarioConverter : IParser<ComentarioVO, Comentario>, IParser<Comentario, ComentarioVO>
    {
        public Comentario Parse(ComentarioVO origin)
        {
            if (origin == null) return null;
            return new Comentario
            {
                Id = origin.Id,
                Descritivo = origin.Descritivo,
                Id_Usuario = origin.Id_Usuario,
                Id_Post = origin.Id_Post
            };
        }

        public ComentarioVO Parse(Comentario origin)
        {
            if (origin == null) return null;
            return new ComentarioVO
            {
                Id = origin.Id,
                Descritivo = origin.Descritivo,
                Id_Usuario = origin.Id_Usuario,
                Id_Post = origin.Id_Post
            };
        }

        public List<Comentario> Parse(List<ComentarioVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ComentarioVO> Parse(List<Comentario> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
