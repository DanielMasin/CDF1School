using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopDAL;
using CDF1SchoolShopEN;

namespace CDF1SchoolShopBL
{
    public class AgregarProductoBL
    {
        private AgregarProductoDAL AgregarProductoDAL = new AgregarProductoDAL();

        public void GuardarAgregarProductoEN(AgregarProductoEN pAgregarProductoEN)
        {
            AgregarProductoDAL.GuardarAgregarProductoEN(pAgregarProductoEN);
        }
        public List<AgregarProductoEN> ObtenerTodoAgregarProductoEN()
        {
            return AgregarProductoDAL.ObtenerTodoAgregarProductoEN();
        }
    }
}
