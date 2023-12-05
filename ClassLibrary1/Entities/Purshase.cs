using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Validations;

namespace Domain.Entities
{
    public sealed class Purshase
    {
        public Guid IdPurshase { get; private set; }
        public Guid IdPerson { get; private set; }
        public Guid IdPRoduct { get; private set; }
        public DateTime Data { get; private set;}
        public Person Person { get; set; }
        public Product Product { get; set; }

        public Purshase(Guid idPerson, Guid idProduct, DateTime? data)
        {
            Validations(idPerson, idProduct, data);
        }

        public Purshase(Guid idPurshase, Guid idPerson, Guid idProduct, DateTime? data)
        {
            DomainValidationException.When(idPurshase == Guid.Empty, "Deve ser informar Id da Compra");
            IdPurshase = idPurshase;
            Validations(idPerson, idProduct, data);
        }

        private void Validations(Guid idPerson, Guid idProduct, DateTime? data) 
        {
            DomainValidationException.When(idPerson == Guid.Empty, "Deve ser informar Id da Pessoa");
            DomainValidationException.When(idProduct == Guid.Empty, "Deve ser informar Id do Produto");
            DomainValidationException.When(data.HasValue, "Deve ser informar a data da compra");

            IdPerson = idPerson;
            IdPRoduct = idProduct;
            Data = (DateTime)data;
        }
    }
}
