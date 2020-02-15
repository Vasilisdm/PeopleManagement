using System;
using System.Collections.Generic;
using PersonRepository.Interface;
using PersonRepository.Service;

namespace PeopleManagement
{
    public class ApiCaller
    {
        IPersonRepository repository = new ServiceRepository();
        public ApiCaller()
        {
            IEnumerable<Person> people = repository.GetPeople();
        }
    }
}
