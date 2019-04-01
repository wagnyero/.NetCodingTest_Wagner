using Icatu.EmployeeManagerAPI.model;
using Icatu.EmployeeManagerAPI.model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Icatu.EmployeeManagerAPI.Business.Implementations
{
    public class PersonRepositoryImpl : IPersonRepository
    {
        private readonly MySQLContext _context;

        public PersonRepositoryImpl(MySQLContext context)
        {
            _context = context;
        }
        
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public List<Person> FindAll()
        {
            return _context.Persons.ToList();
        }

        public Person Update(Person person)
        {
            if (!Exist(person.Id)) return null;

            var result = _context.Persons.SingleOrDefault(b => b.Id == person.Id);
            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return result;
        }

        public void Delete(long id)
        {
            var result = _context.Persons.SingleOrDefault(i => i.Id.Equals(id));
            try
            {
                if (result != null) _context.Persons.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Exist(long? id)
        {
            return _context.Persons.Any(b => b.Id.Equals(id));
        }
    }
}
