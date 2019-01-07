using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso
{
    public class DetalleFactura : Entity
    {
        
        [Required]
        public int Cantidad { get; set; }
        [Required]
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }
        public virtual Producto Producto { get; set; }
        [Required]
        [ForeignKey("CabeceraFactura")]
        public int IdCabeceraFactura { get; set; }
        public virtual CabeceraFactura CabeceraFactura { get; set; }
        public override string DisplayMember
        {
            get
            {
                return (Producto != null) ? Producto.Descripcion : string.Empty;
            }
            set
            {
                if (Producto != null)
                {
                    Producto.Descripcion = value;
                }
            }
        }
    }
}
