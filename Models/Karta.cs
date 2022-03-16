using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Models 
{
    public class Karta
    {
        [Key]
        public int ID { get; set; } 
        public int BrojKarte { get; set; }  

        public DateTime VremeIzdavanja { get; set; } 
        public int CenaKarte { get; set; }
        [JsonIgnore]
        public virtual Radnik Radnik { get; set; }

    }

}