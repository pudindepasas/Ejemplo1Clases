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
    public partial class FrmProfesores : Form
    {
        public FrmProfesores()
        {
            InitializeComponent();
        }

        private void FrmProfesores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar
            Profesor profesor = new Profesor();
            profesor.Id = textBox7.Text;
            profesor.Nombre = textBox1.Text;
            profesor.Direccion = textBox2.Text;
            profesor.Telf = textBox3.Text;
            profesor.Email = textBox4.Text;
            profesor.INSS = textBox5.Text;
            profesor.Salario = double.Parse(textBox6.Text);
            

            Datos.Profesores.Add(profesor);

            MessageBox.Show("Profesor agregrado correctamente.", "Completado", MessageBoxButtons.OK);

            //Limpiar

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Principal = new Form1();
            Principal.ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
