using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Request_Management_System.Models
{
    [Table("Tickets")]
    public class Ticket
    {
        [Key]
        [Required]
        [Display(Name = "Número da Solicitação de Atendimento")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Serviço")]
        [MaxLength(50)]
        public string Service { get; set; }

        [Display(Name = "Subserviço")]
        [MaxLength(50)]
        public string Subservice { get; set; }

        [Required]
        [Display(Name = "Status")]
        [MaxLength(20)]
        public string Status { get; set; }


        [Display(Name = "Anotações")]
        public string Notes { get; set; }

        [Required]
        [Display(Name = "Descrição")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Contato")]
        [MaxLength(50)]
        public string Contact { get; set; }

        [Display(Name = "Caminho do Arquivo")]
        public string URLFile { get; set; }

        [Display(Name = "Data de Inicio do Atendimento")]
        public DateTime DateStart { get; set; }

        [Display(Name = "Data de Conclusão do Atendimento")]
        public DateTime DateClosed { get; set; }

        [Display(Name = "Tempo do Acordo de Nível de Serviço")]
        public DateTime SLA { get; set; }

        [Required]
        [Display(Name = "Data de Abertura")]
        public DateTime DateOpen { get; set; }

        [Required]
        [Display(Name = "Urgência")]
        public byte LevelUrgency { get; set; }

        [Required]
        [Display(Name = "Fila de Atendimento")]
        public byte Queue { get; set; }


        // Propriedade de navegação | Criando chave estrangeira User 1 - N Ticket
        public int UserId { get; set; }
        public virtual User User { get; set; }

        // Propriedade de navegação | Criando chave estrangeira Department 1 - N Ticket
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        // Propriedade de navegação | Criando chave estrangeira TicketQueue 1 - N Ticket
        public int TicketQueueId { get; set; }
        public virtual TicketQueue TicketQueue { get; set; }

        // Propriedade de navegação | Criando chave estrangeira TicketHistory 1 - 1 Ticket
        public int TicketHistorytId { get; set; }
        public virtual TicketHistory TicketHistory { get; set; }

        // Propriedade de navegação | Criando chave estrangeira Equipment N - N Ticket

        public List<Equipment> Equipment { get; set; }

    }
}
