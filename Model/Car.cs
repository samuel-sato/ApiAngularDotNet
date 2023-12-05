using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public Guid Id { get; set; }
        public int Ano { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        
        public Car(Guid id, int ano, string modelo, string placa)
        {
            Id = id;
            Ano = ano;
            Modelo = Modelo;
            Placa = Placa;
        }
    }
}
