using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso
{
    public class Producto : Entity
    {
        public Producto()
        {
            DetalleCompra = new List<DetalleCompra>();
            DetalleFactura = new List<DetalleFactura>();
        }

        [Required]
        [MaxLength(15)]
        [Index("Producto_Codigo_Index", IsUnique = true)]
        public string Codigo { get; set; }
        [Required]
        [MaxLength(40)]
        public string Descripcion { get; set; }
        [Required]
        public Categoria Categoria { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public string Medida { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }
        public override string DisplayMember
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
    }
}
