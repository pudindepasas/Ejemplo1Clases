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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCentro frmCentro = new FrmCentro();
            frmCentro.ShowDialog();
        }

        private void listaDeCentrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaCentros lista = new ListaCentros();
            lista.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProfesores frmProfesores = new FrmProfesores();
            frmProfesores.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaProfesores lista = new ListaProfesores();
            lista.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FmrEstudiantes fmrEstudiantes = new FmrEstudiantes();
            fmrEstudiantes.ShowDialog();
        }

        private void listaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaEstudiantes listaestudiantes = new ListaEstudiantes();
            listaestudiantes.ShowDialog();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmPersonales fmrPersonales = new FrmPersonales();
            fmrPersonales.ShowDialog();
        }

        private void listaDeTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaPersonales listaPersonales = new ListaPersonales();
            listaPersonales.ShowDialog();
        }
    }
}
