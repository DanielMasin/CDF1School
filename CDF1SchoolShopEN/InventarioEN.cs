using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CDF1SchoolShopEN
{
    //Arreglos para almacenar la informacion de productos de la mini tienda
    public class InventarioEN
    {
        public int id { get; set; }
        public string Codigo { get; set; }
        public string Preciounitario { get; set; }
        public int Marca { get; set; } 
        public string Producto { get; set; }
        public string Inversioneninventario { get; set; }
    }
}
