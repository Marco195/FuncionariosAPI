using FuncionariosAPI.Models;
using FuncionariosAPI.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;

//Lida com o SQL
namespace FuncionariosAPI.Repository.Implementations
{
    public class FuncionarioRepositoryImplementation : IFuncionarioRepository
    {
        private MySqlDbContext _context;

        public FuncionarioRepositoryImplementation(MySqlDbContext context)
        {
            _context = context;
        }

        public Funcionario Create(Funcionario funcionario)
        {
            try
            {
                _context.Funcionarios.Add(funcionario);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {

                throw;
            }

            return funcionario;
        }

        public void Delete(long id)
        {
            var funcionario = _context.Funcionarios.SingleOrDefault(f => f.Id == id);

            if (funcionario is not null)
            {
                try
                {
                    _context.Funcionarios.Remove(funcionario);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        public List<Funcionario> FindAll()
        {
            return _context.Funcionarios.ToList();
        }

        public Funcionario FindById(long id)
        {
            return _context.Funcionarios.SingleOrDefault(f => f.Id == id);
        }

        public Funcionario Update(Funcionario funcionario)
        {
            if (!Exists(funcionario)) return null;

            var result = _context.Funcionarios.SingleOrDefault(f => f.Id == funcionario.Id);

            try
            {
                _context.Entry(result).CurrentValues.SetValues(funcionario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }

            return funcionario;
        }

        public bool Exists(Funcionario funcionario)
        {
            return _context.Funcionarios.Any(f => f.Id == funcionario.Id);
        }
    }
}
