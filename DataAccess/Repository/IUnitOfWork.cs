using System.Threading.Tasks;

namespace DataAcess.Repository
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }

}
