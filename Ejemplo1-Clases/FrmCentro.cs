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
    public partial class FrmCentro : Form
    {

        private List<Centro> listaCentros = new List<Centro>();

        public FrmCentro()
        {
            InitializeComponent();
        }
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //agregar
            Centro centro = new Centro();
            centro.Nombre = textBox1.Text;
            centro.Dir = textBox2.Text;
            centro.Telf = textBox3.Text;
            centro.Email = textBox4.Text;

            Datos.Centros.Add(centro);

            MessageBox.Show("Centro agregrado correctamente.", "Confirmar", MessageBoxButtons.OK);

            //Limpiar

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Principal = new Form1();
            Principal.ShowDialog();
            this.Close();
        }

        private void FrmCentro_Load(object sender, EventArgs e)
        {

        }
    }
}
