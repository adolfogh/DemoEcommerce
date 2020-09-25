using System.Data;
using System.Dynamic;

namespace agh.ecommerce.Util.Common
{
    public interface IConnectionFactory
    {
        IDbConnection GetConnection { get; }

    }
}