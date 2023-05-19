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
    public partial class FrmPersonales : Form
    {
        public FrmPersonales()
        {
            InitializeComponent();
        }

        private void FrmPersonales_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar
            Personal personal = new Personal();
            personal.Id = textid.Text;
            personal.Nombre = textnom.Text;
            personal.Direccion = textdirec.Text;
            personal.Telf = texttelf.Text;
            personal.Email = textemail.Text;
            personal.Unidad = textuni.Text;
            personal.Categoria = textcat.Text;


            Datos.Personanles.Add(personal);

            MessageBox.Show("Profesor agregrado correctamente.", "Completado", MessageBoxButtons.OK);

            //Limpiar

            textnom.Text = "";
            textdirec.Text = "";
            texttelf.Text = "";
            textemail.Text = "";
            textuni.Text = "";
            textcat.Text = "";
            textid.Text = "";


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
