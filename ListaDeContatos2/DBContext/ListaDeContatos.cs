using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ListaDeContatos2.DBContext
{
    public class ListaDeContatos
    {
        //class pessoa e cria a tabela da base de dados
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]// defini a chave primaria
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        [StringLength(20)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Celular { get; set; }

    }
}
