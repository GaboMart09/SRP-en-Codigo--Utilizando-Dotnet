using System;

namespace myApp
{
    class Ifactura
    {
        static void Main(string[] args)
        {
            
            FacturaFactorizada facturaFactorizada = new FacturaFactorizada();
            IvaNormal ivanormal = new IvaNormal();
            facturaFactorizada.Codigo = "FAC-001";
            facturaFactorizada.FechaEmision = "2017-12-18";
            facturaFactorizada.Factura = 60.35;


            Console.WriteLine("Codigo-Factura = " + facturaFactorizada.Codigo);
            Console.WriteLine("Fecha de Emision = " + facturaFactorizada.FechaEmision);
            Console.WriteLine("Sub-Total = " + facturaFactorizada.Factura);
            Console.WriteLine("Iva=" + ivanormal.PorcentajeIvaNormal);
            Console.WriteLine("Precio Total = " + facturaFactorizada.CalcularTotal());

        }
    }
}
