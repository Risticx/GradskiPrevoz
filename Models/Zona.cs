using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    [Table("Zona")]
    public class Zona
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [Range(1, 4)]
        public int BrojZone { get; set; }

        [Required]
        [MaxLength(50)]
        public string NazivZone { get; set; }

        [Required]
        [Range(60, 120)]
        public int CenaKarte { get; set; }  


        [JsonIgnore]
        public virtual List<Linija> Linije { get; set; }
    } 
}