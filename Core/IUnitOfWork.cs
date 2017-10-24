using System.Threading.Tasks;

namespace auto_reg.Core
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
