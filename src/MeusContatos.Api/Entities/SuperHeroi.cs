using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MeusContatos.Api.Entities
{
    [Table("banco_herois")]
    public class SuperHeroi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("poder")]
        public string? Poder { get; set; }
        [Column("nome")]
        public string? Name { get; set; }
        [Column("sexo")]
        public string? Sexo { get; set; }
        [Column("peso")]
        public int Peso { get; set; }
        [Column("studio")]
        public string? Studio { get; set; }
        [Column("tamanho")]
        public int Tamanho { get; set; }
        [Column("cor_do_uniforme")]
        public string? CorDoUniforme { get; set; }
        
    }
}
