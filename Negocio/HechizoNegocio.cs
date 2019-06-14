using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;


namespace Negocio
{
    public class HechizoNegocio
    {
        public List<Hechizo> listarHechizos()
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            List<Hechizo> listado = new List<Hechizo>();
            Hechizo nuevo;
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM HECHIZOS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    nuevo = new Hechizo();
                    nuevo.HechizoVencedor = new Hechizo();
                    nuevo.ID = accesoDatos.Lector.GetInt32(0);
                    nuevo.Nombre = accesoDatos.Lector.GetString(1);
                    nuevo.Descripción = accesoDatos.Lector.GetString(2);
                    nuevo.HechizoVencedor.ID = accesoDatos.Lector.GetInt32(3);
                    agregarHechizoV(nuevo);

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

        public void agregarHechizo(Mago mago, Hechizo hechizo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("INSERT INTO HECHIZOSMAGOS (IDMAGO, IDHECHIZO) VALUES ("+ mago.ID+", "+ hechizo.ID+")");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();
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

        public List<Hechizo> listarHechizosXMago(Mago mago)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            List<Hechizo> listado = new List<Hechizo>();
            Hechizo nuevo;
            try
            {
                accesoDatos.setearConsulta("SELECT H.Id, H.Nombre, H.Descripcion, H.IdHechizoQueLoVence FROM HECHIZOSMAGOS AS HM INNER JOIN HECHIZOS AS H ON H.Id = HM.IdHechizo WHERE IdMago = " + mago.ID);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    nuevo = new Hechizo();
                    nuevo.HechizoVencedor = new Hechizo();
                    nuevo.ID = accesoDatos.Lector.GetInt32(0);
                    nuevo.Nombre = accesoDatos.Lector.GetString(1);
                    nuevo.Descripción = accesoDatos.Lector.GetString(2);
                    nuevo.HechizoVencedor.ID = accesoDatos.Lector.GetInt32(3);
                    agregarHechizoV(nuevo);

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

        private void agregarHechizoV(Hechizo nuevo)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("SELECT * FROM HECHIZOS where ID = " + nuevo.HechizoVencedor.ID);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    nuevo.HechizoVencedor.Nombre = accesoDatos.Lector.GetString(1);
                    nuevo.HechizoVencedor.Descripción = accesoDatos.Lector.GetString(2);
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
