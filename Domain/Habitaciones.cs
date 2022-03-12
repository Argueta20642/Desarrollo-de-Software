using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
   public class Habitaciones
    {
        public int IdHabitacion { get; set; }
        public int numero { get; set; }
        public string Detalle { get; set; }
        public string precio { get; set; }
        public int EstadoHabitacion { get; set; }
        public int PISO { get; set; }
        public int CATEGORIA { get; set; }
        public bool Estado { get; set;}
        public DateTime FechacCreacion { get; set; }

    }
}
