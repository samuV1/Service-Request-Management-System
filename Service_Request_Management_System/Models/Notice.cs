using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Request_Management_System.Models
{
    [Table("Notices")]
    public class Notice
    {
        [Key]
        [Required]
        [Display(Name = "Número do Aviso")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Assunto")]
        [MaxLength(200)]
        public string Subject { get; set; }

        [Display(Name = "Descrição")]
        public string Description { get; set; }

        // Propriedade de navegação | Criando chave estrangeira User 1 - N Notice
        public int UserId { get; set; }
        public virtual User User { get; set; }


    }
}
