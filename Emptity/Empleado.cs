using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emptity
{
    public class Empleado
    {
        public string ApellidoNombre { get; set; }
        public string DNI { get; set; }
        public double SueldoBruto { get; set; }
        public DateTime FechaRegistro { get; set; }

        // Método para calcular el sueldo neto restando el 17% de impuestos
        public double CalcularSueldoNeto()
        {
            return SueldoBruto * 0.83;
        }
    }
}
