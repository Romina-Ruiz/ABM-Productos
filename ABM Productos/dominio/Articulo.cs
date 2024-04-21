using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        
        public string Cod_Articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }


        public int Id_Marca { get; set; }
        public int Id_Categoria { get; set; }        
       
        
    }
}
