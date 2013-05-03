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
        public List<Person> GetAllPersons()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person
            {
                Country = "Germany",
                FirstName = "Marc",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr."
            });

            persons.Add(new Person
            {
                Country = "Germany",
                FirstName = "Herbert",
                LastName = "XYZ",
                Gender = "Male",
                Title = "Dr."
            });

            persons.Add(new Person
            {
                Country = "Germany",
                FirstName = "Marc",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr."
            });

            persons.Add(new Person
            {
                Country = "Germany",
                FirstName = "Marc",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr."
            });

            persons.Add(new Person
            {
                Country = "Germany",
                FirstName = "Marc",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr."
            });

            persons.Add(new Person
            {
                Country = "Germany",
                FirstName = "Marc",
                LastName = "Meier",
                Gender = "Male",
                Title = "Dr."
            });
            return persons; 
        }

    }
}
