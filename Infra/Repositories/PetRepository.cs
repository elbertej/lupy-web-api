﻿using Infra.DataAccess;
using Lupy.Domain.Entities;
using Lupy.Domain.Interfaces.IRepositories;
using Lupy.Infra.Repositories.Base;

namespace Lupy.Infra.Repositories
{
    public class PetRepository : Repository<Pet>, IPetRepository
    {
        public PetRepository(DBContext DbContext)
            : base(DbContext) { }
    }
}
 