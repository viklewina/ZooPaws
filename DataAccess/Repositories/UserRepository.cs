using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.Models;

namespace DataAccess.Repositories
{
    public class UserRepository : RepositoryBase<Пользователи>, IUserRepository
    {
        public UserRepository(AnimalsContext repositoryContext)
            : base(repositoryContext) 
        { 
        }
    }
}
