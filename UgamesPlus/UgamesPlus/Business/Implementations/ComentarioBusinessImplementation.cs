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

        // Method responsible for returning one person by ID
        public ComentarioVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindByID(id));
        }

        // Method responsible to crete one new person
        public ComentarioVO Create(ComentarioVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for updating one person
        public ComentarioVO Update(ComentarioVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

