using PatronFabrica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica.Fabrica
{
    public class GeneradorEfectivo : ITipoPagoFactory
    {
        public ITipoPago GenerarInstanceTipoPago()
        {
            return new Efectivo();
        }
    }
}
