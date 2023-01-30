using UgamesPlus.Data.Converter.Implementations;
using UgamesPlus.Data.VO;
using UgamesPlus.Model;
using UgamesPlus.Repository;
using System.Collections.Generic;

namespace UgamesPlus.Business.Implementations
{
    public class ComentarioBusinessImplementation : IComentarioBusiness
    {

        private readonly IRepository<Comentario> _repository;

        private readonly ComentarioConverter _converter;

        public ComentarioBusinessImplementation(IRepository<Comentario> repository)
        {
            _repository = repository;
            _converter = new ComentarioConverter();
        }

        // Method responsible for returning all people,
        public List<ComentarioVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one comentario by ID
        public ComentarioVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new comentario
        public ComentarioVO Create(ComentarioVO comentario)
        {
            var comentarioEntity = _converter.Parse(comentario);
            comentarioEntity = _repository.Create(comentarioEntity);
            return _converter.Parse(comentarioEntity);
        }

        // Method responsible for updating one comentario
        public ComentarioVO Update(ComentarioVO comentario)
        {
            var comentarioEntity = _converter.Parse(comentario);
            comentarioEntity = _repository.Update(comentarioEntity);
            return _converter.Parse(comentarioEntity);
        }

        // Method responsible for deleting a comentario from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

