using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FuncionariosAPI.Models.Context
{
    public class MySqlDbContext : DbContext
    {
        public MySqlDbContext() { }

        //Envia para o construtor base o do DbContextOptions o objeto option
        public MySqlDbContext(DbContextOptions<MySqlDbContext> option) : base(option) { }

        //public DbSet<Funcionario> Funcionarios { get; set; }

        public List<Funcionario> Funcionarios { get; set; }
    }
}
