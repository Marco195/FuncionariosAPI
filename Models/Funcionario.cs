using FuncionariosAPI.Models.Base;
using System;

namespace FuncionariosAPI.Models
{
    public class Funcionario : BaseEntity
    {
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public double SalarioAtual { get; set; }
        public DateTime? Data_UltimasFerias { get; set; }
        /// <summary>
        /// Gerente, Head, Supervisor etc.
        /// </summary>
        public string Responsavel { get; set; }
        public DateTime? Data_UltimoAumento { get; set; }
        public DateTime Data_Admissao { get; set; }
        public string Endereco { get; set; }
    }
}
