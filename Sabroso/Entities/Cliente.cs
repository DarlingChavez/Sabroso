using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso
{
    public class Cliente : Entity
    {
        public Cliente()
        {
            CabeceraFactura = new List<CabeceraFactura>();
        }
        
        [Required]
        [MaxLength(13)]
        [Index("CabeceraFactura_Cedula_Index", IsUnique = true)]
        public string Cedula
        {
            get { return CodigoFilter; }
            set { CodigoFilter = value; }
        }
        [Required]
        [MaxLength(50)]
        public string Nombre {
            get { return DisplayMember; }
            set { DisplayMember = value; }
        }
        public virtual ICollection<CabeceraFactura> CabeceraFactura { get; set; }

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
