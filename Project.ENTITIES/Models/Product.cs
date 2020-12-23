
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public int? CategoryID { get; set; }

        //RelationProperties
        public virtual Category Category { get; set; }
    }
}
