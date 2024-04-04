using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopEN;

namespace CDF1SchoolShopDAL
{
    public  class InventarioDAL
    {
        private static List<InventarioEN> ListInventarioEN = new List<InventarioEN>();

        public void GuardarInventarioEN(InventarioEN pInventarioEN)
        {
            pInventarioEN.Id = ListInventarioEN.Select(ListInventarioEN => ListInventarioEN.Id).DefaultIfEmpty(0).Max() + 1;
            ListInventarioEN.Add(pInventarioEN);
        }
        public List<InventarioEN> ObtenerTodosInventarioEN()
        {
            return ListInventarioEN;
        }
    }
}
