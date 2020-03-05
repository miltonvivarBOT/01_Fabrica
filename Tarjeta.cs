using PatronFabrica.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica
{
    public class Tarjeta: ITipoPago
    {
        //ProductoA
        public bool ValidarImporte(decimal dImporte)
        {
            if (dImporte > 5000)
                return true;
            else
                return false;
        }
    }
}
