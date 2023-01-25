using UgamesPlus.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace UgamesPlus.Model
{
    [Table("comentario")]
    public class Comentario : BaseEntity 
    {
        [Column("descritivo")]
        public string Descritivo { get; set; }

        [ForeignKey("Usuario")]
        public long Id_Usuario { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Post")]
        public long Id_Post { get; set; }
        public Post Post { get; set; }
    }
}
