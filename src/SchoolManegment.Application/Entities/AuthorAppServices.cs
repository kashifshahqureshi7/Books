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
    public class AuthorAppServices:AsyncCrudAppService<Author,AuthorDto,int,PagedRoleResultRequestDto>
    {
        private readonly IRepository<Author> _authorRepository;

        public AuthorAppServices( IRepository<Author> AuthorRepository ):base( AuthorRepository )
        {
           _authorRepository = AuthorRepository;
        }
    }
}
