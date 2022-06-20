using FuncionariosAPI.Models;
using System.Collections.Generic;

namespace FuncionariosAPI.Repository
{
    public interface IFuncionarioRepository
    {
        Funcionario FindById(long id);
        List<Funcionario> FindAll();
        Funcionario Create(Funcionario funcionario);
        Funcionario Update(Funcionario funcionario);
        void Delete(long id);
        bool Exists(Funcionario funcionario);
    }
}
