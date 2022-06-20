using System.ComponentModel.DataAnnotations.Schema;

namespace FuncionariosAPI.Models.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
