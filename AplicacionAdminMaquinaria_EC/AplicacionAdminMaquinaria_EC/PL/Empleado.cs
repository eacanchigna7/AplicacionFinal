using AplicacionAdminMaquinaria_EC.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionAdminMaquinaria_EC.DAL;

namespace AplicacionAdminMaquinaria_EC
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //intruccion GUI (Obtener informacion)
            RecuperarInfo();
            conexion conexion = new conexion();
            conexion.Pruebaconectar(); //bool
            MessageBox.Show("Conectado.." + conexion.Pruebaconectar());
        }
        private void RecuperarInfo()
        {
            EmpleadoBLL oempleado = new EmpleadoBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            oempleado.ID = ID;
            oempleado.Nombre = txtnombreemp.Text;
            oempleado.Cargo=txtCargoemp.Text;
            oempleado.Cedula = txtCedulaemp.Text;
            oempleado.Area=txtAreaemp.Text;

        }
    }
}
