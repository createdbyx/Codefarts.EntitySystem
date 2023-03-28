namespace Codefarts.EntitySystem.Systems;

public interface ISystem : IDisposable
{
    void Initialize(World world);
}