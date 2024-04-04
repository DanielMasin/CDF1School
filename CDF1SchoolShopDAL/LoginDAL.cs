using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopEN;

namespace CDF1SchoolShopDAL
{
    public class LoginDAL
    {
        public static bool VerificarCredenciales(string nombreUsuario, string contra)
        {
           
            if (nombreUsuario == "Daniel" && contra == "Daniels45")
            {
                return true;
            }
            return false;
        }
    }
}
