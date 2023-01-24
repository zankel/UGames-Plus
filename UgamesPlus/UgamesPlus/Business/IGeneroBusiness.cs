using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IGeneroBusiness
    {
        GeneroVO Create(GeneroVO genero);
        GeneroVO FindByID(long id);
        List<GeneroVO> FindAll();
        GeneroVO Update(GeneroVO genero);
        void Delete(long id);
    }
}
