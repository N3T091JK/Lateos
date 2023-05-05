using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace Lateos.View
{
    public partial class frmNuevo : MetroForm
    {
        
        public frmNuevo()
        {
            InitializeComponent();
        }

        private void frmNuevo_Load(object sender, EventArgs e)
        {
           // updateCombo();
        }
        /*
        private void updateCombo()
        {
            metroComboBox1.DisplayMember = "Nombre";
            metroComboBox1.ValueMember = "IdEstado";
            metroComboBox1.DataSource = EstadoBL.Instance.SellectAll();
        }  */
    }
      
}
