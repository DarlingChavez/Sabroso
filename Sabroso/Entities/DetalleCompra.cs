using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso
{
    public class DetalleCompra : Entity
    {
        
        [Required]
        public int Cantidad { get; set; }
        [Required]
        public decimal PrecioUnitario { get; set; }
        [Required]
        public decimal Subtotal { get; set; }
        [Required]
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        [Required]
        [ForeignKey("CabeceraCompra")]
        public int IdCabeceraCompra { get; set; }
        public virtual CabeceraCompra CabeceraCompra { get; set; }

        //public override string DisplayMember
        //{
        //    get
        //    {
        //        return (Producto != null) ? Producto.Descripcion : string.Empty;
        //    }
        //    set
        //    {
        //        if (Producto != null)
        //        {
        //            Producto.Descripcion = value;
        //        }
        //    }
        //}
    }
}
