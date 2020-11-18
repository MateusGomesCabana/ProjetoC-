using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ProjBiblio.Domain.Entities;

namespace ProjBiblio.Domain.Interfaces {    
    public  interface  IAutorRepository :  IRepository<Autor>     {
        IEnumerable<Autor> GetAutoresContemNome (string nome);
    }
}