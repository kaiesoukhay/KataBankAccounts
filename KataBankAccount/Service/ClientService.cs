using DataAccess.Models;
using DataAcess.Interface;
using Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Service
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _ClientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _ClientRepository = clientRepository;

        }
        public Client GetAcountByAccountNumber(int AccountNumber)
        {
            try
            {
                var a = _ClientRepository.GetAcountByAccountNumber(AccountNumber);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public IList<Operation> GetTransactionsOfAccount(int AccountNumber)
        {
            try
            {
                var a = _ClientRepository.GetTransactionsOfAccount(AccountNumber);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Client SaveMoneyAccount(int AccountNumber, int amount)
        {
            try
            {
                var a = _ClientRepository.SaveMoneyAccount(AccountNumber, amount);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Client WithDrawalMoneyAccount(int AccountNumber, int amount)
        {
            try
            {
                var a = _ClientRepository.WithDrawalMoneyAccount(AccountNumber, amount);
                return a;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
