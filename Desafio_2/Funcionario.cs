using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_2
{
    public class Funcionario
    {
        public string Nome;
        public decimal Salario;


        public virtual decimal CalcularSalarioTotal()
        {
            return Salario;
        }

    }

    public class Gerente:Funcionario
    {
        public decimal Bonus;
    
        public override decimal CalcularSalarioTotal()
        {    
            return base.CalcularSalarioTotal() + Bonus;         
        }
    }
}