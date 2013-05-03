using BusinessLogic.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.DataProvider.PersonManager
{
    public class PersonManagerMock:IPersonManager
    {
        List<Person> persons = new List<Person>();
        public PersonManagerMock()
        {
            persons.Add(new Person
            {
                ID = 0,
                Country = "Germany",
                FirstName = "Max",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr.",
                City = "Darmstadt", 
                University = "TU Darmstadt"
            });

            persons.Add(new Person
            {
                ID = 1,
                Country = "Germany",
                FirstName = "Reiner",
                LastName = "Laux",
                Gender = "Male",
                Title = "",
                City = "Bonn",
                University = "Universität Bonn"
            });

            persons.Add(new Person
            {
                ID = 2,
                Country = "Switzerland",
                FirstName = "Logi",
                LastName = "Löw",
                Gender = "Male",
                Title = "Dr.",
                City = "Bern",
                University = "ETH Zürich"
            });

            persons.Add(new Person
            {
                ID = 3,
                Country = "France",
                FirstName = "Inka",
                LastName = "Schröder",
                Gender = "Female",
                Title = "",
                City = "Paris",
                University = "Ecole des Paris"
            });

            persons.Add(new Person
            {
                ID = 4,
                Country = "Germany",
                FirstName = "Heiner",
                LastName = "Kroos",
                Gender = "Male",
                Title = "Dr.",
                City = "Berlin",
                University = "Freie Universität Berlin"
            });

            persons.Add(new Person
            {
                ID = 5,
                Country = "Germany",
                FirstName = "Lili",
                LastName = "Nice",
                Gender = "Female",
                Title = "Dr.",
                City = "Hamburg",
                University = "Hamburg Universität"
            });

        }
        public List<Person> GetAllPersons()
        {
            return persons; 
        }


        public Person GetPersonByID(Person personFilter)
        {
             return persons.Find(person => person.ID == personFilter.ID); 

        }
    }
}
