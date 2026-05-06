using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace proyecto
{
    //clase de pedidos
    public class pedido
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string cliente { get; set; }
        public string productos { get; set; }
        public string estado { get; set; }

        //creamos un  metódo que guarde los pedidos en un archivo de txt
        public static void archivoTxt()
        {
            foreach (var e in Datos.ListaPedidos)
            {
                string linea = e.id + " , " + e.fecha + " , " + e.cliente + " , " + e.productos + " , " + e.estado;
                File.AppendAllText("pedidos.txt", linea + Environment.NewLine);
            }
        }
    }
}