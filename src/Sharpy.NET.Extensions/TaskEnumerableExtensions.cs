using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpyNet.Extensions
{
    public static class TaskEnumerableExtensions
    {
        public async static Task<T[]> ToArrayAsync<T>(this Task<IEnumerable<T>> taskEnumerable)
        {
            return await Task.FromResult((await taskEnumerable).ToArray());
        }
    }
}
