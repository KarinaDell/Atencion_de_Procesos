using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atencion_de_procesos
{
    class Procesador
    {
        Proceso proceso;
        private Proceso inicio = null;
        static Random rnd = new Random();
        private int cont = 1, vacio, completo, ultimo, ciclo;
        private int ciclos = 300;

        public int Vacio { get => vacio; }
        public int Completo { get => completo; }
        public int Ultimo { get => ultimo; }
        public int Ciclo { get => ciclo; }


        public void Agregar(Proceso nuevo)
        {
            if (inicio == null)
            {
                inicio = nuevo;
                inicio.sig = inicio;
            }
            else
                agregarRecursivo(nuevo, inicio.sig);
        }

        private void agregarRecursivo(Proceso nuevo, Proceso t)
        {
            if (t.sig == inicio)
            {
                t.sig = nuevo;
                nuevo.sig = inicio;
                inicio = inicio.sig;
            }
            else
                agregarRecursivo(nuevo, t.sig);
        }

        public void iniciarProcesador()
        {
            while (ciclos > 0)
            {
                int r = rnd.Next(1, 101);
                if (r <= 35)
                {
                    Agregar(new Proceso(cont++, rnd.Next(4, 15)));
                        eliminarPrimero();
                }
                else if (inicio != null)
                    eliminarPrimero();
                else
                        vacio++;
                    ciclos--;
            }
            //completo = inicio.Cuantos - 1;
            ultimo = procesosPendientes(inicio);// - completo;
        }


        public void eliminarPrimero()
        {
            inicio.Duracion--;
            if (inicio.Duracion == 0)
            {
                if (inicio.sig == inicio)
                {
                    inicio = null;
                    completo++;
                }
                else
                    eliminarPrimeroRecursivo(inicio.sig);
            }
        }

        private void eliminarPrimeroRecursivo(Proceso t)
        { 
            if (t.sig == inicio)
            {
                inicio = inicio.sig;
                t.sig = inicio;
                completo++;
            }
            else
                 eliminarPrimeroRecursivo(t.sig);
        }

        private int procesosPendientes(Proceso t)
        {
            if (t.sig == null)
                return 1;
            else
                return 1 + procesosPendientes(t.sig);
        }

        public int ciclosPendientes()
        {
            if (inicio == null)
                return 0;
            else if (inicio.sig == null)
                return inicio.Duracion;
            else
                return ciclosPendientesR(inicio);
        }

        public int ciclosPendientesR(Proceso t)
        {
            if (t.sig == null)
                return t.Duracion;
            else
                return t.Duracion + ciclosPendientesR(t.sig);
        }
    }
}
