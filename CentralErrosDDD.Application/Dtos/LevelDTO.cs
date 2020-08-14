
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CentralErrosDDD.Application.Dtos
{
    [Table("LEVEL")]
    public class LevelDTO
    {
        [Column("ID")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Column("LEVEL")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        public virtual ICollection<ErrorOcurrenceDTO> ErrorOccurrences { get; set; }
         
    }
}
