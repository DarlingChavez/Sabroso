using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso
{
    public class CabeceraCompra : Entity
    {
        public CabeceraCompra()
        {
            DetalleCompra = new List<DetalleCompra>();
        }
        
        [Required]
        [ForeignKey("Proveedor")]
        public int IdProveedor { get; set; }
        public Proveedor Proveedor { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        public virtual ICollection<DetalleCompra> DetalleCompra { get; set; }

        public override string DisplayMember
        {
            get
            {
                return (Proveedor != null) ? Proveedor.Descripcion : string.Empty;
            }
            set
            {
                if (Proveedor != null)
                {
                    Proveedor.Descripcion = value;
                }
            }
        }
    }
}
