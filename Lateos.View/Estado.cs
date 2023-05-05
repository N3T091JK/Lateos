using MetroFramework.Controls;
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
    public partial class Estado : Form
    {
        private List<Estado> _Listado;
        public Estado()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Estado_Load(object sender, EventArgs e)
        {
            //UpdateGrip();
        }
        /*
        private void UpdateGrip()
        {
            _Listado = Estado.Intance.SelectAll();
            var query = from x in _Listado
                        select new
                        {
                            id = x.id
                           nombre = x.Nombre
                         estado = x.estado.Nombre
                        }
                       dataGrip.Datasource = query.ToList();



        }
        */

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
