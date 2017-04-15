using GitAll.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using GitAll.Core.Model;

namespace GitAll.Core.Services
{
    public class AccountService : IAccountService
    {
        public List<Account> AvialableAccounts()
        {
            return new List<Account>();
        }
    }
}
