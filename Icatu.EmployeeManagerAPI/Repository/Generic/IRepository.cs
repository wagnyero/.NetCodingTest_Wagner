using Icatu.EmployeeManagerAPI.model.Base;
using System.Collections.Generic;

namespace Icatu.EmployeeManagerAPI.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);

        bool Exists(long? id);
    }
}
