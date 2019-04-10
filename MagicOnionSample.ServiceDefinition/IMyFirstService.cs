using MagicOnion;

namespace MagicOnionSample.ServiceDefinition
{
    public interface IMyFirstService : IService<IMyFirstService>
    {
        UnaryResult<int> SumAsync(int x, int y);
    }
}
