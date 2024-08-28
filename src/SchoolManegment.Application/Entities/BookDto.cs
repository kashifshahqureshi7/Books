using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    [AutoMapTo(typeof(Book)),AutoMapFrom(typeof(Book))]
    public class BookDto:EntityDto<int>
    {
        
        public string Title { get; set; }
        public DateTime CreateddDate { get; set; } = DateTime.Now;
        public int AuthorId { get; set; }
        public int? BookCoverId { get; set; }
       
    }
}
