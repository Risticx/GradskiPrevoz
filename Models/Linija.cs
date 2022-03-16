using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models 
{
    [Table("Linjia")]
    public class Linija 
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Range(1,36)]
        public int BrojLinije { get; set; }

        [Required]
        [MaxLength(100)]
        [RegularExpression(".-.")]
        public string NazivLinije { get; set; }

        [Required]
        [Range(0, 20)]
        public int DuzinaLinije { get; set; }

        [Required]
        [Range(0, 60)]
        public int VremeObilaska { get; set; }

        public virtual Zona Zona { get; set; }

        [JsonIgnore]
        public virtual List<AutobusLinija> LinijaAutobus { get; set; }
    }
}