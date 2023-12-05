using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PersonService
    {

        private static List<PersonModel> db = new List<PersonModel>()
        {
            new PersonModel()
            {
                Id = new Guid("e024379c-8b2e-490e-bdb5-09e86e510f80"),
                Name = "Person 1",
                Age = 20,
                Active = true
            },
            new PersonModel()
            {
                Id = new Guid("b2f3f284-66b0-45e7-8e51-424f46e5d5ac"),
                Name = "Person 2",
                Email = "email2@gmail.com",
                Age = 22,
                Active = true
            },
            new PersonModel()
            {
                Id = new Guid("65b0b61b-c38d-4cdb-bcb9-bc4d3a577d15"),
                Name = "Person 3",
                Email = "email3Gmail.com",
                Age = 24,
                Active = false
            },
        };
        
        public List<PersonModel> ListAll()
        {
            return db;
        }

        public PersonModel FindById(Guid id)
        {
            return db.FirstOrDefault(x => x.Id == id);
        }

        public void Add(PersonModel model)
        {
            db.Add(model);
        }

        public void Delete(Guid id)
        {
            db.Remove(FindById(id));
        }

        public void Update(PersonModel person)
        {
            var index = db.FindIndex(p => p.Id == person.Id);
            if (index == -1)
                return;

            db[index] = person;
        }
    }
}
