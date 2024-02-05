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
    public partial class Maquinaria : Form
    {
        public Maquinaria()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //intruccion GUI (Obtener informacion)
            RecuperarInfo();
            conexion conexion = new conexion();
            conexion.Pruebaconectar(); //bool
            MessageBox.Show("Conectado.."+conexion.Pruebaconectar());

        }
        private void RecuperarInfo()
        {
            MaquinariaBLL omaquinaria = new MaquinariaBLL();
            int ID = 0; int.TryParse(txtID.Text, out ID);
            omaquinaria.ID = ID;
            omaquinaria.Serie = txtSerie.Text;
            omaquinaria.Descripcion = txtDescripcion.Text;
            omaquinaria.Estado = txtEstado.Text;




        }
    }
}
