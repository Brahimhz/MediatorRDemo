using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<PersonModel> _people = new List<PersonModel>();

        public DemoDataAccess()
        {
            _people.Add(new PersonModel { Id = 1, FirstName = "Person1", LastName = "Person1" });
            _people.Add(new PersonModel { Id = 2, FirstName = "Person2", LastName = "Person2" });
        }

        //Access to people from the method not directly from the var
        public List<PersonModel> getPeople()
        {
            return _people;
        }

        public PersonModel InsertPerson(string firstName, string lastName)
        {
            PersonModel p = new PersonModel { FirstName = firstName, LastName = lastName };
            p.Id = _people.Max(p => p.Id) + 1;

            _people.Add(p);
            return p;
        }
    }
}
