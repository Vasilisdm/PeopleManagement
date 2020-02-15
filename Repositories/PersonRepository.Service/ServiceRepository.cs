using System;
using System.Collections.Generic;
using System.Net;
using PersonRepository.Interface;

namespace PersonRepository.Service
{
    public class ServiceRepository : IPersonRepository
    {
        WebClient client = new WebClient();
        //string baseUri = ""

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetPeople()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
