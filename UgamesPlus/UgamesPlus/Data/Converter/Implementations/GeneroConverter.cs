using RestWithASPNETUdemy.Data.Converter.Contract;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestWithASPNETUdemy.Data.Converter.Implementations
{
    public class GeneroConverter : IParser<GeneroVO, Genero>, IParser<Genero, GeneroVO>
    {
        public Genero Parse(GeneroVO origin)
        {
            if (origin == null) return null;
            return new Genero
            {
                Id = origin.Id,
                Nome = origin.Nome,         
            };
        }

        public GeneroVO Parse(Genero origin)
        {
            if (origin == null) return null;
            return new GeneroVO
            {
                Id = origin.Id,
                Nome = origin.Nome,
            };
        }

        public List<Genero> Parse(List<GeneroVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<GeneroVO> Parse(List<Genero> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
