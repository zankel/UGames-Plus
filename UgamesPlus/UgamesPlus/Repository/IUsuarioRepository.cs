using UgamesPlus.Data.VO;
using UgamesPlus.Model;

namespace UgamesPlus.Repository
{
    public interface IUsuarioRepository
    {
        Usuario ValidateCredentials(UsuarioVO usuario);

        Usuario ValidateCredentials(string username);

        bool RevokeToken(string username);

        Usuario RefreshUserInfo(Usuario usuario);
    }
}
