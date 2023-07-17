using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MonitoraUFRGS_APP.Models
{
    public class Professor
    {
        [Key]
        private int _id;
        [Column("horaInicio")]
        private DateTime _horaInicio;

        public Professor() { }
    }
}
