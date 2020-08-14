using System.ComponentModel.DataAnnotations;

namespace CentralErrosDDD.Domain.Entitys
{
    public class Environment : Base
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }
    }
}
