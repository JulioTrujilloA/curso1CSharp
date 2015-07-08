using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo
{
    class VistaCatalago
    {
        static void Main(string[] args)
        {
            VistaVehiculo vistaVehiculo = new VistaVehiculo();
            ModeloDecorador modeloDecorador = new ModeloDecorador(vistaVehiculo);
            EspejoDecorador espejoDecorador = new EspejoDecorador(modeloDecorador);
            //MarcaDecorador marcaDecorador = new MarcaDecorador(modeloDecorador);

            espejoDecorador.visualiza();
            Console.ReadKey();
        }
    }
}
