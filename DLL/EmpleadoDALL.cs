using Emptity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class EmpleadoDALL
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ConnectionEmpleados"].ConnectionString;

        public void InsertarEmpleado(Empleado empleado)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Empleados (ApellidoNombre, DNI, SueldoBruto) VALUES (@ApellidoNombre, @DNI, @SueldoBruto)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApellidoNombre", empleado.ApellidoNombre);
                    command.Parameters.AddWithValue("@DNI", empleado.DNI);
                    command.Parameters.AddWithValue("@SueldoBruto", empleado.SueldoBruto);
                    command.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener la lista de empleados en la base de datos
        public List<Empleado> ObtenerEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            string query = "SELECT ApellidoNombre, DNI, SueldoBruto,FechaRegistro FROM Empleados";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            empleados.Add(new Empleado
                            {
                                ApellidoNombre = reader["ApellidoNombre"].ToString(),
                                DNI = reader["DNI"].ToString(),
                                SueldoBruto = Convert.ToDouble(reader["SueldoBruto"]),
                                FechaRegistro = (DateTime)reader["FechaRegistro"]
                            });
                        }
                    }
                }
            }
            return empleados;
        }
    }
}
