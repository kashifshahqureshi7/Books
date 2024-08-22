using Abp.Application.Services;
using Abp.Domain.Repositories;
using SchoolManegment.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    public class BookCoverAppServices:AsyncCrudAppService<BookCover,BookCoverDto,int,PagedRoleResultRequestDto>
    {
        private readonly IRepository<BookCover> _bookCoverRepository;
        public BookCoverAppServices(IRepository<BookCover> BookCoverRepository):base(BookCoverRepository) 
        {
            _bookCoverRepository = BookCoverRepository;
        }
    }
}
