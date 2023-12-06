using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
namespace negocio
{
    public class TraineeNegocio
    {
       public  int insertar(Trainee trainee)
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
    }
}
