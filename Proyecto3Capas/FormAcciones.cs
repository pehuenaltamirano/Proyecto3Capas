using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3Capas
{
    public partial class FormAcciones : Form
    {
        public int id,op;
        public FormAcciones(int id1,int op1)
        {
            InitializeComponent();
            id = id1;
            op = op1;


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Logica.Empleados.Insert(txtNombre.Text,txtApellido.Text,txtCuil.Text,Convert.ToInt32(txtDni.Text),txtDomicilio.Text,txtTelefono.Text,txtLegajo.Text,txtEmail.Text);
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Logica.Empleados.Modificar(id, txtNombre.Text, txtApellido.Text, txtCuil.Text, Convert.ToInt32(txtDni.Text), txtDomicilio.Text, txtTelefono.Text, txtLegajo.Text, txtEmail.Text);
            this.Close();
        }

        private void FormAcciones_Load(object sender, EventArgs e)
        {
            if (op == 1)
            {
                lblModificar.Visible = false;
                btnModificar.Visible = false;
                lblID.Visible = false;

            }
            if (op == 2)
            {
                lblAgregar.Visible = false;
                btnAgregar.Visible = false;
                lblID.Text = Convert.ToString(id);
            }


        }
    }
}
