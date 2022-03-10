using DataAccess.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly KataBankAccountContext _context;
        private readonly ILogger _logger;


        public UnitOfWork(KataBankAccountContext context, ILoggerFactory loggerFactory)
        {
            _context = context;
            _logger = loggerFactory.CreateLogger("logs");

        }
        public void Dispose()
        {
            _context.Dispose();
        }

        async Task IUnitOfWork.CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
