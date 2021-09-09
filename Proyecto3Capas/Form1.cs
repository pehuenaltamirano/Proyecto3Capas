using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto3Capas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= Logica.Empleados.Get();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAcciones fa = new FormAcciones(1,1);
            fa.ShowDialog();
            dataGridView1.DataSource = Logica.Empleados.Get();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormEliminar fe = new FormEliminar();
            fe.ShowDialog();
            dataGridView1.DataSource = Logica.Empleados.Get();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormAcciones fa = new FormAcciones(Convert.ToInt32(dataGridView1.SelectedCells[0].Value),2);
            fa.ShowDialog();
            dataGridView1.DataSource = Logica.Empleados.Get();

        }
    }
}
