using MagicOnion;
using MagicOnion.Server;
using MagicOnionSample.ServiceDefinition;

namespace MagicOnionSample.Server
{
#pragma warning disable 1998
    public class MyFirstService : ServiceBase<IMyFirstService>, IMyFirstService
    {
        public async UnaryResult<int> SumAsync(int x, int y)
        {
            Logger.Debug($"Received:{x}, {y}");

            return x + y;
        }
    }
#pragma warning restore 1998
}
