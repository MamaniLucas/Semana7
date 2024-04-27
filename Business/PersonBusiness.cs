using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entity;
using Data;

namespace Business
{
    public class PersonBusiness
    {

        public List<Person> GetPeople() { 
        
            List<Person> people = new List<Person>();
            PersonData data = new PersonData();
            people = data.GetPeople();
            return people;

        }
        public List<Person> GetPeople2()
        {

            List<Person> people = new List<Person>();
            PersonData data = new PersonData();
            people = data.GetPeople();



            var resul = people.Where(x => x.PersonID > 18).ToList();
            return people;


        }
        public List<Person> GetPeopleByName(string name)
        {

            List<Person> people = new List<Person>();
            PersonData data = new PersonData();
            people = data.GetPeople();



            var resul = people.Where(x => x.FirstName.Contains(name)).ToList();
            return people;


        }
        public Person GetPersonByName(string name)
        {
            List<Person> people = new List<Person>();
            PersonData data = new PersonData();
            people = data.GetPeople();

            // Obtener la primera persona que coincida con el nombre proporcionado
            Person person = people.FirstOrDefault(x => x.FirstName.Contains(name));
            return person;
        }



    }


}
