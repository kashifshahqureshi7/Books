using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using SchoolManegment.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    public class BookAppServices:AsyncCrudAppService<Book,BookDto,int,PagedRoleResultRequestDto>
    {
        private readonly IRepository<Book> _bookRepository;
        public BookAppServices(IRepository<Book> BookRepository):base(BookRepository) 
        {
            _bookRepository = BookRepository;
        }
        public async Task<BookDto> GetBookByName(string booktitle )
        {
            var book = await _bookRepository
          .FirstOrDefaultAsync( b => b.Title.ToLower() == booktitle.ToLower() );
            if (book == null)
            {
                throw new EntityNotFoundException( typeof( Book ) , booktitle );
            }
            var bookDto = ObjectMapper.Map< BookDto>( book );

            return bookDto;
        }
    }
}
