using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public enum TypeUser
    {
        Normal = 1,
        Admin=2
            //va aca porque es aparte. pero de esta propia  
    }
    public class Users
    {       
        public Users(string usuario, string pass, bool admin)
        {
            Usuario = usuario;
            Pass = pass;
            Tipo = admin ? TypeUser.Admin : TypeUser.Normal;
        }
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }

        public TypeUser Tipo { get; set; }  

    }
}
