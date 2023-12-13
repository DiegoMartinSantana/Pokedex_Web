using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class TraineeNegocio
    {
        public int insertar(Trainee trainee)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSp("insertarNuevo");
                datos.setearParametro("@email", trainee.email);
                datos.setearParametro("@pass", trainee.pass);
                return datos.ejecutarScalar();



            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregarDatos(Trainee user)
        {
            AccesoDatos access = new AccesoDatos();
            try
            {

                access.setearConsulta("Update Users set urlImagenPerfil= @img ,nombre = @name ,apellido= @surname  where ID = @id ");
                access.setearParametro("@img", (object)user.imgPerfil ?? DBNull.Value); // el ?? pone en null el value si es nulo, porque es el DBnull que se guarda en una bd
                access.setearParametro("@name", user.nombre);
                access.setearParametro("@surname", user.apellido);
                access.setearParametro("@id", user.Id);



                access.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                access.cerrarConexion();
            }


        }
        public bool loguear(Trainee usuario)
        {

            AccesoDatos acceso = new AccesoDatos();

            try
            {
                acceso.setearConsulta("Select Id, Admin ,Email,Nombre,Apellido,urlImagenPerfil Pass From Users  Where Pass= @pass and Email= @email");
                acceso.setearParametro("@email", usuario.email);
                acceso.setearParametro("@pass", usuario.pass);
               
                acceso.ejecutarLectura();
  
                //si lee guardo.
                if (acceso.Lector.Read())
                {
                    {
                        // si es ese asigno el contenido
                        usuario.Id = (int)acceso.Lector["Id"];
                        usuario.admin = (bool)acceso.Lector["Admin"];
                        usuario.imgPerfil = (string)acceso.Lector["urlImagenPerfil"];
                        usuario.apellido = (string)acceso.Lector["Apellido"];
                        usuario.nombre = (string)acceso.Lector["Nombre"];
                        usuario.email = (string)acceso.Lector["Email"];
                        return true;
                    }
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
