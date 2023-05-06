using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Paquete
    {
        public string IdPaquete { get; set; }
        public string IdCliente { get; set; }
        public string FechaRegistro { get; set; }
        public string TipoPaquete { get; set; }
        public string DimensionPaquete { get; set; }
        public string PesoPaquete { get; set; }
        public string Descripcion { get; set; }
        
        public Paquete(string idPaquete, string idCliente, string fechaRegistro, string tipoPaquete, string dimensionPaquete, string pesoPaquete, string descripcion)
        {
            IdPaquete = idPaquete;
            IdCliente = idCliente;
            FechaRegistro = fechaRegistro;
            TipoPaquete = tipoPaquete;
            DimensionPaquete = dimensionPaquete;
            PesoPaquete = pesoPaquete;
            Descripcion = descripcion;
            
        }
        public Paquete()
        {

        }

        public Paquete(string linea)
        {
            if (linea != null)
            {
                Mapear(linea);
            }
        }
        private void Mapear(string Linea)
        {
            IdPaquete = Linea.Split(';')[0];
            IdCliente = Linea.Split(';')[1];
            FechaRegistro = Linea.Split(';')[2];
            TipoPaquete = Linea.Split(';')[3];
            DimensionPaquete = Linea.Split(';')[4];
            PesoPaquete = Linea.Split(';')[5];
            Descripcion = Linea.Split(';')[6];
            
        }
        public string Linea()
        {
            return IdPaquete + ";" + IdCliente + ";" + FechaRegistro + ";" + TipoPaquete + ";" +
                DimensionPaquete + ";" + PesoPaquete + ";" + Descripcion;
        }
    }
}
