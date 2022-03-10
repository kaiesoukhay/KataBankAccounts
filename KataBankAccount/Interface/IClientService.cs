using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interface
{
     public interface IClientService
    {
        public Client GetAcountByAccountNumber(int AccountNumber);
        public Client SaveMoneyAccount(int AccountNumber, int amount);
        public Client WithDrawalMoneyAccount(int AccountNumber, int amount);
        public IList<Operation> GetTransactionsOfAccount(int AccountNumber);
    }
}
