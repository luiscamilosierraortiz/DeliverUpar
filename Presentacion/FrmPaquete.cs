using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidad;

namespace Presentacion
{
    public partial class FrmPaquete : Form
    {
        ServicioPaquete servicio = new ServicioPaquete();
        Paquete paquete = new Paquete();
        public FrmPaquete()
        {
            InitializeComponent();
        }
        FrmCliente FrmCliente;
        void GuardarPaquete()
        {
            paquete.IdPaquete = txtIdPaquete.Text;
            paquete.IdCliente = txtIdCliente.Text;
            paquete.FechaRegistro = dateTime.Text;
            paquete.TipoPaquete = cbxTipoPaquete.Text;
            paquete.PesoPaquete = txtPesoPaquete.Text;
            paquete.DimensionPaquete = txtDimensionPaqute.Text;
            paquete.Descripcion = txtDescripcionPaquete.Text;

            string guaradado;
            guaradado = servicio.Guardado(paquete);
            MessageBox.Show(guaradado);
            this.Close();
        }

        private void btnRegistrarPaquete_Click(object sender, EventArgs e)
        {
            GuardarPaquete();
        }
    }
}
