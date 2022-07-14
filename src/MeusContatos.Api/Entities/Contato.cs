using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusContatos.Api.Entities
{
    [Table("contato")]
    public class Contato
    {
        public Contato()
        {
            //DtCadastro = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("nome")]
        public string Nome { get; set; }
        [Column("telefone")]
        public string Telefone { get; set; }
        //[Column("dtcadastro")]
        //public DateTime? DtCadastro { get; set; }
    }
}
