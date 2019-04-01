using Icatu.EmployeeManagerAPI.Data.Converters;
using Icatu.EmployeeManagerAPI.Data.VO;
using Icatu.EmployeeManagerAPI.model;
using Icatu.EmployeeManagerAPI.Repository.Generic;
using System.Collections.Generic;

namespace Icatu.EmployeeManagerAPI.Business.Implementations
{
    public class PersonBusinessImpl : IPersonBusiness
    {
        private IRepository<Person> _repository;

        private readonly PersonConverter _converter;

        public PersonBusinessImpl(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }

        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public List<PersonVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }
    }
}
