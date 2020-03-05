using PatronFabrica.Fabrica;
using PatronFabrica.Interfaces;
using System;

namespace PatronFabrica
{
    class Principal
    {
        static void Main(string[] args)
        {

            string conceptoPedido = "";
            decimal importePedido = 0M;
            int tipoPago = 0;
            string ctipoPago = "";
            
            ITipoPagoFactory objTipoPagoFactory = null;
            IProcesarPedido Pedidos = null;

            Console.WriteLine("Ingresa el concepto del pedido");
            conceptoPedido = Console.ReadLine();
            Console.WriteLine("Ingresa el importe del pedido");
            importePedido = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Tipo de Pago.\n1) Efectivo \n2) Tarjeta");
            tipoPago = Convert.ToInt32(Console.ReadLine());

            switch (tipoPago)
            {
                case 1:
                    objTipoPagoFactory = new GeneradorEfectivo();
                    ctipoPago = "efectivo";
                    break;
                case 2:
                    objTipoPagoFactory = new GeneradorTarjeta();
                    ctipoPago = "tarjeta";
                    break;
            }
            Pedidos = new ProcesadorPedido(objTipoPagoFactory, conceptoPedido, importePedido, ctipoPago);
            Pedidos.Procesar();
        }
    }
}
