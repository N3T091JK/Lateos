using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Lateos.View;


namespace Lateos.View
{
    public partial class Form2 : MetroForm
    {
        
        //private List<categoria> _Listado;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //updateGrid();
        }
        /*
        private void updateGrid()
        {
            _Listado = CategoriaBL.Instante.SellectAll();
            //Propiedad de navegacion 
            var query = from x in _Listado
                        select new
                        {
                            Id = x.Id,
                            Nombre = x.Nombre,
                            Estado = x.Estado.Nombre
                        };

            metroGrid1.DataSource = _Listado;
        }*/
    }
}
