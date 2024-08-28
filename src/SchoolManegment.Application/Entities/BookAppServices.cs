using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using SchoolManegment.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
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
        public async Task<List<BookDto>> GetBookByName(string booktitle )
        {
            var lowerbookname=booktitle.ToLower();
            var book = await _bookRepository.GetAll().Where(a=>a.Title.ToLower().StartsWith(lowerbookname)).ToListAsync();
            //var book = await(from Book in  _bookRepository.GetAll() where Book.Title.ToLower().StartsWith(lowerbookname) select new BookDto
            //{
            //    Title= Book.Title,
            //    CreateddDate= DateTime.Now,
            //    AuthorId=Book.AuthorId,
            //    BookCoverId=Book.BookCoverId

            //}).ToListAsync();
          
            if (book == null)
            {
                throw new EntityNotFoundException( typeof( Book ) , booktitle );
            }
            var bookDto =book.Select(book=> ObjectMapper.Map< BookDto>( book )).ToList();

            return bookDto;
        }
        
        public async Task<List<BookDto>> GetBOOK( int? pagenumber,int? pagesize )
        {
            int currentpagenumber = pagenumber ?? 1;
            int currentpagesize = pagesize ?? 2;
            var book=await(from Book in _bookRepository.GetAll() select new BookDto
            {
                Id=Book.Id ,
                Title=Book.Title ,
                CreateddDate = Book.CreateddDate , AuthorId = Book.AuthorId , BookCoverId= Book.BookCoverId ,
            })
             .Skip( (currentpagenumber - 1) * currentpagesize )
                      .Take( currentpagesize )
                      .ToListAsync();
            return book;
        }


    }
}
