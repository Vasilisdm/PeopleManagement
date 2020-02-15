using System;
using System.Collections.Generic;
using PersonRepository.Interface;

namespace People.Service.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
