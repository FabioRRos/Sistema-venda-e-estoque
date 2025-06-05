using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema.Domain.Entities
{
    public class Funcionario
    {
        public int master { get; set; }
        public string Nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }
    }
}