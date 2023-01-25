using UgamesPlus.Data.VO;
using System.Collections.Generic;

namespace UgamesPlus.Business
{
    public interface IComentarioBusiness
    {
        ComentarioVO Create(ComentarioVO comentario);
        ComentarioVO FindByID(long id);
        List<ComentarioVO> FindAll();
        ComentarioVO Update(ComentarioVO comentario);
        void Delete(long id);
    }
}
