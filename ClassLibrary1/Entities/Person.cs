using Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Person
    {
        public Guid IdPerson { get; private set; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public string Phone { get; private set; }
        public ICollection<Purshase> Purshases { get; private set; }

        public Person(string name, string document, string phone)
        {
            Validation(name, document, phone);
        }

        public Person(Guid idPerson, string name, string document, string phone)
        {
            DomainValidationException.When(idPerson == Guid.Empty, "IdPessoa deve ser informado");
            IdPerson = idPerson;
            Validation(name, document, phone);
        }

        private void Validation(string name, string document, string phone)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(document), "Documento deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(phone), "Telefone deve ser informado");

            Name = name;
            Document = document;
            Phone = phone;
        }
    }
}
