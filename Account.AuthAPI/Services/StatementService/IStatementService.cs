﻿using Account.AuthAPI.Service.Common;
using BankAccountAPI.Model;

namespace AccountManagement.API.Services.StatementService
{
    public interface IStatementService
    {
        Task<ServiceResult<List<Statement>>> GetAllStatementByAccountIdAsync(int accountId);

        Task<ServiceResult<Statement>> AddStatementAsync(Statement entity);
    }
}