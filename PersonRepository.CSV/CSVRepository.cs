using System;
using System.IO;
using System.Collections.Generic;
using PersonRepository.Interface;

namespace PersonRepository.CSV
{
    public class CSVRepository : IPersonRepository
    {
        string path;

        public CSVRepository()
        {
            var fileName = "test.csv";
            path = AppDomain.CurrentDomain.BaseDirectory + fileName;
        }

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
            var people = new List<Person>();

            if (File.Exists(path))
            {
                using (var reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var elements = line.Split(',');
                        var person = new Person()
                        {
                            Id = Int32.Parse(elements[0]),
                            GivenName = elements[1],
                            FamilyName = elements[2],
                            StartDate = DateTime.Parse(elements[3]),
                            Rating = Int32.Parse(elements[4]),
                            FormatString = elements[5],
                        };
                        people.Add(person);
                    }
                }
            }
            return people;
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
