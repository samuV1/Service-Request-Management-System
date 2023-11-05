using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Request_Management_System.Models
{
    [Table("TicketHistories")]
    public class TicketHistory
    {
        [Key]
        [Required]
        [Display(Name = "Identificador do Registro")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Endereço do Registro da Solicitação de Atendimento")]
        public string URLTicketRegistration { get; set; }

        [Required]
        public string OTicketO { get; set; }

        // Propriedade de navegação | Criando chave estrangeira TicketHistory 1 - 1 Ticket
        public int TicketId { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
