using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_procesos
{
    class Proceso
    {
        private int numero;
        private int duracion;
        public Proceso sig;

        public int Numero { get => numero; set => numero = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public Proceso(int numero, int duracion)
        {
            this.numero = numero;
            this.duracion = duracion;
        }
    }
}
