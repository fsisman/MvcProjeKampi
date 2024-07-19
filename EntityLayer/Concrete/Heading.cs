using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Heading
    {
        [Key]
        public int headingId { get; set; }
        [StringLength(50)]

        public string headingName { get; set; }
        public DateTime headingDate { get; set; }

        public int categoryId { get; set; }
        public virtual Category category { get; set; }

        public int writerId { get; set; }
        public virtual Writer writer { get; set; }
        public ICollection<Content> contents { get; set; }
    
    
    
    }
}
