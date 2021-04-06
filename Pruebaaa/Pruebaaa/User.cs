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
    public partial class User : Form
    {

       private  Datos dat = new Datos();

        string nombre, apellido, genero, acad,  celular, telefono, direccion, fechan,cedula, email, trabajo ,estd;

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        public User()
        {
            InitializeComponent();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            Form formulario = new Formbienveida();
            formulario.Show();
        }

        private void guardar_Click(object sender, EventArgs e)
        {

            try
            {
                nombre = empnombre.Text;
                apellido = empapellido.Text;
                cedula = EmpCedula.Text;
                genero = sexo.Text;
                fechan = guna2TextBox3.Text;
                direccion = empldireccion.Text;
                email = empGmail.Text;
                celular = empltelf2.Text;
                telefono = emptelef.Text;
                acad = academico.Text;
                estd = estad.Text;
                trabajo = ocupacion.Text;

               

                MessageBox.Show("Registrando datos de usuarios...");
                Limpiar();
                
            } catch
            {
                MessageBox.Show("Revisar los datos");


            }
            finally
            {
                MessageBox.Show("Registro Exitoso...");

            }

            dat.USUARIOS(nombre, apellido, genero, cedula, celular, telefono, fechan, direccion, email, estd, trabajo, acad);

            DataG();



        }

        public void Limpiar()
        {
            foreach (Control tour in Controls)

            {
                if (tour is TextBox)
                {
                    tour.Text = "";
                }
            }


        }




        public void DataG()
        {
            guna2DataGridView1.DataSource = dat.DATOSUSUARIOS();
        }

    }
}
