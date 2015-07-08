using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    public class MarcaDecorador : Decorador
    {
        public MarcaDecorador(ComponenteGraficoVehiculo componente) : base(componente) { }

        protected void visualizaLogo()
        {
            Console.WriteLine("Logotipo de la marca");
        }

        public override void visualiza()
        {
            base.visualiza();
            this.visualizaLogo();
        }
    }
}
