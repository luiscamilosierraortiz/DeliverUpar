using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Cliente
    {
        public string IdCliente { get; set; }
        public string Fecha { get; set; }
        public string NombreRemitente { get; set; }
        public string NombreDestinatario { get; set; }
        public string IdentificacionDestinatario { get; set; }
        public string IdentificacionRemitente { get; set; }
        public string DireccionRemitente { get; set; }
        public string DireccionDestinatario { get; set; }
        public string CodPostalDestino { get; set; }
        public string CodPostalRemision { get; set; }
        public string CiudadRemitente { get; set; }
        public string CiudadDestinatario { get; set; }
        public string CelularDestinatario { get; set; }
        public string CelularRemitente { get; set; }

        public Cliente(string idCliente, string fecha, string nombreRemitente, string nombreDestinatario, string identificacionDestinatario, string identificacionRemitente, string direccionRemitente, string direccionDestinatario, string codPostalDestino, string codPostalRemision, string ciudadRemitente, string ciudadDestinatario, string celularDestinatario, string celularRemitente)
        {
            IdCliente = idCliente;
            Fecha = fecha;
            NombreRemitente = nombreRemitente;
            NombreDestinatario = nombreDestinatario;
            IdentificacionDestinatario = identificacionDestinatario;
            IdentificacionRemitente = identificacionRemitente;
            DireccionRemitente = direccionRemitente;
            DireccionDestinatario = direccionDestinatario;
            CodPostalDestino = codPostalDestino;
            CodPostalRemision = codPostalRemision;
            CiudadRemitente = ciudadRemitente;
            CiudadDestinatario = ciudadDestinatario;
            CelularDestinatario = celularDestinatario;
            CelularRemitente = celularRemitente;
        }
        public Cliente()
        {

        }
        public Cliente(string linea)
        {
            if (linea != null)
            {
                Mapear(linea);
            }

        }
       
        private void Mapear(string linea)
        {
            IdCliente = linea.Split(';')[0];
            Fecha = linea.Split(';')[1];
            NombreRemitente = linea.Split(';')[2];
            NombreDestinatario = linea.Split(';')[3];
            IdentificacionDestinatario = linea.Split(';')[4];
            IdentificacionRemitente = linea.Split(';')[5];
            DireccionRemitente = linea.Split(';')[6];
            DireccionDestinatario = linea.Split(';')[7];
            CodPostalDestino = linea.Split(';')[8];
            CodPostalRemision = linea.Split(';')[9];
            CiudadRemitente = linea.Split(';')[10];
            CiudadDestinatario = linea.Split(';')[11];
            CelularDestinatario = linea.Split(';')[12];
            CelularRemitente = linea.Split(';')[13];
        }
        
        public string Linea()
        {
            return IdCliente+ ";" + Fecha + ";" + NombreRemitente + ";" + NombreDestinatario
                + ";" + IdentificacionDestinatario + ";" + IdentificacionRemitente + ";" + DireccionRemitente + ";" + 
                ";" + DireccionDestinatario + ";" + ";" + CodPostalDestino + ";" + ";" + CodPostalRemision + ";"
                + ";" + CiudadRemitente + ";" + ";" + CiudadDestinatario + ";" + ";" + CelularDestinatario + ";"
                + ";" + CelularRemitente + ";";
        }
    }
}
