using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class PostConverter : IParser<PostVO, Post>, IParser<Post, PostVO>
    {
        public Post Parse(PostVO origin)
        {
            if (origin == null) return null;
            return new Post
            {
                Id = origin.Id,
                Conteudo = origin.Conteudo,
                Id_Tipo = origin.Id_Tipo,
                Id_Usuario = origin.Id_Usuario,
                Id_Jogo = origin.Id_Jogo
            };
        }

        public PostVO Parse(Post origin)
        {
            if (origin == null) return null;
            return new PostVO
            {             
                Conteudo = origin.Conteudo,
                Id_Tipo = origin.Id_Tipo,
                Id_Usuario = origin.Id_Usuario,
                Id_Jogo = origin.Id_Jogo
            };
        }

        public List<Post> Parse(List<PostVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PostVO> Parse(List<Post> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
