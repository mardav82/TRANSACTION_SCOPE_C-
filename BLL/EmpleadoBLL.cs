using DLL;
using Emptity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class EmpleadoBLL
    {
        private EmpleadoDALL empleadoData;

        public EmpleadoBLL()
        {
            empleadoData = new EmpleadoDALL();
        }

        public string GuardarEmpleados(List<Empleado> empleados)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    foreach (var empleado in empleados)
                    {
                        // Validaciones de negocio
                        if (empleado.ApellidoNombre.Length <= 5)
                            throw new Exception("El nombre debe tener más de 5 caracteres.");
                        if (empleado.DNI.Length != 11)
                            throw new Exception("El DNI debe tener 11 caracteres.");
                        if (empleado.SueldoBruto < 100000)
                            throw new Exception("El sueldo bruto no puede ser menor a 100000.");

                        // Inserta el empleado en la base de datos
                        empleadoData.InsertarEmpleado(empleado);
                    }

                    // Confirma la transacción si no hubo errores
                    scope.Complete();
                    return "Empleados guardados correctamente.";
                }
                catch (Exception ex)
                {
                    // En caso de error, la transacción se revertirá automáticamente
                    return $"Error al guardar empleados: {ex.Message}";
                }
            }
        }

        public string GuardarEmpleado(Empleado empleado)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    // Validaciones de negocio
                    if (empleado.ApellidoNombre.Length <= 5)
                        throw new Exception("El nombre debe tener más de 5 caracteres.");
                    if (empleado.DNI.Length != 11)
                        throw new Exception("El DNI debe tener 11 caracteres.");
                    if (empleado.SueldoBruto < 100000)
                        throw new Exception("El sueldo bruto no puede ser menor a 100000.");

                    // Inserta el empleado en la base de datos
                    empleadoData.InsertarEmpleado(empleado);

                    // Confirma la transacción si no hubo errores
                    scope.Complete();
                    return "Empleado guardado correctamente.";
                }
                catch (Exception ex)
                {
                    // En caso de error, la transacción se revertirá automáticamente
                    return $"Error al guardar empleado: {ex.Message}";
                }
            }
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleadoData.ObtenerEmpleados(); ;
        }
    }
}