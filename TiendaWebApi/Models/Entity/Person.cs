using System.ComponentModel.DataAnnotations;

namespace TiendaWebApi.Models.Entity
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string BusinessName { get; set; } = string.Empty;

        public string Dni { get; set; }= string.Empty;

        public System.DateTime DateBirth { get; set; }

        [StringLength(50)]
        public string Email { get; set; } = string.Empty;

        [StringLength(30)]
        public string Phone { get; set; } = string.Empty;

    }
}
