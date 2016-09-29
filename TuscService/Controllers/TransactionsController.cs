using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

using TuscData;

namespace TuscService.Controllers
{
    public class TransactionsController : ApiController
    {
        // GET api/transactions
        [HttpGet]
        [Route("transactions")]
        public IEnumerable<Transaction> Get()
        {
            return DataManager.GetTransactions();
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // GET api/transactions?startDate=20160101&endDate=20161231
        [HttpGet]
        [Route("transactions")]
        public IEnumerable<Transaction> GetTransactionRange(DateTime startDate, DateTime endDate)
        {
            return DataManager.GetTransactions().Where(t => t.Date > startDate & t.Date < endDate);
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}