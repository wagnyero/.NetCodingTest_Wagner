using Icatu.EmployeeManagerAPI.Data.VO;
using System.Collections.Generic;

namespace Icatu.EmployeeManagerAPI.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        List<PersonVO> FindAll();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
