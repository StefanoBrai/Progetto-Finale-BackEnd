using ProgettoFinaleBack.Models.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProgettoFinaleBack.Models.Repositories.Implementations
{
    public class EFMailCrud : EfCrudRepository<Mail>, MailCrud
    {
        public EFMailCrud(ProgettoFinaleContext ctx) : base(ctx) 
        { 
        }
    }
}