using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service_Request_Management_System.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Required]
        [Display(Name = "Matrícula")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Display(Name = "Foto")]
        public string URLPhoto { get; set; }

        [Required]
        [Display(Name = "Acesso Administrador")]
        public bool UserAdministrador { get; set; }

        [Required]
        [Display(Name = "Nível de Acesso")]
        public byte LevelSystem { get; set; }


        // Propriedade de navegação | Criando chave estrangeira User 1 - N Notice
        public List<Notice> Notice { get; set; }

        // Propriedade de navegação | Criando chave estrangeira User 1 - N Tiket
        public List<Ticket> Ticket { get; set; }

        //Propriedade de navegação | Criando chave estrangeira Department 1 - N User
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
