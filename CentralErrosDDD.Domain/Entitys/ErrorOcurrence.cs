using System;
using System.ComponentModel.DataAnnotations;

namespace CentralErrosDDD.Domain.Entitys
{
    public class ErrorOcurrence : Base
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Details { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int EnvironmentId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int LevelId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Username { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int EventId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Origin { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool Filed { get; set; }
    }
}
