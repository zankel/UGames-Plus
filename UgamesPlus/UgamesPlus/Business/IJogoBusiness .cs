using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IJogoBusiness
    {
        JogoVO Create(JogoVO Jogo);
        JogoVO FindByID(long id);
        List<JogoVO> FindAll();
        JogoVO Update(JogoVO Jogo);
        void Delete(long id);
    }
}
