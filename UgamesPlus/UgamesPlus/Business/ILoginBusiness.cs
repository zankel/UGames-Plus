using UgamesPlus.Data.VO;

namespace UgamesPlus.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UsuarioVO usuario);

        TokenVO ValidateCredentials(TokenVO token);

        bool RevokeToken(string userName);
    }
}
