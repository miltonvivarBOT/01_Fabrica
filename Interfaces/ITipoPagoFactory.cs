using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica.Interfaces
{
    //Creador
    public interface ITipoPagoFactory
    {
        ITipoPago GenerarInstanceTipoPago();
    }
}
