using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    public class Book:Entity
    {
      
        public string Title { get; set; }
        public DateTime CreateddDate { get; set; } = DateTime.Now;
        public int AuthorId { get; set; }
        public Author Authors { get; set; }
        public int? BookCoverId { get; set; }
        public BookCover BookCovers { get; set; }
    }
}
