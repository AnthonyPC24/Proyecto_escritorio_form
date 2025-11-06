using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beatrix_Formulario.ClasesTareas
{
    public class Subtareas
    {
        public string NombreSubtarea { get; set; }
        public string DescripcionSubtarea { get; set; }
        public DateTime FechaVencimientoSubtarea { get; set; }
        public DateTime FechaEntregaSubtarea { get; set; }
        public string EstadoSubtarea { get; set; }
        public List<Usuarios> usuariosAsignados { get; set; } = new List<Usuarios>();
    }
}
