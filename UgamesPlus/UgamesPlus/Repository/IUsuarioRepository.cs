using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Repository
{
    public interface IUsuarioRepository
    {
        Usuario ValidateCredentials(UsuarioVO usuario);

        Usuario ValidateCredentials(string username);

        bool RevokeToken(string username);

        Usuario RefreshUserInfo(Usuario usuario);
    }
}
