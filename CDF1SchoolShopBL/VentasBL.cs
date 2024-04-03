using CDF1SchoolShopDAL;
using CDF1SchoolShopEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDF1SchoolShopBL
{
    public  class VentasBL
    {
        private VentasDAL VentasDAL = new VentasDAL();

        public void GuardarVentasEN(VentasEN pVentasEN)
        {
            VentasDAL.GuardarVentasEN(pVentasEN);
        }
        public List<VentasEN> ObtenerTodosVentasEN()
        {
            return VentasDAL.ObtenerTodosVentasEN();
        }
    }
}
