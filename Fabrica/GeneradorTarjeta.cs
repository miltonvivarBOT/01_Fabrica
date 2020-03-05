using PatronFabrica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica.Fabrica
{
    public class GeneradorTarjeta : ITipoPagoFactory
    {
        public ITipoPago GenerarInstanceTipoPago()
        {
            return new Tarjeta();
        }
    }
}
