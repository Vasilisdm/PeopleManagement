using System;
namespace People.Service.Models
{
    public interface IPeopleProvider
    {
        List<Person> GetPeople();
    }
}
