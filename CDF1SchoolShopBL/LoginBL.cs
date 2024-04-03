using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopDAL;
using CDF1SchoolShopEN;

namespace CDF1SchoolShopBL
{
    public class LoginBL
    {
        public static bool VerificarCredenciales(string nombreUsuario, string contra)
        {
            // Llamar al método de la capa de datos para verificar las credenciales
            return LoginDAL.VerificarCredenciales(nombreUsuario, contra);
        }
    }
}
