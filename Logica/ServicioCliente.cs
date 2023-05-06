using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidad;

namespace Logica
{
    public class ServicioCliente
    {
        List<Cliente> clientes;
        RepositorioCliente repositorio = new RepositorioCliente();
        public ServicioCliente()
        {
            clientes = repositorio.ConsultaGeneral();
        }
        public string Guardado(Cliente cliente)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositorio.BuscarCliente(cliente.IdCliente) == null)
                {
                    mensaje = repositorio.GuardarCliente(cliente);
                    Actualizado();
                    return mensaje;
                }
                return mensaje;
            }
            catch (Exception e)
            {
                return "ERROR: " + e.Message;
            }
        }
        public List<Cliente> Consultar()
        {
            return clientes;
        }
        public Cliente BuscarIdCliente(string Idclient)
        {
            foreach (var item in clientes)
            {
                if (item.IdCliente == Idclient)
                {
                    return item;
                }

            }
            return null;

        }
        public string Extraer(string identificacion)
        {
            Cliente cliente = BuscarIdCliente(identificacion);
            if (cliente == null)
            {
                return "El cliente ingresado, no ha sido encontrado";
            }
            else
            {
                clientes.Remove(cliente);

                repositorio.Modificar(clientes);
                return "El Paquete Listo";
            }
        }
        public List<Cliente> GetAll()
        {
            clientes = repositorio.GetAll();
            return clientes;
        }
        private void Actualizado()
        {
            clientes = repositorio.ConsultaGeneral();
        }

    }
}
