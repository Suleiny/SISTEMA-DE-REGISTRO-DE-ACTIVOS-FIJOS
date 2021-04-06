using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebaaa
{
    public partial class Form4 : Form
    {
        private Datos dat = new Datos();

        string marca, modelo, cantidad, precioI, precioA, propt, fechaI, año, codigo;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = carcodigo.Text;
                marca = carMarca.Text;
                modelo = carmodelo.Text;
                cantidad = carcantidad.Text;
                año = caryeard.Text;
                precioI = valor1.Text;
                precioA = valor2.Text;
                propt = carpropietarios.Text;
                fechaI = carfecha.Text;


                MessageBox.Show("Registrando activo...");
            }
            catch
            {
                MessageBox.Show("Revisar datos insertados");

            }
            finally
            {

                MessageBox.Show("Registro de activo Exitoso!!..");

            }

            dat.CARROS(codigo, marca, modelo, año, cantidad, precioI, precioA, fechaI, propt);
        }
        
        public Form4()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {


            


         
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
        }
    }
}
