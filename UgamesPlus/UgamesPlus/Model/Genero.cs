using UgamesPlus.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace UgamesPlus.Model
{
    [Table("genero")]
    public class Genero : BaseEntity
    {
        [Column("nome")]
        public string Nome { get; set; }
    }
}
