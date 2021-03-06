﻿using Dunyana.Domain;
using Microsoft.AspNetCore.Http;
using Sym.Core.DataAccess;

namespace Dunyana.DataAccess.Repositories
{
    public class MerchantRequestDetailsRepository : Repository<MerchantRequestDetails>
    {
        public MerchantRequestDetailsRepository(DunyanaDbContext dbContext, IHttpContextAccessor httpContextAccessor) :
            base(dbContext, httpContextAccessor)
        {
        }

    }

}