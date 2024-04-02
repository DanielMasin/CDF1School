using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopEN;

namespace CDF1SchoolShopDAL
{
    public class ProveedoresDAL
    {
        private static List<ProveedoresEN> ListProveedoresEN = new List<ProveedoresEN>();

        public void GuardarProveedoresEN(ProveedoresEN pProveedoresEN)
        {
            pProveedoresEN.Id = ListProveedoresEN.Select(ListProveedoresEN => ListProveedoresEN.Id).DefaultIfEmpty(0).Max() + 1;
            ListProveedoresEN.Add(pProveedoresEN);
        }
        public List<ProveedoresEN> ObtenerTodosProveedoresEN()
        {
            return ListProveedoresEN;
        }
    }
}
