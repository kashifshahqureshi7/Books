using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    [AutoMapTo(typeof(Author)),AutoMapFrom(typeof(Author))]
    public class AuthorDto:EntityDto<int>
    {
        public string Name { get; set; }

        public string Gender { get; set; }
    }
}
