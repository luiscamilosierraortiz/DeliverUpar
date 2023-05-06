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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace Presentacion
{
    public partial class FrmCliente : Form
    {
        ServicioCliente ServicioCliente = new ServicioCliente();
        Cliente cliente = new Cliente();
        public FrmCliente()
        {
            InitializeComponent();
        }
        void Guardar()
        {
            cliente.IdCliente = txtID.Text;
            cliente.Fecha = dateTime.Text;
            cliente.NombreDestinatario = txtNombreDestinatario.Text;
            cliente.IdentificacionDestinatario = txtIdentificacionDestinatario.Text;
            cliente.DireccionDestinatario = txtDireccionDestinatario.Text;
            cliente.CodPostalDestino = txtCodPostalDestinatario.Text;
            cliente.CiudadDestinatario = txtCiudadDestinatario.Text;
            cliente.CelularDestinatario = txtTelefonoDestinatario.Text;
            cliente.NombreRemitente = txtNombreRemitente.Text;
            cliente.IdentificacionRemitente = txtIdentificacionRemitente.Text;
            cliente.DireccionRemitente = txtDireccionRemitente.Text;
            cliente.CodPostalRemision = txtCodPostalRemitente.Text;
            cliente.CiudadRemitente = txtCiudadRemitente.Text;
            cliente.CelularRemitente = txtTelefonoRemitente.Text;

            string mensaje;
            mensaje = ServicioCliente.Guardado(cliente);
            MessageBox.Show(mensaje);

        }
        void Limpiado()
        {
            txtID.Clear();
            txtNombreDestinatario.Clear();
            txtIdentificacionDestinatario.Clear();
            txtDireccionDestinatario.Clear();
            txtCodPostalDestinatario.Clear();
            txtCiudadDestinatario.Clear();
            txtTelefonoDestinatario.Clear();
            txtNombreRemitente.Clear();
            txtIdentificacionRemitente.Clear();
            txtDireccionRemitente.Clear();
            txtCodPostalRemitente.Clear();
            txtCiudadRemitente.Clear();
            txtTelefonoRemitente.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }
            FrmPaquete frmPaquete = new FrmPaquete();
            frmPaquete.txtIdPaquete.Text = txtID.Text;
            frmPaquete.txtIdCliente.Text = txtID.Text;
            frmPaquete.ShowDialog();
            Guardar();
            Limpiado();
        }
        void Buscar(string id)
        {
            ServicioCliente servicio = new ServicioCliente();
            Cliente cliente;
            cliente = servicio.BuscarIdCliente(id);
            if (cliente == null)
            {
                MessageBox.Show("No se encuentra el cliente en nuestro sistema");
                return;
            }
            MostrarCliente(cliente);
        }
        void MostrarCliente(Cliente cliente)
        {
            txtID.Text = cliente.IdCliente;
            dateTime.Text = cliente.Fecha;
            txtNombreDestinatario.Text = cliente.NombreDestinatario;
            txtIdentificacionDestinatario.Text = cliente.IdentificacionDestinatario;
            txtDireccionDestinatario.Text = cliente.DireccionDestinatario;
            txtCodPostalDestinatario.Text = cliente.CodPostalDestino;
            txtCiudadDestinatario.Text = cliente.CiudadDestinatario;
            txtTelefonoDestinatario.Text = cliente.CelularDestinatario;
            txtNombreRemitente.Text = cliente.NombreRemitente;
            txtIdentificacionRemitente.Text = cliente.IdentificacionRemitente;
            txtDireccionRemitente.Text = cliente.DireccionRemitente;
            txtCodPostalRemitente.Text = cliente.CodPostalRemision;
            txtCiudadRemitente.Text = cliente.CiudadRemitente;
            txtTelefonoRemitente.Text = cliente.CelularRemitente;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Buscar(txtID.Text);
        }

        private void txtIdentificacionRemitente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
