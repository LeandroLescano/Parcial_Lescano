using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;

namespace Negocio
{
    public class MagoNegocio
    {
        public List<Mago> listarMagos()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            List<Mago> listado = new List<Mago>();
            Mago nuevo;
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM MAGOS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    nuevo = new Mago();
                    nuevo.Casa = new Casa();
                    nuevo.ID = accesoDatos.Lector.GetInt32(0);
                    nuevo.Nombre = accesoDatos.Lector.GetString(1);
                    nuevo.Casa.ID = accesoDatos.Lector.GetInt32(2);
                    agregarCasa(nuevo);
                    listado.Add(nuevo);
                }
                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        private void agregarCasa(Mago mago)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM CASAS WHERE ID = " + mago.Casa.ID);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    mago.Casa.Descripcion = accesoDatos.Lector.GetString(1);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

    }
}
