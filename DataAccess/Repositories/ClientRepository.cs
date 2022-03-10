
using DataAccess.Models;
using DataAcess.Interface;
using System.Collections.Generic;
using System.Linq;

namespace DataAcess.Repositories
{
    public class ClientRepository : IClientRepository

    {
        private readonly KataBankAccountContext _dbContext;

        public ClientRepository(KataBankAccountContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Client GetAcountByAccountNumber(int AccountNumber)
        {
            try
            {
                var c = _dbContext.Clients.Where(p => p.NumCompte == AccountNumber).FirstOrDefault();
                return c;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public IList<Operation> GetTransactionsOfAccount(int AccountNumber)
        {
            try
            {

                var c = _dbContext.Operation.Where(p => p.Clients.NumCompte == AccountNumber).OrderByDescending(x => x.Date).ToList();
                return c;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
        public Client SaveMoneyAccount(int AccountNumber, int amount)
        {
            try
            {
                Client Clients = GetAcountByAccountNumber(AccountNumber);
                Clients.Balance = Clients.Balance + amount;

                Operation transaction = new Operation();
                transaction.Date = new System.DateTime();
                transaction.Montant = amount;
                transaction.Type = 'S';
                transaction.Clients = Clients;
                var x = _dbContext.Operation.Add(transaction);
                var y = _dbContext.Clients.Add(Clients);
                return Clients;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }

        public Client WithDrawalMoneyAccount(int AccountNumber, int amount)
        {
            try
            {
                Client Clients = GetAcountByAccountNumber(AccountNumber);
                Clients.Balance = Clients.Balance - amount;
                Operation transaction = new Operation();
                transaction.Date = new System.DateTime();
                transaction.Montant = amount;
                transaction.Type = 'S';
                transaction.Clients = Clients;
                var x = _dbContext.Operation.Add(transaction);
                var y = _dbContext.Clients.Add(Clients);
                return Clients;
            }
            catch (System.Exception ex)
            {

                throw ex;
            };
        }
    }
}
