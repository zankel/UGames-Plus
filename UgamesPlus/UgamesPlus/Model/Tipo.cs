using RestWithASPNETUdemy.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASPNETUdemy.Model
{
    [Table("tipo")]
    public class Tipo : BaseEntity
    {

        [Column("descritivo")]
        public string Descritivo { get; set; }

        public Post post { get; set; }

    }

}
