using Entidad;
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
    public partial class FrmRepartidor : Form
    {
        public FrmRepartidor()
        {
            InitializeComponent();
        }
        Cliente cliente = new Cliente();
        Paquete paquete = new Paquete();
        ServicioPaquete servicioPaquete = new ServicioPaquete();
        ServicioCliente servicioCliente = new ServicioCliente();
        void MostrarCliente(Cliente cliente)
        {
            txtIdCliente.Text = cliente.IdCliente;
            //dateTime.Text = cliente.Fecha.ToString();
            txtNombreDestinatario.Text = cliente.NombreDestinatario;
            txtNombreRemitente.Text = cliente.NombreRemitente;
        }
        void BuscarCliente(string id)
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
        void MostrarPaquete(Paquete paquete)
        {
            cbxTipoPaquete.Text = paquete.TipoPaquete;
        }
        void ExtraerCliente()
        {
            if (cliente == null)
            {
                MessageBox.Show("No se encuentra el cliente en nuestro sistema");
                return;
            }
            string mensaje;
            mensaje = servicioCliente.Extraer(txtIdCliente.Text);

            MessageBox.Show(mensaje);

        }
        void EntregarPaquete()
        {
            if (paquete == null)
            {
                MessageBox.Show("No se encuentra el cliente en nuestro sistema");
                return;
            }
            string mensaje;
            mensaje = servicioPaquete.Extraer(txtIdPaquete.Text);

            MessageBox.Show(mensaje);

        }
        void Limpiar()
        {

        }
        void BuscarTipo(string id)
        {
            ServicioPaquete servicio = new ServicioPaquete();
            Paquete paquete;
            paquete = servicio.BuscarIdPaquete(id);
            if (paquete == null)
            {
                MessageBox.Show("No se encuentra el Tipo de Paquete en nuestro sistema");
                return;
            }
            MostrarPaquete(paquete);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarCliente(txtIdPaquete.Text);
            BuscarTipo(txtIdPaquete.Text);
        }

        private void btnRegistrarPaquete_Click(object sender, EventArgs e)
        {
            ExtraerCliente();
            EntregarPaquete();
        }
    }
}
