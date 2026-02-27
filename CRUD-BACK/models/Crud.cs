using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_BACK.Models
{
    [Table("CRUD")]
    public class Crud
    {
        [Key]
        public string numero_control { get; set; }

        public string carrera { get; set; }

        public string especialidad { get; set; }

        public string nombre { get; set; }

        public int semestre { get; set; }
    }
}