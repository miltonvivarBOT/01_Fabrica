using PatronFabrica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    class ProcesadorPedido : IProcesarPedido
    {
        private readonly ITipoPagoFactory tipoPagoFactory;
        private readonly string conceptoPedido;
        private readonly decimal dImportePedido;
        private readonly string ctipoPago;

        public ProcesadorPedido(ITipoPagoFactory tipoPagoFactory, string conceptoPedido, decimal dImportePedido, string ctipoPago)
        {
            this.tipoPagoFactory = tipoPagoFactory;
            this.conceptoPedido = conceptoPedido;
            this.dImportePedido = dImportePedido;
            this.ctipoPago = ctipoPago;
        }
        public void Procesar()
        {
            string cMensajeAutorizado = "";
            bool lPagoAutorizado = false;

            var objProducto = this.tipoPagoFactory.GenerarInstanceTipoPago();
            lPagoAutorizado = objProducto.ValidarImporte(dImportePedido);
            cMensajeAutorizado = generaMensajeAutorizado(lPagoAutorizado);

            this.imprimeMensaje(
                this.generaMensaje(this.conceptoPedido, this.dImportePedido, this.ctipoPago, cMensajeAutorizado));
        }

        private string generaMensajeAutorizado(bool lPagoAutorizado)
        {
            if (lPagoAutorizado)
                return "autorizado";
            else
                return "rechazado";
        }

        private string generaMensaje(string conceptoPedido, decimal dImportePedido, string mensajeTipoPago, string mensajeAutorizado)
        {
            string cMensaje = string.Format("Pago {0} con importe de {1} en {2} fue {3}.",
                                conceptoPedido, dImportePedido, mensajeTipoPago, mensajeAutorizado);
            return cMensaje;
        }
        private void imprimeMensaje(string cMensaje)
        {
            Console.WriteLine(cMensaje);
        }

    }
}
