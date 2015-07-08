using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class ModeloDecorador : Decorador
    {
        public ModeloDecorador(ComponenteGraficoVehiculo componente) : base(componente) { }

        protected void visualizaInformacionTecnica()
        {
            Console.WriteLine("Información técnica del modelo");
        }

        public override void visualiza()
        {
            base.visualiza();
            this.visualizaInformacionTecnica();
        }
    }
}
