using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoriaWebAPI
{
    public class Cliente
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime Nascimento { get; set; }
    }
}
