using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Login.Entities
{
    public class Usuario
    {
        [Key]
        public String id { get; set; }
        [Required]
        public String nombre { get; set; }
        [Required]
        public String apellido { get; set; }
        [Required]
        [MaxLength(50)]
        [Index(IsUnique = true)]
        public String usuario { get; set; }
        [Required]
        public String password { get; set; }
    }
}
