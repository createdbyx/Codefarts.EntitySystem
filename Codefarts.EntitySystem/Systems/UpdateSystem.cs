 
namespace Codefarts.EntitySystem.Systems;

public interface IUpdateSystem : ISystem
{
    void Update( TimeSpan elapsedTime,TimeSpan totalTime);
}

public abstract class UpdateSystem : IUpdateSystem
{
    public virtual void Dispose() { }
    public virtual void Initialize(World world) { }
    public abstract void Update( TimeSpan elapsedTime,TimeSpan totalTime);
}