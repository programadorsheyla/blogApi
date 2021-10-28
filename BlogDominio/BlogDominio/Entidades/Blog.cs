using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogDominio.Entidades
{
    public class Blog
    {
        public int Id { get; set; }
        public String Titulo { get; set; }
        public String Descripcion { get; set; }
        public String Fecha { get; set; }        
        public String Tipo { get; set; }
    }
}
