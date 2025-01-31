﻿using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    [AutoMapTo(typeof(BookCover)),AutoMapFrom(typeof(BookCover))]
    public class BookCoverDto:EntityDto<int>
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
