using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioPaquete
    {
        List<Paquete> paquetes;
        RepositorioPaquete repositorio = new RepositorioPaquete();
        public ServicioPaquete()
        {
            paquetes = repositorio.ConsultaGeneral();
        }
        public string Guardado(Paquete paquete)
        {
            string mensaje = string.Empty;
            try
            {

                if (repositorio.BuscarPaquete(paquete.IdPaquete) == null)
                {
                    mensaje = repositorio.GuardarPaquete(paquete);
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
        public Paquete BuscarIdPaquete(string Idclient)
        {
            foreach (var item in paquetes)
            {
                if (item.IdCliente == Idclient)
                {
                    return item;
                }

            }
            return null;

        }
        public string Extraer(string idpaquete)
        {
            Paquete paquete = BuscarIdPaquete(idpaquete);
            if (paquete == null)
            {
                return "El paquete ingresado, no ha sido encontrado";
            }
            else
            {
                paquetes.Remove(paquete);

                repositorio.Modificar(paquetes);
                return "El paquete ha sido entregado";
            }
        }
        public List<Paquete> Consultar()
        {
            return paquetes;
        }
        private void Actualizado()
        {
            paquetes = repositorio.ConsultaGeneral();
        }
    }
}
