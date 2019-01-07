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
        public decimal PrecioUnitario { get; set; }
        [Required]
        public decimal Subtotal { get; set; }
        [Required]
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }
        public virtual Producto Producto { get; set; }
        [Required]
        [ForeignKey("CabeceraFactura")]
        public int IdCabeceraFactura { get; set; }
        public virtual CabeceraFactura CabeceraFactura { get; set; }

        public new string DisplayMember
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
        [NotMapped]
        public string PrecioString
        {
            get { return PrecioUnitario.ToString("C"); }
        }
        [NotMapped]
        public string SubTotalString
        {
            get { return Subtotal.ToString("C"); }
        }
    }
}
