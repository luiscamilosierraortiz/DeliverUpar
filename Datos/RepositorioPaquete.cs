using Entidad;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioPaquete
    {
        string archivo = @"Paquete.txt";
        public string GuardarPaquete(Paquete paquete)
        {
            try
            {

                StreamWriter escritor = new StreamWriter(archivo, true);
                escritor.WriteLine(paquete.Linea());
                escritor.Close();
                return "Se han guardado el paquete para entregar";
            }
            catch (Exception)
            {
                return "ERROR...No se guardaron los datos";
            }

        }
        public Paquete BuscarPaquete(string idpaquete)
        {
            List<Paquete> paquete = ConsultaGeneral();
            foreach (var item in paquete)
            {
                if (Encontrar(item.IdPaquete, idpaquete))
                {
                    return item;
                }
            }
            return null;
        }
        public string Modificar(List<Paquete> paquete)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(archivo, false);
                foreach (var item in paquete)
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
        public List<Paquete> ConsultaGeneral()
        {
            List<Paquete> paquetes = new List<Paquete>();

            StreamReader lector = new StreamReader(archivo);
            string linea = string.Empty;
            while (!lector.EndOfStream)
            {
                linea = lector.ReadLine();
                Paquete paquete = new Paquete(linea);
                paquetes.Add(paquete);
            }
            lector.Close();

            return paquetes;
        }

        private bool Encontrar(string IdClienteRegistrado, string IdClienteBuscado)
        {
            return IdClienteRegistrado == IdClienteBuscado;
        }
    }
}
