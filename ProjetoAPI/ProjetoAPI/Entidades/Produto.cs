using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoAPI.Entidades
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Nome")]
        public string Nome { get; set; }
    }
}