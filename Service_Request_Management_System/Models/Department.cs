using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Request_Management_System.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        [Required]
        [Display(Name = "Código do Setor")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome do Setor")]
        [MaxLength(100)]
        public string Name { get; set;}

        // Propriedade de navegação | Chave estrangeira Department 1 - N Equipment
        public List<Equipment> Equipment { get; set; }

        // Propriedade de navegação | Chave estrangeira Department 1 - N User
        public List<User> User { get; set; }

        // Propriedade de navegação | Chave estrangeira Department 1 - N Ticket
        public List<Ticket> Ticket { get; set; }
    }
}
