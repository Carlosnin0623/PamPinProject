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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.Opacity = 0; // Iniciar el formulario invisible
        }

        private void Closelogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 3; // Intervalo en milisegundos
            timer.Tick += (s, ev) =>
            {
                if (this.Opacity < 1) // Incrementar opacidad hasta llegar al 100%
                {
                    this.Opacity += 0.05;
                }
                else
                {
                    timer.Stop(); // Detener el timer cuando se alcance el 100%
                }
            };
            timer.Start();
        }
    }
}
