using UgamesPlus.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace UgamesPlus.Model
{
    [Table("post")]
    public class Post : BaseEntity 
    {
        [Column("conteudo")]
        public string Conteudo { get; set; }

        [ForeignKey("Tipo")]
        public long Id_Tipo { get; set; }
        public Tipo Tipo { get; set; }

        [ForeignKey("Usuario")]
        public long Id_Usuario { get; set; }
        public Usuario Usuario { get; set; }

        [ForeignKey("Jogo")]
        public long Id_Jogo { get; set; }
        public Jogo Jogo { get; set; }
    }
}
