using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Request_Management_System.Models
{
    [Table("TicketQueues")]
    public class TicketQueue
    {
        [Key]
        [Required]
        [Display(Name = "Identificador da Fila")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome da Fila de Atendimento")]
        [MaxLength(30)]
        public string Name { get; set; }

        // Propriedade de navegação | Criando chave estrangeira TicketQueue 1 - N Ticket
        public List<Ticket> Ticket { get; set; }
    }
}
