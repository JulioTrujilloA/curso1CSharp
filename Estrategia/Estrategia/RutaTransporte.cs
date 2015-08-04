using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrategia
{
    public class RutaTransporte
    {
        private EstrategiaTransporte estrategia;
        private string tiempo;

        public RutaTransporte(String tiempo)
        {
            this.tiempo = tiempo;
        }

        public void SetEstrategia(EstrategiaTransporte estrategia)
        {
            this.estrategia = estrategia;
        }

        public void Ejecutar()
        {
            estrategia.Ruta();
        }
    }
}
