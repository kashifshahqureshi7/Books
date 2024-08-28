using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using SchoolManegment.Roles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http.HttpResults;
using Newtonsoft.Json;

namespace SchoolManegment.Entities
{
    public class AuthorAppServices:AsyncCrudAppService<Author,AuthorDto,int,PagedRoleResultRequestDto>
    {
        private readonly IRepository<Author> _authorRepository;
        private readonly IRepository<Book> _bookRepository;

        public AuthorAppServices( IRepository<Author> AuthorRepository ,
            IRepository<Book> BookRepository):base( AuthorRepository )
        {
           _authorRepository = AuthorRepository;
            _bookRepository = BookRepository;
        }
        public async Task<List<AuthorwithBookDto>> GetAuthorwithBook( string authorname )
        {
              var lowerauthorname=authorname.ToLower();
            var authorswithBooks=await _authorRepository.GetAll().Where (a=>a.Name.ToLower().Contains(lowerauthorname) ).Select(author => new AuthorwithBookDto
            {
                Id=author.Id,
                Name=author.Name,
                Gender=author.Gender,
                Books=_bookRepository.GetAll().Where(b=>b.AuthorId==author.Id).Select(book=>ObjectMapper.Map<BookDto>(book)).ToList(),
            }).ToListAsync();
            if(authorswithBooks==null)
            {
                throw new EntityNotFoundException(typeof(Author),authorname);
            }
            return authorswithBooks;
          


        }
        public async Task<List<AuthorDto>> GetAuthorByName( string AuthorName )
        {
            var lowerauthername=AuthorName.ToLower();
           // var author = await _authorRepository.FirstOrDefaultAsync( a => a.Name.ToLower().Contains(lowerauthername) );
           var author= await (from Author in _authorRepository.GetAll() where Author.Name.ToLower().StartsWith(lowerauthername) select new AuthorDto{ 
               Name=Author.Name,
               Gender=Author.Gender

           
           }).ToListAsync();
            
            if (author==null)
            {
                throw new EntityNotFoundException(typeof(Author),AuthorName);
            }
           
            // var authordto=ObjectMapper.Map<AuthorDto>(author);
            return author;
        }

    }
}
