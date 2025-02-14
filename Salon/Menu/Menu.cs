using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Closemenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Metodo para abrir los formularios en el contenedor
        public void AbrirFormulario(Form formulario)
        {
            // Limpiar el panel antes de abrir un nuevo formulario
            if (Contenedormenu.Controls.Count > 0)
                Contenedormenu.Controls.RemoveAt(0);

            // Configurar el formulario para que no sea una ventana superior
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;

            // Añadir el formulario al panel
            Contenedormenu.Controls.Add(formulario);
            Contenedormenu.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            Usuarios empleados = new Usuarios();
            AbrirFormulario(empleados);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Servicios servicios = new Servicios();
            AbrirFormulario(servicios);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Clientes.Clientes clientes= new Clientes.Clientes();
            AbrirFormulario(clientes);
        }
    }
}
