using BLL;
using Emptity;

namespace ActividadItinerario10
{
    public partial class Form1 : Form
    {
        private EmpleadoBLL empleadoBusiness = new EmpleadoBLL();
        private List<Empleado> listaBorradorEmpleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string dni = txtDNI.Text;
                double sueldoBruto = double.Parse(txtSueldoBruto.Text);

                Empleado empleado = new Empleado
                {
                    ApellidoNombre = nombre,
                    DNI = dni,
                    SueldoBruto = sueldoBruto
                };

                listaBorradorEmpleados.Add(empleado);
                MessageBox.Show("Empleado agregado al borrador.");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaBorradorEmpleados.Count > 0)
                {
                    string resultado = empleadoBusiness.GuardarEmpleados(listaBorradorEmpleados);
                    MessageBox.Show(resultado);

                    // Limpia la lista de borrador después de la confirmación
                    listaBorradorEmpleados.Clear();
                }
                else
                {
                    MessageBox.Show("No hay empleados en el borrador para confirmar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListarEmpleados();
        }

        private void ListarEmpleados()
        {
            try
            {
                List<Empleado> empleados = empleadoBusiness.ObtenerEmpleados();
                dataGridView1.DataSource = empleados;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al listar empleados: {ex.Message}");
            }
        }
    }
    }

