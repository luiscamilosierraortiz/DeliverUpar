using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmLIstaCliente : Form
    {
        public FrmLIstaCliente()
        {
            InitializeComponent();
        }
        ServicioCliente servicio = new ServicioCliente();
        private void FrmLIstaCliente_Load(object sender, EventArgs e)
        {
            Cargar();
        }
        void Cargar()
        {
            dataTable.DataSource = servicio.GetAll();
        }
    }
}
