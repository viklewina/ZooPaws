﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Interfaces;
using DataAccess.Models;
using DataAccess.Repositories;

namespace DataAccess.Wrapper
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private AnimalsContext _repoContext;

        private IUserRepository _user;
        public IUserRepository User
        {  
            get 
            { 
                if (_user==null)
                {
                    _user = new UserRepository(_repoContext);
                }
                return _user; 
            } 
        }

        public RepositoryWrapper(AnimalsContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
        public void Save()
        {
            _repoContext.SaveChanges();
        }
    }
}
