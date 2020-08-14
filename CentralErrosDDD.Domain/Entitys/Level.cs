using System.ComponentModel.DataAnnotations;

namespace CentralErrosDDD.Domain.Entitys
{
    public class Level : Base
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Name { get; set; }
    }
}
