using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SchoolManegment.Entities
{
    public class Author:Entity
    {
        
       
        public string Name { get; set; }
        
        public string Gender { get; set; }
    
    }
}
