using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDF1SchoolShopEN;
using CDF1SchoolShopDAL;


namespace CDF1SchoolShopBL
{
    public class ComprasBL
    {
        public void AgregarCompra(string Producto, int Cantidad, string Proveedor, string costo)
        {
            // Aquí puedes aplicar lógicas de negocio, como validaciones o cálculos
            ComprasDAL.AgregarCompra(Producto, Cantidad, Proveedor, costo);
        }


    }
}
