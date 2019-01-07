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
        public string Ruc
        {
            get { return CodigoFilter; }
            set { CodigoFilter = value; }
        }
        [Required]
        [MaxLength(40)]
        public string Descripcion
        {
            get { return DisplayMember; }
            set { DisplayMember = value; }
        }
        public virtual ICollection<CabeceraCompra> CabeceraCompra { get; set; }

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
