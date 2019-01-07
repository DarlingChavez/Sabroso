using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso
{
    public class CabeceraFactura : Entity
    {
        public CabeceraFactura()
        {
            DetalleFactura = new List<DetalleFactura>();
        }
        
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }

        //public override string DisplayMember
        //{
        //    get { return (Cliente != null) ? Cliente.Nombre : string.Empty; }
        //    set {
        //        if (Cliente != null)
        //        {
        //            Cliente.Nombre = value;
        //        }
        //    }
        //}
    }
}
