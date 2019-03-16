using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSimulacionExamen.Models
{
    [Table("Doctor")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Doctor_No")]
        public int Doctor_Numero { get; set; }

        [Column("Apellido")]
        public string Apellido { get; set; }

        [Column("Especialidad")]
        public string Especialidad { get; set; }

        [Column("Salario")]
        public int Salario { get; set; }

        [Column("Hospital_cod")]
        public int  Hospital_cod { get; set; }

    }
}