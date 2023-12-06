using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
namespace negocio
{
    public class UsuarioNegocio
    {
        public bool loguear(Users usuario)
        {

            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("Select Id, TypeUser, Pass From User  Where Pass=@pass and Usuario=@usuario");
                acceso.setearParametro("@usuario", usuario.Usuario);
                acceso.setearParametro("@pass", usuario.Pass);
                acceso.ejecutarLectura();
                
                //si lee guardo.
                while (acceso.Lector.Read()) // mientras el lector de mi acceso lea, guardo, igual es una sola lectura
                {
                    //user y pass no  . Si el los ingresa XD
                    usuario.Id = (int)acceso.Lector["Id"];

                    usuario.Tipo = (int)(acceso.Lector["TypeUser"] )== 1 ? TypeUser.Normal : TypeUser.Admin;

                    return true; //porque existeeeeeeeeee
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConexion(); // IMPORTANTE NO OLVIDARR
            }



        }

    }
}
