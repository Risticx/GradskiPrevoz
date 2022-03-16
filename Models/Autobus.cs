using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models 
{
    public class Autobus 
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string RegistarskaOznaka { get; set; }

        [Required]
        [Range(0, 1000000)]
        public int Kilometraza { get; set; }
        
        public virtual List<AutobusLinija> AutobusLinija { get; set; }
        
        public int RadnikId { get; set; }
        [JsonIgnore]
        public virtual Radnik Radnik { get; set; }
        
    }
}