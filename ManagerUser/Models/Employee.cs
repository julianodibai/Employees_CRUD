
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ManagerUser.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; } 
        
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Preenchimento obrigatório")]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Matricula")]
        public string Code { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Cargo")]
        public String Position { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Localização")]
        public string OfficeLocation { get; set; }

        public Employee()
        {

        }
        public Employee(int id, string name, string code, string position, string officeLocation)
        {
            Id = id;
            Name = name;
            Code = code;
            Position = position;
            OfficeLocation = officeLocation;
        }

    }
}
