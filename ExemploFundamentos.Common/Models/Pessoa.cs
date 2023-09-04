using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{   
    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa
    {
        public string Nome { get; set; }        
        public int Idade { get; set; }
        /// <summary>
        /// Faz a pessoa se apresentar, dizendo seu nome e idade
        /// </summary>
        public void Apresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome}," +
            $"e tenho {Idade} anos");
        }
        public void CadastrarNoERPXYZDaEmpresa()
        {   
            Console.WriteLine("Insira um numero: ");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Exibindo o numero: " + myNum);
        }
    }
}