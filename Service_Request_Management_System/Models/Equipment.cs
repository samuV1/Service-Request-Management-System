using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Request_Management_System.Models
{
    [Table("Equipaments")]
    public class Equipment
    {
        [Key]
        [Required]
        [Display(Name = "Patrimônio")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo do Equipamento")]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        [Display(Name = "Marca")]
        [MaxLength(50)]
        public string Brad { get; set; }

        [Required]
        [Display(Name = "Modelo")]
        [MaxLength(50)]
        public string Model { get; set; }

        [Required]
        [Display(Name = "Data de Aquisição")]
        public DateOnly DateAcquisition { get; set; }

        //Propriedade de navegação | Criando chave estrangeira Department 1 - N Equipment
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        // Propriedade de navegação | Criando chave estrangeira Equipment N - N Ticket

        public List<Ticket> Ticket { get; set; }
    }
}
