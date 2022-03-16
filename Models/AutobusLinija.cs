using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models 
{
    public class AutobusLinija 
    {
        [Key]
        public int ID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DanVoznje { get; set; }
        

        [JsonIgnore]
        public virtual Autobus Autobus { get; set; }

        public virtual Linija Linija { get; set; }
    }
}