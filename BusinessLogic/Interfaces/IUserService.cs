﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Models;

namespace BusinessLogic.Interfaces
{
    public interface IUserService
    {
        Task<List<Пользователи>> GetAll();
        Task<Пользователи> GetById(int id);
        Task Create(Пользователи model);
        Task Update(Пользователи model);
        Task Delete(int id);
    }
}
