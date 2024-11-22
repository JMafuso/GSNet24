using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GSNet24.Model
{
    [Table("APARELHO_NET")]
    public class AparelhoModel
    {
        [Key]
        [Column("ID_APARELHO")]
        public int AparelhoId { get; set; }


        [Column("NOME_APARELHO")]
        [Required(ErrorMessage = "Nome do Aparelho é requerido")]
        [StringLength(100, ErrorMessage = "Tamanho máximo é de 100 caracteres")]
        public string NomeAparelho { get; set; }

        [Column("TEMPO_UTILIZADO")]
        [Required(ErrorMessage = "Tempo Utilizado é requerido")]
        public int TempoUso { get; set; }


    }
}