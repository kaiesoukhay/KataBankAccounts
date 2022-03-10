using DataAccess.Models;
using System.Collections.Generic;

namespace DataAcess.Interface
{
    public interface IClientRepository 
    {
        public Client GetAcountByAccountNumber(int AccountNumber);
        public Client SaveMoneyAccount(int AccountNumber , int amount);
        public Client WithDrawalMoneyAccount(int AccountNumber , int amount);
        public IList<Operation> GetTransactionsOfAccount(int AccountNumber);

    }
   

}
