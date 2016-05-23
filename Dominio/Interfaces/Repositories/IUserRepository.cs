﻿using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Repositories
{
    public interface IUserRepository :  IRepositoryBase<User>
    {
        bool Autorizado(User u);
    }
} 
