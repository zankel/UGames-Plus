using UgamesPlus.Data.VO;
using System.Collections.Generic;

namespace UgamesPlus.Business
{
    public interface IPostBusiness
    {
        PostVO Create(PostVO post);
        PostVO FindByID(long id);
        List<PostVO> FindAll();
        PostVO Update(PostVO post);
        void Delete(long id);
    }
}
