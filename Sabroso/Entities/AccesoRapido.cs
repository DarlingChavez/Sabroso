using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sabroso.Entities
{
    public class AccesoRapido : Entity
    {
        public AccesoRapido()
        {

        }
        
        [Required]
        [ForeignKey("Producto")]
        public int IdProducto { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
