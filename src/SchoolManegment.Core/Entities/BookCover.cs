using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    public class BookCover:Entity
    {
       
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Authors { get; set; }
    }
}
