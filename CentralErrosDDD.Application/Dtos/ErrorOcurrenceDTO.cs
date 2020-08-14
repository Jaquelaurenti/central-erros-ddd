using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CentralErrosDDD.Application.Dtos
{
    [Table("ERROR_OCURRENCE")]
    public class ErrorOcurrenceDTO
    {
        [Column("ID"), Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column("TITLE"), Required]
        public string Title { get; set; }

        [Column("REGISTRATION_DATE"), Required]
        public DateTime RegistrationDate { get; set; }

        [Column("ORIGIN"), Required]
        public string Origin { get; set; }

        [Column("FILED"), Required]
        public bool Filed { get; set; }

        [Column("DETAILS"), Required]
        public string Details { get; set; }

        [Column("USERNAME"), Required]
        public string Username { get; set; }

        [Column("ID_EVENTS")]
        public int EventId { get; set; }

        [Column("EnvironmentId"), Required]
        public int EnvironmentId { get; set; }

        [ForeignKey("EnvironmentId"), Required]
        public virtual EnvironmentDTO Environment { get; set; }

        [Column("LevelId"), Required]
        public int LevelId { get; set; }

        [ForeignKey("LevelId"), Required]
        public virtual LevelDTO Level { get; set; }

    }
}
