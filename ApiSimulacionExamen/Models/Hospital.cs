using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ApiSimulacionExamen.Models
{
    [Table("Hospital")]
    public class Hospital
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("Hospital_cod")]
        public int Hospital_cod { get; set; }



        [Column("Nombre")]
        public string NombreHospital { get; set; }


        [Column("Direccion")]
        public string Direccion { get; set; }


        [Column("Telefono")]
        public string Telefono { get; set; }


        [Column("num_cama")]
        public string num_cama { get; set; }
    }
}