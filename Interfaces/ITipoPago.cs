using System;
using System.Collections.Generic;
using System.Text;

namespace PatronFabrica.Interfaces
{
    public interface ITipoPago
    {
        //Producto
        bool ValidarImporte(decimal dImporte);
    }
}
