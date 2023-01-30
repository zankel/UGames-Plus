using UgamesPlus.Data.Converter.Implementations;
using UgamesPlus.Data.VO;
using UgamesPlus.Model;
using UgamesPlus.Repository;
using System.Collections.Generic;

namespace UgamesPlus.Business.Implementations
{
    public class PostBusinessImplementation : IPostBusiness
    {

        private readonly IRepository<Post> _repository;

        private readonly PostConverter _converter;

        public PostBusinessImplementation(IRepository<Post> repository)
        {
            _repository = repository;
            _converter = new PostConverter();
        }

        // Method responsible for returning all people,
        public List<PostVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one post by ID
        public PostVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new post
        public PostVO Create(PostVO post)
        {
            var postEntity = _converter.Parse(post);
            postEntity = _repository.Create(postEntity);
            return _converter.Parse(postEntity);
        }

        // Method responsible for updating one post
        public PostVO Update(PostVO post)
        {
            var postEntity = _converter.Parse(post);
            postEntity = _repository.Update(postEntity);
            return _converter.Parse(postEntity);
        }

        // Method responsible for deleting a post from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

