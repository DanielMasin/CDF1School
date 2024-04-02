using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopEN;
using CDF1SchoolShopDAL;

namespace CDF1SchoolShopBL
{
    public class ProveedoresBL
    {
        private ProveedoresDAL ProveedoresDAL = new ProveedoresDAL();

        public void GuardarProveedoresEN(ProveedoresEN pProveedoresEN)
        {
            ProveedoresDAL.GuardarProveedoresEN(pProveedoresEN);
        }
        public List<ProveedoresEN> ObtenerTodosProveedoresEN()
        {
            return ProveedoresDAL.ObtenerTodosProveedoresEN();
        }
    }
}
