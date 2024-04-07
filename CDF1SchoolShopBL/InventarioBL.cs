using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopEN;
using CDF1SchoolShopDAL;

namespace CDF1SchoolShopBL
{
    public class InventarioBL
    {
        private InventarioDAL InventarioDAL = new InventarioDAL();

        public void GuardarInventarioEN(InventarioEN pInventarioEN)
        {
            InventarioDAL.GuardarInventarioEN(pInventarioEN);
        }
        public List<InventarioEN> ObtenerTodosInventarioEN()
        {
            return InventarioDAL.ObtenerTodosInventarioEN();
        }
    }
}
