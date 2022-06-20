using FuncionariosAPI.Models;
using System.Collections.Generic;

namespace FuncionariosAPI.Business
{
    public interface IFuncionarioBusiness
    {
        Funcionario Create(Funcionario funcionario);
        Funcionario Update(Funcionario funcionario);
        void Delete(long id);
        List<Funcionario> FindAll();
        Funcionario FindById(long id);
    }
}
