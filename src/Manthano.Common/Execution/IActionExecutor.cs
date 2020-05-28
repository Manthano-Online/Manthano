using System.Threading.Tasks;
using Manthano.Common.Actions.Base;

namespace Manthano.Common.Execution
{
    public interface IActionExecutor
    {
        Task<TResult> Execute<TResult>(AbstractAction<TResult> action) where TResult : AbstractActionResult;
    }
}
