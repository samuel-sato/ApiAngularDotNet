using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class DocumentoCarro
    {
        public Guid Id { get; private set; }
        private Car Carro;
        public PersonModel Proprietario { get; private set; }
        public DocumentoCarro(Guid id, Car carro)
        {
            this.Id = id;
            this.Carro = carro;
        }

        public void SetProprietario(PersonModel proprietario)
        {
            this.Proprietario = proprietario;
        }
    }
}
