using Icatu.EmployeeManagerAPI.model;
using System.Collections.Generic;

namespace Icatu.EmployeeManagerAPI.Business
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);

        bool Exist(long? id);
    }
}
