using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Hechizo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripción { get; set; }
        public Hechizo HechizoVencedor { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
