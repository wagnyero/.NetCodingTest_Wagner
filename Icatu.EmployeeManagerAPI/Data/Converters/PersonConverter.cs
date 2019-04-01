using Icatu.EmployeeManagerAPI.Data.Converter;
using Icatu.EmployeeManagerAPI.Data.VO;
using Icatu.EmployeeManagerAPI.model;
using System.Collections.Generic;
using System.Linq;

namespace Icatu.EmployeeManagerAPI.Data.Converters
{
    public class PersonConverter : IParser<PersonVO, Person>, IParser<Person, PersonVO>
    {
        public Person Parse(PersonVO origin)
        {
            if (origin == null) return new Person();

            return new Person
            {
                Id = origin.Id,
                name = origin.name,
                email = origin.email,
                department = origin.department
            };
        }

        public PersonVO Parse(Person origin)
        {
            if (origin == null) return new PersonVO();

            return new PersonVO
            {
                Id = origin.Id,
                name = origin.name,
                email = origin.email,
                department = origin.department
            };
        }

        public List<Person> ParseList(List<PersonVO> origin)
        {
            if (origin == null) return new List<Person>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<PersonVO> ParseList(List<Person> origin)
        {
            if (origin == null) return new List<PersonVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
