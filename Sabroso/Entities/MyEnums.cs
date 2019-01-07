using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sabroso
{
    public enum Categoria
    {
        [CustomAttribute(1, "Producto Terminado")]
        ProductoTerminado,
        [CustomAttribute(2, "Plato")]
        Plato,
        [CustomAttribute(3, "Jugo")]
        Jugo,
        [CustomAttribute(4, "Comida Rapida")]
        ComidaRapida,
        [CustomAttribute(5, "Insumo")]
        Insumo
    }

    public enum Status
    {
        [CustomAttribute(1, "Activo")]
        Activo,
        [CustomAttribute(2, "Inactivo")]
        Inactivo
        
    }

}
