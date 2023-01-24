using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class JogoConverter : IParser<JogoVO, Jogo>, IParser<Jogo, JogoVO>
    {
        public Jogo Parse(JogoVO origin)
        {
            if (origin == null) return null;
            return new Jogo
            {
                Id = origin.Id,
                Nome = origin.Nome,
            };
        }

        public JogoVO Parse(Jogo origin)
        {
            if (origin == null) return null;
            return new JogoVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
            };
        }

        public List<Jogo> Parse(List<JogoVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<JogoVO> Parse(List<Jogo> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
