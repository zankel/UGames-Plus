using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("genero")]
    public class Genero : BaseEntity
    {

        [Column("nome")]
        public string Nome { get; set; }

    }

}
