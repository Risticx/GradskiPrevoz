using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Models
{
    public class Radnik
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(10)]
        public string RadnoMesto { get; set; }


        [Required]
        [Range(1000000000000, 9999999999999)]
        public int MatBr { get; set; }

        [Required]
        [MaxLength(20)]
        public string Ime { get; set; } 

        [Required]
        [MaxLength(20)]
        public string Prezime { get; set; }

        public virtual Autobus Autobus { get; set; }
        [JsonIgnore]
        public virtual List<Karta> Karte { get; set; }

    }
}