using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Repartidor
    {
        public string IdPaquete { get; set; }
        public string IdCliente { get; set; }
        public string FechaRegistro { get; set; }
        public string TipoPaquete { get; set; }
        public string NombreRemitente { get; set; }
        public string NombreDestinatario { get; set; }

        public Repartidor(string idPaquete, string idCliente, string fechaRegistro, string tipoPaquete, string nombreRemitente, string nombreDestinatario)
        {
            IdPaquete = idPaquete;
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
            TipoPaquete = tipoPaquete;
            NombreRemitente = nombreRemitente;
            NombreDestinatario = nombreDestinatario;
        }
        public Repartidor()
        {

        }
    }
}
