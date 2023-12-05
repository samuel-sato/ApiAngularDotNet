using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Validations;

namespace Domain.Entities
{
    public sealed class Product
    {
        public Guid IdProduct { get; private set; }
        public string Name { get; private set; }
        public string CodeErp { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, string codeErp, decimal price)
        {
            Validations(name, codeErp, price);
        }

        public Product(Guid idPRodutc, string name, string codeErp, decimal price)
        {
            DomainValidationException.When(idPRodutc == Guid.Empty, "Guid deve ser informado");
            Validations(name, codeErp, price);
        }

        private void Validations(string name, string codeErp, decimal price)
        {
            DomainValidationException.When(string.IsNullOrEmpty(name), "Nome deve ser informado");
            DomainValidationException.When(string.IsNullOrEmpty(codeErp), "Codigo Erp deve ser informado");
            DomainValidationException.When(0 < price, "Preço deve ser informado");

            Name = name;
            CodeErp = codeErp;
            Price = price;
        }
    }
}
