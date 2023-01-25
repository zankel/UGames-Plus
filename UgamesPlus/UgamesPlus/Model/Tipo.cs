using UgamesPlus.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace UgamesPlus.Model
{
    [Table("tipo")]
    public class Tipo : BaseEntity
    {
        [Column("descritivo")]
        public string Descritivo { get; set; }

        public Post post { get; set; }
    }
}
