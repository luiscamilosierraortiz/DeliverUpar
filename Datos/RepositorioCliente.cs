using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace Datos
{
    public class RepositorioCliente
    {
        string archivo = @"Cliente.txt";
        public string GuardarCliente(Cliente cliente)
        {
            try
            {

                StreamWriter escritor = new StreamWriter(archivo, true);
                escritor.WriteLine(cliente.Linea());
                escritor.Close();
                return "Se han guardado los datos";
            }
            catch (Exception)
            {
                return "ERROR...No se han guardado los datos";
            }

        }
        public Cliente BuscarCliente(string identificacion)
        {
            List<Cliente> clientes = ConsultaGeneral();
            foreach (var item in clientes)
            {
                if (Encontrar(item.IdCliente, identificacion))
                {
                    return item;
                }
            }
            return null;
        }
        public string Modificar(List<Cliente> clientes)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(archivo, false);
                foreach (var item in clientes)
                {
                    escritor.WriteLine(item.Linea());
                }
                escritor.Close();
                return "Se han modificado los datos";
            }
            catch (Exception)
            {
                return "ERROR...NO Se han modificado los datos";
            }
        }
        public List<Cliente> ConsultaGeneral()
        {
            List<Cliente> clientes = new List<Cliente>();

            StreamReader lector = new StreamReader(archivo);
            string linea = string.Empty;
            while (!lector.EndOfStream)
            {
                linea = lector.ReadLine();
                Cliente cliente = new Cliente(linea);
                clientes.Add(cliente);
            }
            lector.Close();

            return clientes;
        }

        private bool Encontrar(string IdClienteRegistrado, string IdClienteBuscado)
        {
            return IdClienteRegistrado == IdClienteBuscado;
        }
        public List<Cliente> GetAll()
        {
            try
            {
                List<Cliente> cliente = new List<Cliente>();
                StreamReader sr = new StreamReader(archivo);
                while (!sr.EndOfStream)
                {
                    cliente.Add(Mapper(sr.ReadLine()));
                }
                sr.Close();
                return cliente;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public Cliente Mapper(string linea)
        {
            try
            {
                var cliente = new Cliente();
                cliente.IdCliente = linea.Split(';')[0];
                cliente. Fecha = linea.Split(';')[1];
                cliente.NombreRemitente = linea.Split(';')[2];
                cliente.NombreDestinatario = linea.Split(';')[3];
                cliente.IdentificacionDestinatario = linea.Split(';')[4];
                cliente.IdentificacionRemitente = linea.Split(';')[5];
                cliente.DireccionRemitente = linea.Split(';')[6];
                cliente.DireccionDestinatario = linea.Split(';')[7];
                cliente.CodPostalDestino = linea.Split(';')[8];
                cliente.CodPostalRemision = linea.Split(';')[9];
                cliente.CiudadRemitente = linea.Split(';')[10];
                cliente.CiudadDestinatario = linea.Split(';')[11];
                cliente.CelularDestinatario = linea.Split(';')[12];
                cliente.CelularRemitente = linea.Split(';')[13];
                return cliente;

            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
