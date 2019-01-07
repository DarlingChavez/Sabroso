using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso
{
    public class Proveedor : Entity
    {
        public Proveedor()
        {
            CabeceraCompra = new List<CabeceraCompra>();
        }
        
        [MaxLength(13)]
        [Index("Proveedor_Ruc_Index", IsUnique = true)]
        public string Ruc { get; set; }
        [Required]
        [MaxLength(40)]
        public string Descripcion { get; set; }
        public virtual ICollection<CabeceraCompra> CabeceraCompra { get; set; }

        public override string DisplayMember
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
    }
}
