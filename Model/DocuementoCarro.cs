using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    
    public class DocumentoCarro
    {
        private Guid id;
        private Car carro;
        public DocumentoCarro(Guid id, Car carro)
        {
            this.id = id;
            this.carro = carro;
        }
    }
}
