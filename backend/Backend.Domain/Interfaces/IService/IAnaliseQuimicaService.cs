﻿using Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Domain.Interfaces.IService
{
    public interface IAnaliseQuimicaService : IBaseService<AnaliseQuimica>
    {
        List<decimal> RecCalagem(decimal v2, decimal PRNT, Guid currentUserID);
        void CreateByUser(AnaliseQuimica analise, Guid id);
        Task<IEnumerable<AnaliseQuimica>> GetAnaliseByUserId(Guid UserId);
    }
}
