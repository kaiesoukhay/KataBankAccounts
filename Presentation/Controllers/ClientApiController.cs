using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace Presentation.Controllers
{
    [Produces("application/json")]
    [Route("api/Client")]
    [ApiController]
    public class ClientApiController : ControllerBase
    {
        private readonly IClientService _repo;
        public ClientApiController(IClientService repo)
        {
            _repo = repo;

        }

        [HttpPost]
        [Route("GetAcountByAccountNumber")]
        public ActionResult<Client> GetAcountByAccountNumber(int AccountNumber)
        {
            var ClientByAccountNumber = _repo.GetAcountByAccountNumber(AccountNumber);
            return Ok(ClientByAccountNumber);
        }

        [HttpPost]
        [Route("GetAcountByAccountNumber")]
        public ActionResult<IList<Operation>> GetTransactionsOfAccount(int AccountNumber)
        {
            var TransqctionList = _repo.GetTransactionsOfAccount(AccountNumber);
            return Ok(TransqctionList);
        }

        [HttpPost]
        [Route("SaveMoneyAccount")]
        public ActionResult<IList<Operation>> SaveMoneyAccount(int AccountNumber , int ammount)
        {
            var MoneySaved = _repo.SaveMoneyAccount(AccountNumber, ammount);
            return Ok(MoneySaved);
        }

        [HttpPost]
        [Route("WithDrawalMoneyAccount")]
        public ActionResult<IList<Operation>> WithDrawalMoneyAccount(int AccountNumber, int ammount)
        {
            var WithDrawalMoney = _repo.SaveMoneyAccount(AccountNumber, ammount);
            return Ok(WithDrawalMoney);
        }
    }
}
