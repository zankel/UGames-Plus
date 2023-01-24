using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("jogo")]
    public class Jogo : BaseEntity
    {

        [Column("nome")]
        public string Nome { get; set; }

    }

}
