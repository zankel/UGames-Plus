using UgamesPlus.Data.Converter.Contract;
using UgamesPlus.Data.VO;
using UgamesPlus.Model;
using System.Collections.Generic;
using System.Linq;

namespace UgamesPlus.Data.Converter.Implementations
{
    public class UsuarioConverter : IParser<UsuarioVO, Usuario>, IParser<Usuario, UsuarioVO>
    {
        public Usuario Parse(UsuarioVO origin)
        {
            if (origin == null) return null;
            return new Usuario
            {
                Id = origin.Id,
                Password = origin.Password,
                UserName = origin.UserName,

            };
        }

        public UsuarioVO Parse(Usuario origin)
        {
            if (origin == null) return null;
            return new UsuarioVO
            {
                Id = origin.Id,
                Password = origin.Password,
                UserName = origin.UserName,

            };
        }

        public List<Usuario> Parse(List<UsuarioVO> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<UsuarioVO> Parse(List<Usuario> origin)
        {
            if (origin == null) return null;
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
