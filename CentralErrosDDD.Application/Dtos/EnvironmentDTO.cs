using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentralErrosDDD.Application.Dtos
{
    [Table("ENVIRONMENT")]
    public class EnvironmentDTO
    {

        [Column("ID")]
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("NAME")]
        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<ErrorOcurrenceDTO> ErrorOccurrences { get; set; }
    }
}
