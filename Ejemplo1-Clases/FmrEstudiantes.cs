using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1_Clases
{
    public partial class FmrEstudiantes : Form
    {
        public FmrEstudiantes()
        {
            InitializeComponent();
        }

        private void FmrEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar
            Alumno alumno = new Alumno();
            alumno.Id = textId.Text;
            alumno.Nombre = textNombre.Text;
            alumno.Direccion = textdirec.Text;
            alumno.Telf = texttelf.Text;
            alumno.Email = textemail.Text;
            alumno.Exp = textexp.Text;
            alumno.Tiulacion = texttitu.Text;

            Datos.Alumnos.Add(alumno);
            MessageBox.Show("Estudiante agregrado correctamente.", "Completado", MessageBoxButtons.OK);

            //limpiar
            textId.Text = "";
            textNombre.Text = "";
            textdirec.Text = "";
            texttelf.Text = "";
            textemail.Text = "";
            textexp.Text = "";
            texttitu.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Principal = new Form1();
            Principal.ShowDialog();
            this.Close();
        }
    }
}
