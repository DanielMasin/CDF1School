using CDF1SchoolShopEN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDF1SchoolShopDAL
{
    public class VentasDAL
    {
        private static List<VentasEN> ListVentasEN = new List<VentasEN>();

        public void GuardarVentasEN(VentasEN pVentasEN)
        {
            pVentasEN.id = ListVentasEN.Select(ListVentasEN => ListVentasEN.id).DefaultIfEmpty(0).Max() + 1;
            ListVentasEN.Add(pVentasEN);
        }
        public List<VentasEN> ObtenerTodosVentasEN()
        {
            return ListVentasEN;
        }
    }
}

