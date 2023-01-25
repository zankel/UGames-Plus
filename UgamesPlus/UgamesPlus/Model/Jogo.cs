using UgamesPlus.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace UgamesPlus.Model
{
    [Table("jogo")]
    public class Jogo : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }

        public Post post { get; set; }
    }
}
