using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopEN;

namespace CDF1SchoolShopDAL
{
    public class AgregarProductoDAL
    {
        private static List<AgregarProductoEN> ListAgregarProductoEN = new List<AgregarProductoEN>();

        public void GuardarAgregarProductoEN(AgregarProductoEN pAgregarProductoEN)
        {
            pAgregarProductoEN.Id = ListAgregarProductoEN.Select(ListAgregarProductoEN => ListAgregarProductoEN.Id).DefaultIfEmpty(0).Max() + 1;
            ListAgregarProductoEN.Add(pAgregarProductoEN);
        }
        public List<AgregarProductoEN> ObtenerTodoAgregarProductoEN()
        {
            return ListAgregarProductoEN;
        }
    }
}
