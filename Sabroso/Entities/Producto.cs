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
        public string Codigo
        {
            get { return CodigoFilter; }
            set { CodigoFilter = value; }
        }
        //private string descripcion;
        [Required]
        [MaxLength(40)]
        public string Descripcion
        {
            get { return DisplayMember; }
            set { DisplayMember = value; }
        }
        [Required]
        public Categoria Categoria { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public Medida Medida { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }

        public new string DisplayMember
        {
            get { return base.DisplayMember; }
            set { base.DisplayMember = value; }
        }
        public new string CodigoFilter
        {
            get { return base.CodigoFilter; }
            set { base.CodigoFilter = value; }
        }
    }
}
