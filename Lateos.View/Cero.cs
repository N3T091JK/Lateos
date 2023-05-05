using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lateos.View
{
    public partial class Cero : Form
    {
        public Cero()
        {
            InitializeComponent();
        }

   

        


        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
Login frm = new Login();
            frm.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresa frm = new Empresa();
            frm.ShowDialog();
        }

        private void rolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rol frm = new Rol();
            frm.ShowDialog();
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estado frm = new Estado();
            frm.ShowDialog();
        }

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroAgregar frm = new RegistroAgregar();
            frm.ShowDialog();
        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura frm = new Factura();
            frm.ShowDialog();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario frm = new Usuario();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cliente frm = new Cliente();
            frm.ShowDialog();
        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empleado frm = new Empleado();
            frm.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Producto frm = new Producto();
            frm.ShowDialog();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteBuscar frm = new ClienteBuscar();
            frm.ShowDialog();
        }
    }
}
