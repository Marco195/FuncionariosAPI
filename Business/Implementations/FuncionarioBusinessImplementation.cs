using FuncionariosAPI.Models;
using FuncionariosAPI.Repository;
using System.Collections.Generic;

//Lida com as regras de negócio por Funcionário
namespace FuncionariosAPI.Business.Implementations
{
    public class FuncionarioBusinessImplementation : IFuncionarioBusiness
    {
        private IFuncionarioRepository _repository;

        public FuncionarioBusinessImplementation(IFuncionarioRepository repository)
        {
            _repository = repository;
        }

        public Funcionario Create(Funcionario funcionario)
        {
            return _repository.Create(funcionario);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Funcionario> FindAll()
        {
            return _repository.FindAll();
        }

        public Funcionario FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Funcionario Update(Funcionario funcionario)
        {
            return _repository.Update(funcionario);
        }

        //TODO: criar a busca da listagem de salários por Funcionário.
    }
}
