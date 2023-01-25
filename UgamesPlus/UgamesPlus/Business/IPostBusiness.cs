using RestWithASPNETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business
{
    public interface IPostBusiness
    {
        PostVO Create(PostVO Post);
        PostVO FindByID(long id);
        List<PostVO> FindAll();
        PostVO Update(PostVO Post);
        void Delete(long id);
    }
}
